namespace CrossesEngine
{
    partial class UTTBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.board00 = new CrossesEngine.UTTSmallBoard();
            this.board10 = new CrossesEngine.UTTSmallBoard();
            this.board20 = new CrossesEngine.UTTSmallBoard();
            this.board21 = new CrossesEngine.UTTSmallBoard();
            this.board11 = new CrossesEngine.UTTSmallBoard();
            this.board01 = new CrossesEngine.UTTSmallBoard();
            this.board22 = new CrossesEngine.UTTSmallBoard();
            this.board12 = new CrossesEngine.UTTSmallBoard();
            this.board02 = new CrossesEngine.UTTSmallBoard();
            this.SuspendLayout();
            // 
            // board00
            // 
            this.board00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board00.Location = new System.Drawing.Point(0, 0);
            this.board00.Margin = new System.Windows.Forms.Padding(0);
            this.board00.Name = "board00";
            this.board00.Size = new System.Drawing.Size(150, 150);
            this.board00.TabIndex = 0;
            // 
            // board10
            // 
            this.board10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board10.Location = new System.Drawing.Point(150, 0);
            this.board10.Margin = new System.Windows.Forms.Padding(0);
            this.board10.Name = "board10";
            this.board10.Size = new System.Drawing.Size(150, 150);
            this.board10.TabIndex = 1;
            // 
            // board20
            // 
            this.board20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board20.Location = new System.Drawing.Point(300, 0);
            this.board20.Margin = new System.Windows.Forms.Padding(0);
            this.board20.Name = "board20";
            this.board20.Size = new System.Drawing.Size(150, 150);
            this.board20.TabIndex = 2;
            // 
            // board21
            // 
            this.board21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board21.Location = new System.Drawing.Point(300, 150);
            this.board21.Margin = new System.Windows.Forms.Padding(0);
            this.board21.Name = "board21";
            this.board21.Size = new System.Drawing.Size(150, 150);
            this.board21.TabIndex = 5;
            // 
            // board11
            // 
            this.board11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board11.Location = new System.Drawing.Point(150, 150);
            this.board11.Margin = new System.Windows.Forms.Padding(0);
            this.board11.Name = "board11";
            this.board11.Size = new System.Drawing.Size(150, 150);
            this.board11.TabIndex = 4;
            // 
            // board01
            // 
            this.board01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board01.Location = new System.Drawing.Point(0, 150);
            this.board01.Margin = new System.Windows.Forms.Padding(0);
            this.board01.Name = "board01";
            this.board01.Size = new System.Drawing.Size(150, 150);
            this.board01.TabIndex = 3;
            // 
            // board22
            // 
            this.board22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board22.Location = new System.Drawing.Point(300, 300);
            this.board22.Margin = new System.Windows.Forms.Padding(0);
            this.board22.Name = "board22";
            this.board22.Size = new System.Drawing.Size(150, 150);
            this.board22.TabIndex = 8;
            // 
            // board12
            // 
            this.board12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board12.Location = new System.Drawing.Point(150, 300);
            this.board12.Margin = new System.Windows.Forms.Padding(0);
            this.board12.Name = "board12";
            this.board12.Size = new System.Drawing.Size(150, 150);
            this.board12.TabIndex = 7;
            // 
            // board02
            // 
            this.board02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board02.Location = new System.Drawing.Point(0, 300);
            this.board02.Margin = new System.Windows.Forms.Padding(0);
            this.board02.Name = "board02";
            this.board02.Size = new System.Drawing.Size(150, 150);
            this.board02.TabIndex = 6;
            // 
            // UTTBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.board22);
            this.Controls.Add(this.board12);
            this.Controls.Add(this.board02);
            this.Controls.Add(this.board21);
            this.Controls.Add(this.board11);
            this.Controls.Add(this.board01);
            this.Controls.Add(this.board20);
            this.Controls.Add(this.board10);
            this.Controls.Add(this.board00);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UTTBoard";
            this.Size = new System.Drawing.Size(450, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private UTTSmallBoard board00;
        private UTTSmallBoard board10;
        private UTTSmallBoard board20;
        private UTTSmallBoard board21;
        private UTTSmallBoard board11;
        private UTTSmallBoard board01;
        private UTTSmallBoard board22;
        private UTTSmallBoard board12;
        private UTTSmallBoard board02;
    }
}
