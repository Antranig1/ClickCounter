namespace ClickCounter
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnShowUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowBestScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit new user";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblname.Location = new System.Drawing.Point(44, 70);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(33, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "name";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAll.Location = new System.Drawing.Point(560, 54);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(181, 45);
            this.btnDeleteAll.TabIndex = 3;
            this.btnDeleteAll.Text = "Delete All Users";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteUser.Location = new System.Drawing.Point(316, 54);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(148, 45);
            this.DeleteUser.TabIndex = 4;
            this.DeleteUser.Text = "Delete this user";
            this.DeleteUser.UseVisualStyleBackColor = false;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(47, 142);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(197, 55);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShowUsers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowUsers.Location = new System.Drawing.Point(560, 132);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(181, 45);
            this.btnShowUsers.TabIndex = 6;
            this.btnShowUsers.Text = "Show All Users";
            this.btnShowUsers.UseVisualStyleBackColor = false;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnShowUser
            // 
            this.btnShowUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShowUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowUser.Location = new System.Drawing.Point(316, 132);
            this.btnShowUser.Name = "btnShowUser";
            this.btnShowUser.Size = new System.Drawing.Size(148, 45);
            this.btnShowUser.TabIndex = 7;
            this.btnShowUser.Text = "Show User";
            this.btnShowUser.UseVisualStyleBackColor = false;
            this.btnShowUser.Click += new System.EventHandler(this.btnShowUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(482, 156);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnShowBestScores
            // 
            this.btnShowBestScores.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShowBestScores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowBestScores.Location = new System.Drawing.Point(316, 204);
            this.btnShowBestScores.Name = "btnShowBestScores";
            this.btnShowBestScores.Size = new System.Drawing.Size(148, 45);
            this.btnShowBestScores.TabIndex = 9;
            this.btnShowBestScores.Text = "Show Best Scores";
            this.btnShowBestScores.UseVisualStyleBackColor = false;
            this.btnShowBestScores.Click += new System.EventHandler(this.btnShowBestScores_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowBestScores);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowUser);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Click Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnShowUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowBestScores;
    }
}