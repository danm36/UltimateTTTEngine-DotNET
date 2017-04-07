using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrossesEngine
{
    public class RandomBot : BasicBot
    {
        private PipeStream inputMemStream;
        private PipeStream outputMemStream;
        private PipeStream errMemStream;

        private TextReader inputReader;
        private TextWriter outputWriter;
        private TextWriter errorWriter;

        private Thread botThread;

        private Random random = new Random();

        public RandomBot()
        {
            Name = "RandomBot";

            inputMemStream = new PipeStream();
            outputMemStream = new PipeStream();
            errMemStream = new PipeStream();

            inputReader = new StreamReader(inputMemStream);
            outputWriter = new StreamWriter(outputMemStream);
            errorWriter = new StreamWriter(errMemStream);

            StandardInput = new StreamWriter(inputMemStream);
            StandardOutput = new StreamReader(outputMemStream);
            StandardError = new StreamReader(errMemStream);

            botThread = new Thread(BotUpdateThread);
            botThread.Start();
        }

        public override void Shutdown()
        {
            botThread.Abort();
            botThread.Join();
        }

        private void BotUpdateThread()
        {
            string input;
            int[,] macroBoard = new int[3, 3];
            int[,] field = new int[9, 9];

            try
            {
                while (true)
                {
                    input = inputReader.ReadLine();
                    if(input == null)
                    {
                        Thread.Sleep(50);
                        continue;
                    }

                    if(input.StartsWith("update game field "))
                    {
                        input = input.Substring("update game field ".Length);
                        string[] splField = input.Split(',');
                        if(splField.Length != 9 * 9)
                        {
                            errorWriter.WriteLine("Error: Supplied field of wrong dimensions");
                            errorWriter.Flush();
                            continue;
                        }
                        for(int y = 0; y < 9; ++y)
                        {
                            for (int x = 0; x < 9; ++x)
                            {
                                field[x, y] = int.Parse(splField[y * 9 + x]);
                            }
                        }
                    }
                    else if (input.StartsWith("update game macroboard "))
                    {
                        input = input.Substring("update game macroboard ".Length);
                        string[] splMacroBoard = input.Split(',');
                        if (splMacroBoard.Length != 3 * 3)
                        {
                            errorWriter.WriteLine("Error: Supplied macroboard of wrong dimensions");
                            errorWriter.Flush();
                            continue;
                        }
                        for (int y = 0; y < 3; ++y)
                        {
                            for (int x = 0; x < 3; ++x)
                            {
                                macroBoard[x, y] = int.Parse(splMacroBoard[y * 3 + x]);
                            }
                        }
                    }
                    else if(input.StartsWith("action move"))
                    {
                        List<Tuple<int, int>> validTiles = new List<Tuple<int, int>>();

                        for (int y = 0; y < 3; ++y)
                        {
                            for (int x = 0; x < 3; ++x)
                            {
                                if (macroBoard[x, y] == -1)
                                    validTiles.Add(new Tuple<int, int>(x, y));
                            }
                        }

                        if (validTiles.Count == 0)
                        {
                            errorWriter.WriteLine("Error: No macro tiles are free. Is the game over?");
                            errorWriter.Flush();
                            continue;
                        }

                        Tuple<int, int> tilePair = validTiles[random.Next(validTiles.Count)];
                        int mX = tilePair.Item1, mY = tilePair.Item2;

                        int rX, rY, attempt = 0;
                        for (; attempt < 65536; ++attempt)
                        {
                            rX = random.Next(mX * 3, (mX + 1) * 3);
                            rY = random.Next(mY * 3, (mY + 1) * 3);
                            if (field[rX, rY] <= 0)
                            {
                                outputWriter.WriteLine($"place_move {rX} {rY}");
                                outputWriter.Flush();
                                break;
                            }
                        }

                        if (attempt >= 65536)
                        {
                            errorWriter.WriteLine("Error: Placement attempts exceeded. 65536 attempts just wasn't enough");
                            errorWriter.Flush();
                        }
                    }
                }
            }
            catch(ThreadAbortException)
            {
                Thread.ResetAbort();
            }
        }
    }
}
