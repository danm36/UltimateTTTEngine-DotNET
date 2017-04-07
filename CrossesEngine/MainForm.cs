using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossesEngine
{
    public partial class MainForm : Form
    {
        static MainForm instance;

        BasicBot[] bots = new BasicBot[2];
        Random random = new Random();
        Thread gameThread = null;
        string[] cmdArgs;

        public MainForm(string[] args)
        {
            instance = this;

            InitializeComponent();

            if(args.Length > 2)
            {
                Console.Error.WriteLine("Too many bots supplied on command line. Quitting.");
                Close();
                return;
            }

            cmdArgs = args;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopMatch();
        }

        public void StartMatch()
        {
            StopMatch();
            gameBoard.Reset();

            //Spawn bots
            statusLabel.Text = "Spawning player 1";
            if (bot1ExeTxtBox.Text.Trim().Length == 0)
                bots[0] = new RandomBot();
            else
                bots[0] = new ProcessBot(bot1ExeTxtBox.Text, bot1ArgsTxtBox.Text);
            bots[0].ID = 0;

            statusLabel.Text = "Spawning player 2";
            if (bot2ExeTxtBox.Text.Trim().Length == 0)
                bots[1] = new RandomBot();
            else
                bots[1] = new ProcessBot(bot2ExeTxtBox.Text, bot2ArgsTxtBox.Text);
            bots[1].ID = 1;

            gameThread = new Thread(GameLoop);
            gameThread.Start();
            statusLabel.Text = "Playing";
        }

        public void StopMatch()
        {
            if (gameThread != null)
            {
                gameThread.Abort();
                gameThread.Join();
                gameThread = null;
            }

            for (int i = 0; i < bots.Length; ++i)
            {
                if (bots[i] != null)
                {
                    bots[i].Shutdown();
                    bots[i] = null;
                }
            }
        }

        private void GameLoop()
        {
            int currentBot = 0;
            int winner = 0;
            int round = 0, move = 0;
            int invalidMoveCounter = 0;

            int pX, pY, lX, lY, mX, mY;

            int[,] currentMacroBoard = new int[3, 3]
            {
                { -1, -1, -1 },
                { -1, -1, -1 },
                { -1, -1, -1 }
            };
            int[] currentMacroBoardLinear = new int[3 * 3];
            int[] currentField = new int[9 * 9];

            for(int i = 0; i <= 1; ++i)
            {
                bots[i].StandardInput.WriteLine($"settings timebank 10000"); bots[currentBot].StandardInput.Flush();
                bots[i].StandardInput.WriteLine($"settings time_per_move 500"); bots[currentBot].StandardInput.Flush();
                bots[i].StandardInput.WriteLine($"settings player_names player1,player2"); bots[currentBot].StandardInput.Flush();
                bots[i].StandardInput.WriteLine($"settings your_bot player{i + 1}"); bots[currentBot].StandardInput.Flush();
                bots[i].StandardInput.WriteLine($"settings your_botid {i + 1}"); bots[currentBot].StandardInput.Flush();
            }

            try
            {
                while (true)
                {
                    ++move;
                    if (currentBot == 0)
                        ++round;

                    for (int y = 0; y < 3; ++y)
                    {
                        for (int x = 0; x < 3; ++x)
                        {
                            currentMacroBoardLinear[y * 3 + x] = currentMacroBoard[x, y];
                            UTTSmallBoard board = gameBoard.GetBoard(x, y);

                            for (mX = 0; mX < 3; ++mX)
                            {
                                for (mY = 0; mY < 3; ++mY)
                                {
                                    currentField[(y * 3 + mY) * 9 + (x * 3 + mX)] = board.tileStates[mX, mY];
                                }
                            }
                        }
                    }

                    bots[currentBot].StandardInput.WriteLine($"update game round {round}"); bots[currentBot].StandardInput.Flush();
                    bots[currentBot].StandardInput.WriteLine($"update game move {move}"); bots[currentBot].StandardInput.Flush();
                    bots[currentBot].StandardInput.WriteLine($"update game field {string.Join(",", currentField)}"); bots[currentBot].StandardInput.Flush();
                    bots[currentBot].StandardInput.WriteLine($"update game macroboard {string.Join(",", currentMacroBoardLinear)}"); bots[currentBot].StandardInput.Flush();

                    invalidMoveCounter = 0;
                    while (++invalidMoveCounter <= 3)
                    {
                        bots[currentBot].StandardInput.WriteLine($"action move 10000"); bots[currentBot].StandardInput.Flush();
                        string cmd = null;
                        while (cmd == null)
                            cmd = bots[currentBot].StandardOutput.ReadLine();

                        /*
                        string err = bots[currentBot].StandardError.ReadLine();
                        if (err != null)
                            Console.WriteLine(err);
                        */

                        if (cmd.StartsWith("place_move"))
                        {
                            string[] splString = cmd.Split(' ');
                            pX = int.Parse(splString[1]);
                            pY = int.Parse(splString[2]);
                            lX = pX / 3;
                            lY = pY / 3;
                            mX = pX % 3;
                            mY = pY % 3;

                            if (currentMacroBoard[lX, lY] != -1 || currentField[pY * 9 + pX] > 0) //Invalid move - Prompt again
                                continue;

                            Invoke(new Action(() => gameBoard.SetTile(pX, pY, currentBot + 1)));
                            currentMacroBoard[lX, lY] = gameBoard.GetBoard(lX, lY).winner;

                            bool nextBoardIsComplete = gameBoard.GetBoard(mX, mY).isComplete;
                            for (int y = 0; y < 3; ++y)
                            {
                                for (int x = 0; x < 3; ++x)
                                {
                                    if (nextBoardIsComplete)
                                    {
                                        if (currentMacroBoard[x, y] <= 0 && !gameBoard.GetBoard(x, y).isComplete)
                                            currentMacroBoard[x, y] = -1;
                                    }
                                    else if (currentMacroBoard[x, y] <= 0)
                                    {
                                        if (x == mX && y == mY)
                                        {
                                            currentMacroBoard[x, y] = -1;
                                        }
                                        else
                                        {
                                            currentMacroBoard[x, y] = 0;
                                        }
                                    }
                                }
                            }

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error from bot: " + cmd);
                        }
                    }

                    if(invalidMoveCounter > 3)
                    {
                        Console.WriteLine($"Bot '{bots[currentBot].Name}' (ID {bots[currentBot].ID}) placed an invalid move 3 times. Match stopped.");
                        Invoke(new Action(() => statusLabel.Text = $"Bot {bots[currentBot].ID + 1} placed an invalid move 3 times. Match stopped."));
                        StopMatch();
                    }

                    winner = CheckForWinner(currentMacroBoard);

                    if (winner == -1)
                    {
                        Invoke(new Action(() => statusLabel.Text = $"It's a draw!"));
                        break;
                    }
                    else if (winner != 0)
                    {
                        Invoke(new Action(() => statusLabel.Text = $"Winner is player {winner}!"));
                        break;
                    }

                    Thread.Sleep(10);
                    currentBot = 1 - currentBot;
                }
            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();
            }
        }

        private int CheckForWinner(int[,] currentLargeBoard)
        {
            for (int x = 0; x < 3; ++x)
            {
                if (currentLargeBoard[x, 0] > 0 && currentLargeBoard[x, 0] == currentLargeBoard[x, 1] && currentLargeBoard[x, 0] == currentLargeBoard[x, 2])
                {
                    return currentLargeBoard[x, 0];
                }
            }

            for (int y = 0; y < 3; ++y)
            {
                if (currentLargeBoard[0, y] > 0 && currentLargeBoard[0, y] == currentLargeBoard[1, y] && currentLargeBoard[0, y] == currentLargeBoard[2, y])
                {
                    return currentLargeBoard[0, y];
                }
            }

            if (currentLargeBoard[0, 0] > 0 && currentLargeBoard[0, 0] == currentLargeBoard[1, 1] && currentLargeBoard[0, 0] == currentLargeBoard[2, 2]) //TL to BR
            {
                return currentLargeBoard[0, 0];
            }
            else if (currentLargeBoard[2, 0] > 0 && currentLargeBoard[2, 0] == currentLargeBoard[1, 1] && currentLargeBoard[2, 0] == currentLargeBoard[0, 2]) //TR to BL
            {
                return currentLargeBoard[2, 0];
            }

            //Check for stalemate
            for(int y = 0; y < 3; ++y)
            {
                for(int x = 0; x < 3; ++x)
                {
                    if (!gameBoard.GetBoard(x, y).isComplete)
                        return 0;
                }
            }

            return -1; //Stalemate
        }

        public static void NotifyBotLoss(BasicBot bot) //Bot died somehow. Stop the match
        {
            instance.Invoke(new Action(() => instance.OnNotifyBotLoss(bot)));
        }

        private void OnNotifyBotLoss(BasicBot bot)
        {
            StopMatch();
            Console.WriteLine($"Bot '{bot.Name}' (ID {bot.ID}) died. Match stopped.");
            statusLabel.Text = $"Bot {bot.ID + 1} died. Match stopped.";
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            StartMatch();
        }

        private string OpenBotBrowseDialogue(string initialFile)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executable files|*.exe;*.bat;*.com;*.sh";
            if (initialFile != null)
                ofd.FileName = initialFile;

            if (ofd.ShowDialog() != DialogResult.OK)
                return null;
            return ofd.FileName;
        }

        private void bot1ExeBrowseBtn_Click(object sender, EventArgs e)
        {
            string newBotPath = OpenBotBrowseDialogue(bot1ExeTxtBox.Text);
            if (newBotPath != null)
                bot1ExeTxtBox.Text = newBotPath;
        }

        private void bot2ExeBrowseBtn_Click(object sender, EventArgs e)
        {
            string newBotPath = OpenBotBrowseDialogue(bot2ExeTxtBox.Text);
            if (newBotPath != null)
                bot2ExeTxtBox.Text = newBotPath;
        }
    }
}
