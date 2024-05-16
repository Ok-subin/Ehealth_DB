
namespace Ehealth_DB
{
    partial class patient1
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
            this.button0 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.White;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button0.Location = new System.Drawing.Point(767, 7);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(25, 25);
            this.button0.TabIndex = 30;
            this.button0.Text = "X";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(59, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 32);
            this.label2.TabIndex = 63;
            this.label2.Text = "1. 진료과와 진료 일시를 선택하세요 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 48);
            this.label1.TabIndex = 52;
            this.label1.Text = "진료 예약";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(66, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 3);
            this.panel1.TabIndex = 64;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(129, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 44);
            this.button5.TabIndex = 69;
            this.button5.Text = "5. 이비인후과";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(129, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 44);
            this.button3.TabIndex = 68;
            this.button3.Text = "3. 치과";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(129, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 44);
            this.button2.TabIndex = 67;
            this.button2.Text = "2. 일반 외과";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(129, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 44);
            this.button4.TabIndex = 66;
            this.button4.Text = "4. 안과";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(128, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 44);
            this.button1.TabIndex = 65;
            this.button1.Text = "1. 내과";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(410, 187);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 70;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(468, 416);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 44);
            this.button6.TabIndex = 85;
            this.button6.Text = "선택";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // patient1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "patient1";
            this.Text = "patient1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button6;
    }
}