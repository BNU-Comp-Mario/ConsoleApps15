
namespace RpsFromScratch
{
    partial class formRps
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRps));
            this.groupboxUserChoice = new System.Windows.Forms.GroupBox();
            this.pictureBoxUserChoice = new System.Windows.Forms.PictureBox();
            this.rdbScissors = new System.Windows.Forms.RadioButton();
            this.rdbPaper = new System.Windows.Forms.RadioButton();
            this.rdbRock = new System.Windows.Forms.RadioButton();
            this.groupboxComputerChoice = new System.Windows.Forms.GroupBox();
            this.pictureBoxComputerChoice = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupboxResult = new System.Windows.Forms.GroupBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.textBoxRounds = new System.Windows.Forms.TextBox();
            this.textBoxCounterComputer = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxCounterPlayer = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupboxUserChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserChoice)).BeginInit();
            this.groupboxComputerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputerChoice)).BeginInit();
            this.groupboxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxUserChoice
            // 
            this.groupboxUserChoice.Controls.Add(this.pictureBoxUserChoice);
            this.groupboxUserChoice.Controls.Add(this.rdbScissors);
            this.groupboxUserChoice.Controls.Add(this.rdbPaper);
            this.groupboxUserChoice.Controls.Add(this.rdbRock);
            this.groupboxUserChoice.Location = new System.Drawing.Point(12, 12);
            this.groupboxUserChoice.Name = "groupboxUserChoice";
            this.groupboxUserChoice.Size = new System.Drawing.Size(463, 574);
            this.groupboxUserChoice.TabIndex = 0;
            this.groupboxUserChoice.TabStop = false;
            this.groupboxUserChoice.Text = "User Choice";
            this.groupboxUserChoice.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBoxUserChoice
            // 
            this.pictureBoxUserChoice.Location = new System.Drawing.Point(0, 38);
            this.pictureBoxUserChoice.Name = "pictureBoxUserChoice";
            this.pictureBoxUserChoice.Size = new System.Drawing.Size(457, 291);
            this.pictureBoxUserChoice.TabIndex = 4;
            this.pictureBoxUserChoice.TabStop = false;
            // 
            // rdbScissors
            // 
            this.rdbScissors.AutoSize = true;
            this.rdbScissors.Location = new System.Drawing.Point(41, 500);
            this.rdbScissors.Name = "rdbScissors";
            this.rdbScissors.Size = new System.Drawing.Size(127, 36);
            this.rdbScissors.TabIndex = 3;
            this.rdbScissors.TabStop = true;
            this.rdbScissors.Text = "Scissors";
            this.rdbScissors.UseVisualStyleBackColor = true;
            this.rdbScissors.CheckedChanged += new System.EventHandler(this.rdbScissors_CheckedChanged);
            // 
            // rdbPaper
            // 
            this.rdbPaper.AutoSize = true;
            this.rdbPaper.Location = new System.Drawing.Point(41, 428);
            this.rdbPaper.Name = "rdbPaper";
            this.rdbPaper.Size = new System.Drawing.Size(104, 36);
            this.rdbPaper.TabIndex = 2;
            this.rdbPaper.TabStop = true;
            this.rdbPaper.Text = "Paper";
            this.rdbPaper.UseVisualStyleBackColor = true;
            this.rdbPaper.CheckedChanged += new System.EventHandler(this.rdbPaper_CheckedChanged);
            // 
            // rdbRock
            // 
            this.rdbRock.AutoSize = true;
            this.rdbRock.Location = new System.Drawing.Point(41, 356);
            this.rdbRock.Name = "rdbRock";
            this.rdbRock.Size = new System.Drawing.Size(95, 36);
            this.rdbRock.TabIndex = 1;
            this.rdbRock.TabStop = true;
            this.rdbRock.Text = "Rock";
            this.rdbRock.UseVisualStyleBackColor = true;
            this.rdbRock.CheckedChanged += new System.EventHandler(this.rdbRock_CheckedChanged);
            // 
            // groupboxComputerChoice
            // 
            this.groupboxComputerChoice.Controls.Add(this.pictureBoxComputerChoice);
            this.groupboxComputerChoice.Controls.Add(this.btnPlay);
            this.groupboxComputerChoice.Location = new System.Drawing.Point(481, 12);
            this.groupboxComputerChoice.Name = "groupboxComputerChoice";
            this.groupboxComputerChoice.Size = new System.Drawing.Size(463, 574);
            this.groupboxComputerChoice.TabIndex = 1;
            this.groupboxComputerChoice.TabStop = false;
            this.groupboxComputerChoice.Text = "Computer Choice";
            // 
            // pictureBoxComputerChoice
            // 
            this.pictureBoxComputerChoice.Location = new System.Drawing.Point(6, 38);
            this.pictureBoxComputerChoice.Name = "pictureBoxComputerChoice";
            this.pictureBoxComputerChoice.Size = new System.Drawing.Size(457, 433);
            this.pictureBoxComputerChoice.TabIndex = 1;
            this.pictureBoxComputerChoice.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(150, 500);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(150, 46);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // groupboxResult
            // 
            this.groupboxResult.Controls.Add(this.textBoxPlayerName);
            this.groupboxResult.Controls.Add(this.textBoxRounds);
            this.groupboxResult.Controls.Add(this.textBoxCounterComputer);
            this.groupboxResult.Controls.Add(this.textBox2);
            this.groupboxResult.Controls.Add(this.textBoxCounterPlayer);
            this.groupboxResult.Controls.Add(this.textBoxResult);
            this.groupboxResult.Location = new System.Drawing.Point(950, 12);
            this.groupboxResult.Name = "groupboxResult";
            this.groupboxResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupboxResult.Size = new System.Drawing.Size(463, 522);
            this.groupboxResult.TabIndex = 2;
            this.groupboxResult.TabStop = false;
            this.groupboxResult.Text = "RESULTS";
            this.groupboxResult.Enter += new System.EventHandler(this.groupboxResult_Enter);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Enabled = false;
            this.textBoxPlayerName.Location = new System.Drawing.Point(45, 71);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(374, 39);
            this.textBoxPlayerName.TabIndex = 6;
            this.textBoxPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRounds
            // 
            this.textBoxRounds.Enabled = false;
            this.textBoxRounds.Location = new System.Drawing.Point(45, 128);
            this.textBoxRounds.Name = "textBoxRounds";
            this.textBoxRounds.Size = new System.Drawing.Size(374, 39);
            this.textBoxRounds.TabIndex = 5;
            this.textBoxRounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCounterComputer
            // 
            this.textBoxCounterComputer.Enabled = false;
            this.textBoxCounterComputer.Location = new System.Drawing.Point(45, 356);
            this.textBoxCounterComputer.Name = "textBoxCounterComputer";
            this.textBoxCounterComputer.Size = new System.Drawing.Size(374, 39);
            this.textBoxCounterComputer.TabIndex = 4;
            this.textBoxCounterComputer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCounterComputer.TextChanged += new System.EventHandler(this.textBoxCounterComputer_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(45, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(143, 39);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "RESULTS";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxCounterPlayer
            // 
            this.textBoxCounterPlayer.Enabled = false;
            this.textBoxCounterPlayer.Location = new System.Drawing.Point(45, 301);
            this.textBoxCounterPlayer.Name = "textBoxCounterPlayer";
            this.textBoxCounterPlayer.Size = new System.Drawing.Size(374, 39);
            this.textBoxCounterPlayer.TabIndex = 1;
            this.textBoxCounterPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(219, 242);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(200, 39);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1263, 540);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(150, 46);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeveloper.Enabled = false;
            this.txtDeveloper.Location = new System.Drawing.Point(977, 547);
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(258, 32);
            this.txtDeveloper.TabIndex = 5;
            this.txtDeveloper.Text = "Developer: Jose Gomes";
            this.txtDeveloper.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Stone.ico");
            this.imageList1.Images.SetKeyName(1, "Paper.ico");
            this.imageList1.Images.SetKeyName(2, "Scissors.ico");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Stone.ico");
            this.imageList2.Images.SetKeyName(1, "Paper.ico");
            this.imageList2.Images.SetKeyName(2, "Scissors.ico");
            // 
            // formRps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1429, 610);
            this.Controls.Add(this.txtDeveloper);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.groupboxResult);
            this.Controls.Add(this.groupboxComputerChoice);
            this.Controls.Add(this.groupboxUserChoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formRps";
            this.Text = "RPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupboxUserChoice.ResumeLayout(false);
            this.groupboxUserChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserChoice)).EndInit();
            this.groupboxComputerChoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputerChoice)).EndInit();
            this.groupboxResult.ResumeLayout(false);
            this.groupboxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxUserChoice;
        private System.Windows.Forms.GroupBox groupboxComputerChoice;
        private System.Windows.Forms.GroupBox groupboxResult;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.RadioButton rdbScissors;
        private System.Windows.Forms.RadioButton rdbPaper;
        private System.Windows.Forms.RadioButton rdbRock;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxUserChoice;
        private System.Windows.Forms.PictureBox pictureBoxComputerChoice;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox textBoxCounterComputer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxCounterPlayer;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.TextBox textBoxRounds;
    }
}

