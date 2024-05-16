namespace Ehealth_DB
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.signup_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.SystemColors.Control;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.signup_button.ForeColor = System.Drawing.Color.Red;
            this.signup_button.Location = new System.Drawing.Point(425, 357);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(161, 50);
            this.signup_button.TabIndex = 13;
            this.signup_button.Text = "회원 가입";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.Control;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.login_button.ForeColor = System.Drawing.Color.Red;
            this.login_button.Location = new System.Drawing.Point(209, 357);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(161, 50);
            this.login_button.TabIndex = 12;
            this.login_button.Text = "로그인";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(74, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 3);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(453, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 55);
            this.label3.TabIndex = 11;
            this.label3.Text = "System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(428, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 55);
            this.label2.TabIndex = 10;
            this.label2.Text = "Database";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(434, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "E-Health";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.White;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.Location = new System.Drawing.Point(766, 7);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(25, 25);
            this.exit_button.TabIndex = 15;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

