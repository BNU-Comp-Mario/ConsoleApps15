
namespace RpsFromScratch
{
    partial class WelcomeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxInstructions = new System.Windows.Forms.PictureBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.buttonPlayGame = new System.Windows.Forms.Button();
            this.numericUpDownRounds = new System.Windows.Forms.NumericUpDown();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxHighScores = new System.Windows.Forms.RichTextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Rock Paper Scissors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxInstructions
            // 
            this.pictureBoxInstructions.BackgroundImage = global::RpsFromScratch.Properties.Resources.sps1;
            this.pictureBoxInstructions.Location = new System.Drawing.Point(854, 119);
            this.pictureBoxInstructions.Name = "pictureBoxInstructions";
            this.pictureBoxInstructions.Size = new System.Drawing.Size(520, 408);
            this.pictureBoxInstructions.TabIndex = 1;
            this.pictureBoxInstructions.TabStop = false;
            this.pictureBoxInstructions.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(12, 119);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(381, 39);
            this.textBoxPlayerName.TabIndex = 2;
            // 
            // buttonPlayGame
            // 
            this.buttonPlayGame.Location = new System.Drawing.Point(426, 119);
            this.buttonPlayGame.Name = "buttonPlayGame";
            this.buttonPlayGame.Size = new System.Drawing.Size(150, 131);
            this.buttonPlayGame.TabIndex = 3;
            this.buttonPlayGame.Text = "Play";
            this.buttonPlayGame.UseVisualStyleBackColor = true;
            this.buttonPlayGame.Click += new System.EventHandler(this.buttonPlayGame_Click);
            // 
            // numericUpDownRounds
            // 
            this.numericUpDownRounds.Location = new System.Drawing.Point(12, 211);
            this.numericUpDownRounds.Name = "numericUpDownRounds";
            this.numericUpDownRounds.Size = new System.Drawing.Size(381, 39);
            this.numericUpDownRounds.TabIndex = 5;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(582, 119);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(150, 131);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Highscores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rounds";
            // 
            // richTextBoxHighScores
            // 
            this.richTextBoxHighScores.Location = new System.Drawing.Point(12, 331);
            this.richTextBoxHighScores.Name = "richTextBoxHighScores";
            this.richTextBoxHighScores.Size = new System.Drawing.Size(720, 196);
            this.richTextBoxHighScores.TabIndex = 11;
            this.richTextBoxHighScores.Text = "";
            this.richTextBoxHighScores.TextChanged += new System.EventHandler(this.richTextBoxHighScores_TextChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 542);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(333, 46);
            this.buttonRefresh.TabIndex = 13;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(520, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(399, 542);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(333, 46);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // WelcomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1429, 610);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.richTextBoxHighScores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.numericUpDownRounds);
            this.Controls.Add(this.buttonPlayGame);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.pictureBoxInstructions);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeMenu";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxInstructions;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Button buttonPlayGame;
        private System.Windows.Forms.NumericUpDown numericUpDownRounds;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxHighScores;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClear;
    }
}