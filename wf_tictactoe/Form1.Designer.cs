namespace wf_tictactoe
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.xWin = new System.Windows.Forms.Label();
            this.draw = new System.Windows.Forms.Label();
            this.oWin = new System.Windows.Forms.Label();
            this.xWinCount = new System.Windows.Forms.Label();
            this.drawCount = new System.Windows.Forms.Label();
            this.oWinCount = new System.Windows.Forms.Label();
            this.resetCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetCountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // a1
            // 
            this.a1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(19, 52);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(150, 150);
            this.a1.TabIndex = 1;
            this.a1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.button_click);
            this.a1.MouseEnter += new System.EventHandler(this.button_enter);
            this.a1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(175, 52);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(150, 150);
            this.a2.TabIndex = 2;
            this.a2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.button_click);
            this.a2.MouseEnter += new System.EventHandler(this.button_enter);
            this.a2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(331, 52);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(150, 150);
            this.a3.TabIndex = 3;
            this.a3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.button_click);
            this.a3.MouseEnter += new System.EventHandler(this.button_enter);
            this.a3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(19, 208);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(150, 150);
            this.b1.TabIndex = 4;
            this.b1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_click);
            this.b1.MouseEnter += new System.EventHandler(this.button_enter);
            this.b1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(175, 208);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(150, 150);
            this.b2.TabIndex = 5;
            this.b2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_click);
            this.b2.MouseEnter += new System.EventHandler(this.button_enter);
            this.b2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(331, 208);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(150, 150);
            this.b3.TabIndex = 6;
            this.b3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_click);
            this.b3.MouseEnter += new System.EventHandler(this.button_enter);
            this.b3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(19, 364);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(150, 150);
            this.c1.TabIndex = 7;
            this.c1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.button_click);
            this.c1.MouseEnter += new System.EventHandler(this.button_enter);
            this.c1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(175, 364);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(150, 150);
            this.c2.TabIndex = 8;
            this.c2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.button_click);
            this.c2.MouseEnter += new System.EventHandler(this.button_enter);
            this.c2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(331, 364);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(150, 150);
            this.c3.TabIndex = 9;
            this.c3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.button_click);
            this.c3.MouseEnter += new System.EventHandler(this.button_enter);
            this.c3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // xWin
            // 
            this.xWin.AutoSize = true;
            this.xWin.BackColor = System.Drawing.Color.Black;
            this.xWin.Font = new System.Drawing.Font("Calibri", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWin.ForeColor = System.Drawing.Color.Crimson;
            this.xWin.Location = new System.Drawing.Point(16, 517);
            this.xWin.Name = "xWin";
            this.xWin.Size = new System.Drawing.Size(153, 33);
            this.xWin.TabIndex = 10;
            this.xWin.Text = "X Win Count";
            this.xWin.Click += new System.EventHandler(this.label1_Click);
            // 
            // draw
            // 
            this.draw.AutoSize = true;
            this.draw.BackColor = System.Drawing.Color.Black;
            this.draw.Font = new System.Drawing.Font("Calibri", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw.ForeColor = System.Drawing.Color.Crimson;
            this.draw.Location = new System.Drawing.Point(179, 517);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(146, 33);
            this.draw.TabIndex = 11;
            this.draw.Text = "Draw Count";
            this.draw.Click += new System.EventHandler(this.label2_Click);
            // 
            // oWin
            // 
            this.oWin.AutoSize = true;
            this.oWin.BackColor = System.Drawing.Color.Black;
            this.oWin.Font = new System.Drawing.Font("Calibri", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oWin.ForeColor = System.Drawing.Color.Crimson;
            this.oWin.Location = new System.Drawing.Point(335, 517);
            this.oWin.Name = "oWin";
            this.oWin.Size = new System.Drawing.Size(156, 33);
            this.oWin.TabIndex = 12;
            this.oWin.Text = "O Win Count";
            this.oWin.Click += new System.EventHandler(this.label3_Click);
            // 
            // xWinCount
            // 
            this.xWinCount.AutoSize = true;
            this.xWinCount.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWinCount.ForeColor = System.Drawing.Color.Crimson;
            this.xWinCount.Location = new System.Drawing.Point(74, 561);
            this.xWinCount.Name = "xWinCount";
            this.xWinCount.Size = new System.Drawing.Size(29, 33);
            this.xWinCount.TabIndex = 13;
            this.xWinCount.Text = "0";
            // 
            // drawCount
            // 
            this.drawCount.AutoSize = true;
            this.drawCount.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawCount.ForeColor = System.Drawing.Color.Crimson;
            this.drawCount.Location = new System.Drawing.Point(229, 561);
            this.drawCount.Name = "drawCount";
            this.drawCount.Size = new System.Drawing.Size(29, 33);
            this.drawCount.TabIndex = 14;
            this.drawCount.Text = "0";
            // 
            // oWinCount
            // 
            this.oWinCount.AutoSize = true;
            this.oWinCount.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oWinCount.ForeColor = System.Drawing.Color.Crimson;
            this.oWinCount.Location = new System.Drawing.Point(391, 561);
            this.oWinCount.Name = "oWinCount";
            this.oWinCount.Size = new System.Drawing.Size(29, 33);
            this.oWinCount.TabIndex = 15;
            this.oWinCount.Text = "0";
            // 
            // resetCountsToolStripMenuItem
            // 
            this.resetCountsToolStripMenuItem.Name = "resetCountsToolStripMenuItem";
            this.resetCountsToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.resetCountsToolStripMenuItem.Text = "Reset Counts";
            this.resetCountsToolStripMenuItem.Click += new System.EventHandler(this.resetCountsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(499, 604);
            this.Controls.Add(this.oWinCount);
            this.Controls.Add(this.drawCount);
            this.Controls.Add(this.xWinCount);
            this.Controls.Add(this.oWin);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.xWin);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Label xWin;
        private System.Windows.Forms.Label draw;
        private System.Windows.Forms.Label oWin;
        private System.Windows.Forms.Label xWinCount;
        private System.Windows.Forms.Label drawCount;
        private System.Windows.Forms.Label oWinCount;
        private System.Windows.Forms.ToolStripMenuItem resetCountsToolStripMenuItem;
    }
}

