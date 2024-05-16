namespace Ehealth_DB
{
    partial class Login
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
            this.login_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.White;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_button.ForeColor = System.Drawing.Color.Red;
            this.login_button.Location = new System.Drawing.Point(319, 361);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(138, 48);
            this.login_button.TabIndex = 28;
            this.login_button.Text = "로 그 인";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("굴림", 12F);
            this.password_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.password_textbox.Location = new System.Drawing.Point(278, 252);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(230, 30);
            this.password_textbox.TabIndex = 27;
            this.password_textbox.Text = "비밀번호";
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // ID_textbox
            // 
            this.ID_textbox.Font = new System.Drawing.Font("굴림", 12F);
            this.ID_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.ID_textbox.Location = new System.Drawing.Point(278, 186);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(230, 30);
            this.ID_textbox.TabIndex = 25;
            this.ID_textbox.Text = "아이디";
            this.ID_textbox.TextChanged += new System.EventHandler(this.ID_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 48);
            this.label1.TabIndex = 23;
            this.label1.Text = "로그인";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.White;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.Location = new System.Drawing.Point(767, 7);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(25, 25);
            this.exit_button.TabIndex = 29;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Lgin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_button;
    }
}