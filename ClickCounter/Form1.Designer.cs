namespace ClickCounter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.Clicks = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRealTime = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.lblNumBestScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(279, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Me !!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCounter.Location = new System.Drawing.Point(42, 38);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(67, 13);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "ClickCounter";
            // 
            // Clicks
            // 
            this.Clicks.AutoSize = true;
            this.Clicks.BackColor = System.Drawing.Color.Transparent;
            this.Clicks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Clicks.Location = new System.Drawing.Point(115, 38);
            this.Clicks.Name = "Clicks";
            this.Clicks.Size = new System.Drawing.Size(13, 13);
            this.Clicks.TabIndex = 2;
            this.Clicks.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(309, 313);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(177, 68);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "RESET !";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(42, 69);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            // 
            // lblRealTime
            // 
            this.lblRealTime.AutoSize = true;
            this.lblRealTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRealTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRealTime.Location = new System.Drawing.Point(78, 69);
            this.lblRealTime.Name = "lblRealTime";
            this.lblRealTime.Size = new System.Drawing.Size(13, 13);
            this.lblRealTime.TabIndex = 5;
            this.lblRealTime.Text = "0";
            this.lblRealTime.Click += new System.EventHandler(this.lblRealTime_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.BackColor = System.Drawing.Color.Transparent;
            this.lblFinish.Enabled = false;
            this.lblFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.Color.Lime;
            this.lblFinish.Location = new System.Drawing.Point(327, 51);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(159, 31);
            this.lblFinish.TabIndex = 6;
            this.lblFinish.Text = "Time Out !!";
            this.lblFinish.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.BackColor = System.Drawing.Color.Transparent;
            this.lblBestScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBestScore.Location = new System.Drawing.Point(42, 106);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(56, 13);
            this.lblBestScore.TabIndex = 7;
            this.lblBestScore.Text = "BestScore";
            // 
            // lblNumBestScore
            // 
            this.lblNumBestScore.AutoSize = true;
            this.lblNumBestScore.BackColor = System.Drawing.Color.Transparent;
            this.lblNumBestScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumBestScore.Location = new System.Drawing.Point(104, 106);
            this.lblNumBestScore.Name = "lblNumBestScore";
            this.lblNumBestScore.Size = new System.Drawing.Size(13, 13);
            this.lblNumBestScore.TabIndex = 8;
            this.lblNumBestScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumBestScore);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblRealTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.Clicks);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Click Counter";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label Clicks;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRealTime;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label lblNumBestScore;
    }
}

