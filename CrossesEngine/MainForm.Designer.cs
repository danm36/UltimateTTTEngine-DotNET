namespace CrossesEngine
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bot1ExeTxtBox = new System.Windows.Forms.TextBox();
            this.bot1ExeBrowseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bot1ArgsTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bot2ExeTxtBox = new System.Windows.Forms.TextBox();
            this.bot2ArgsTxtBox = new System.Windows.Forms.TextBox();
            this.bot2ExeBrowseBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gameBoard = new CrossesEngine.UTTBoard();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 603);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(5, 27);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(87, 23);
            this.startStopBtn.TabIndex = 3;
            this.startStopBtn.Text = "Start/Restart";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(0, 24);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(784, 32);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Press the Start/Restart button to begin";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gameBoard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 472);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bot2ExeBrowseBtn);
            this.panel2.Controls.Add(this.bot1ExeBrowseBtn);
            this.panel2.Controls.Add(this.bot2ArgsTxtBox);
            this.panel2.Controls.Add(this.bot1ArgsTxtBox);
            this.panel2.Controls.Add(this.bot2ExeTxtBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bot1ExeTxtBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 75);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bot 1:";
            // 
            // bot1ExeTxtBox
            // 
            this.bot1ExeTxtBox.Location = new System.Drawing.Point(119, 8);
            this.bot1ExeTxtBox.Name = "bot1ExeTxtBox";
            this.bot1ExeTxtBox.Size = new System.Drawing.Size(237, 20);
            this.bot1ExeTxtBox.TabIndex = 1;
            // 
            // bot1ExeBrowseBtn
            // 
            this.bot1ExeBrowseBtn.Location = new System.Drawing.Point(362, 6);
            this.bot1ExeBrowseBtn.Name = "bot1ExeBrowseBtn";
            this.bot1ExeBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.bot1ExeBrowseBtn.TabIndex = 2;
            this.bot1ExeBrowseBtn.Text = "Browse...";
            this.bot1ExeBrowseBtn.UseVisualStyleBackColor = true;
            this.bot1ExeBrowseBtn.Click += new System.EventHandler(this.bot1ExeBrowseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Executable:";
            // 
            // bot1ArgsTxtBox
            // 
            this.bot1ArgsTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bot1ArgsTxtBox.Location = new System.Drawing.Point(480, 8);
            this.bot1ArgsTxtBox.Name = "bot1ArgsTxtBox";
            this.bot1ArgsTxtBox.Size = new System.Drawing.Size(292, 20);
            this.bot1ArgsTxtBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Args:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bot 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Executable:";
            // 
            // bot2ExeTxtBox
            // 
            this.bot2ExeTxtBox.Location = new System.Drawing.Point(119, 34);
            this.bot2ExeTxtBox.Name = "bot2ExeTxtBox";
            this.bot2ExeTxtBox.Size = new System.Drawing.Size(237, 20);
            this.bot2ExeTxtBox.TabIndex = 1;
            // 
            // bot2ArgsTxtBox
            // 
            this.bot2ArgsTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bot2ArgsTxtBox.Location = new System.Drawing.Point(480, 34);
            this.bot2ArgsTxtBox.Name = "bot2ArgsTxtBox";
            this.bot2ArgsTxtBox.Size = new System.Drawing.Size(292, 20);
            this.bot2ArgsTxtBox.TabIndex = 1;
            // 
            // bot2ExeBrowseBtn
            // 
            this.bot2ExeBrowseBtn.Location = new System.Drawing.Point(362, 32);
            this.bot2ExeBrowseBtn.Name = "bot2ExeBrowseBtn";
            this.bot2ExeBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.bot2ExeBrowseBtn.TabIndex = 2;
            this.bot2ExeBrowseBtn.Text = "Browse...";
            this.bot2ExeBrowseBtn.UseVisualStyleBackColor = true;
            this.bot2ExeBrowseBtn.Click += new System.EventHandler(this.bot2ExeBrowseBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Note: Leave the executable field blank to use the built in random bot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Args:";
            // 
            // gameBoard
            // 
            this.gameBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameBoard.Location = new System.Drawing.Point(160, 10);
            this.gameBoard.Margin = new System.Windows.Forms.Padding(0);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(450, 450);
            this.gameBoard.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 664);
            this.Name = "MainForm";
            this.Text = "Crosses Engine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private UTTBoard gameBoard;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bot2ExeBrowseBtn;
        private System.Windows.Forms.Button bot1ExeBrowseBtn;
        private System.Windows.Forms.TextBox bot2ArgsTxtBox;
        private System.Windows.Forms.TextBox bot1ArgsTxtBox;
        private System.Windows.Forms.TextBox bot2ExeTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bot1ExeTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

