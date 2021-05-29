
namespace PAV_Tictactoe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OneScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TwoScore = new System.Windows.Forms.TextBox();
            this.playerTurn = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.button_R1C2 = new System.Windows.Forms.Button();
            this.button_R1C3 = new System.Windows.Forms.Button();
            this.button_R2C1 = new System.Windows.Forms.Button();
            this.button_R2C2 = new System.Windows.Forms.Button();
            this.button_R2C3 = new System.Windows.Forms.Button();
            this.button_R3C1 = new System.Windows.Forms.Button();
            this.button_R3C2 = new System.Windows.Forms.Button();
            this.button_R3C3 = new System.Windows.Forms.Button();
            this.button_R1C1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // OneScore
            // 
            this.OneScore.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OneScore.Location = new System.Drawing.Point(8, 31);
            this.OneScore.Name = "OneScore";
            this.OneScore.Size = new System.Drawing.Size(105, 27);
            this.OneScore.TabIndex = 3;
            this.OneScore.Text = "Player one: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TwoScore
            // 
            this.TwoScore.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TwoScore.Location = new System.Drawing.Point(8, 64);
            this.TwoScore.Name = "TwoScore";
            this.TwoScore.Size = new System.Drawing.Size(105, 27);
            this.TwoScore.TabIndex = 5;
            this.TwoScore.Text = "Player two: 0";
            // 
            // playerTurn
            // 
            this.playerTurn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.playerTurn.Location = new System.Drawing.Point(159, 68);
            this.playerTurn.Name = "playerTurn";
            this.playerTurn.Size = new System.Drawing.Size(148, 27);
            this.playerTurn.TabIndex = 6;
            this.playerTurn.Text = "Player one\'s turn";
            this.playerTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset.Location = new System.Drawing.Point(191, 38);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(83, 26);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // button_R1C2
            // 
            this.button_R1C2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_R1C2.Location = new System.Drawing.Point(118, 3);
            this.button_R1C2.Name = "button_R1C2";
            this.button_R1C2.Size = new System.Drawing.Size(109, 86);
            this.button_R1C2.TabIndex = 1;
            this.button_R1C2.UseVisualStyleBackColor = true;
            this.button_R1C2.Click += new System.EventHandler(this.TicTacButton_Click);
            // 
            // button_R1C3
            // 
            this.button_R1C3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_R1C3.Location = new System.Drawing.Point(233, 3);
            this.button_R1C3.Name = "button_R1C3";
            this.button_R1C3.Size = new System.Drawing.Size(110, 86);
            this.button_R1C3.TabIndex = 2;
            this.button_R1C3.UseVisualStyleBackColor = true;
            this.button_R1C3.Click += new System.EventHandler(this.TicTacButton_Click);
            // 
            // button_R2C1
            // 
            this.button_R2C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_R2C1.Location = new System.Drawing.Point(3, 95);
            this.button_R2C1.Name = "button_R2C1";
            this.button_R2C1.Size = new System.Drawing.Size(109, 86);
            this.button_R2C1.TabIndex = 3;
            this.button_R2C1.UseVisualStyleBackColor = true;
            this.button_R2C1.Click += new System.EventHandler(this.TicTacButton_Click);
            // 
            // button_R2C2
            // 
            this.button_R2C2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_R2C2.Location = new System.Drawing.Point(118, 95);
            this.button_R2C2.Name = "button_R2C2";
            this.button_R2C2.Size = new System.Drawing.Size(109, 86);
            this.button_R2C2.TabIndex = 4;
            this.button_R2C2.UseVisualStyleBackColor = true;
            this.button_R2C2.Click += new System.EventHandler(this.TicTacButton_Click);
            // 
            // button_R2C3
            // 
            this.button_R2C3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_R2C3.Location = new System.Drawing.Point(233, 95);
            this.button_R2C3.Name = "button_R2C3";
            this.button_R2C3.Size = new System.Drawing.Size(110, 86);
            this.button_R2C3.TabIndex = 5;
            this.button_R2C3.UseVisualStyleBackColor = true;
            this.button_R2C3.Click += new System.EventHandler(this.TicTacButton_Click);
            // 
            // button_R3C1
            // 
            this.button_R3C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_R3C1.Location = new System.Drawing.Point(3, 187);
            this.button_R3C1.Name = "button_R3C1";
            this.button_R3C1.Size = new System.Drawing.Size(109, 88);
            this.button_R3C1.TabIndex = 6;
            this.button_R3C1.UseVisualStyleBackColor = true;
            this.button_R3C1.Click += new System.EventHandler(this.TicTacButton_Click);
            // 
            // button_R3C2
            // 
            this.button_R3C2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_R3C2.Location = new System.Drawing.Point(118, 187);
            this.button_R3C2.Name = "button_R3C2";
            this.button_R3C2.Size = new System.Drawing.Size(109, 88);
            this.button_R3C2.TabIndex = 7;
            this.button_R3C2.UseVisualStyleBackColor = true;
            this.button_R3C2.Click += new System.EventHandler(this.TicTacButton_Click);
            // 
            // button_R3C3
            // 
            this.button_R3C3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_R3C3.Location = new System.Drawing.Point(233, 187);
            this.button_R3C3.Name = "button_R3C3";
            this.button_R3C3.Size = new System.Drawing.Size(110, 88);
            this.button_R3C3.TabIndex = 8;
            this.button_R3C3.UseVisualStyleBackColor = true;
            this.button_R3C3.Click += new System.EventHandler(this.TicTacButton_Click);
            // 
            // button_R1C1
            // 
            this.button_R1C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_R1C1.Location = new System.Drawing.Point(3, 3);
            this.button_R1C1.Name = "button_R1C1";
            this.button_R1C1.Size = new System.Drawing.Size(109, 86);
            this.button_R1C1.TabIndex = 8;
            this.button_R1C1.TabStop = false;
            this.button_R1C1.UseVisualStyleBackColor = true;
            this.button_R1C1.Click += new System.EventHandler(this.TicTacButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button_R1C1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_R3C3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_R3C2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_R3C1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_R2C3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_R2C2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_R2C1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_R1C3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_R1C2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 278);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 380);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.playerTurn);
            this.Controls.Add(this.TwoScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OneScore);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Tic-tac-toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OneScore;
        private System.Windows.Forms.TextBox TwoScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerTurn;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button button_R1C2;
        private System.Windows.Forms.Button button_R1C3;
        private System.Windows.Forms.Button button_R2C1;
        private System.Windows.Forms.Button button_R2C2;
        private System.Windows.Forms.Button button_R2C3;
        private System.Windows.Forms.Button button_R3C1;
        private System.Windows.Forms.Button button_R3C2;
        private System.Windows.Forms.Button button_R3C3;
        private System.Windows.Forms.Button button_R1C1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

