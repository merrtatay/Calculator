namespace Calculators
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.commaBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.multiBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.deletionBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.numberBoxTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(118, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(26, 205);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(72, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(118, 205);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(72, 251);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // commaBtn
            // 
            this.commaBtn.Location = new System.Drawing.Point(26, 251);
            this.commaBtn.Name = "commaBtn";
            this.commaBtn.Size = new System.Drawing.Size(40, 40);
            this.commaBtn.TabIndex = 10;
            this.commaBtn.Text = ",";
            this.commaBtn.UseVisualStyleBackColor = true;
            this.commaBtn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(164, 205);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(40, 40);
            this.minusBtn.TabIndex = 11;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.OperationBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(164, 251);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(40, 40);
            this.plusBtn.TabIndex = 12;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.OperationBtn_Click);
            // 
            // multiBtn
            // 
            this.multiBtn.Location = new System.Drawing.Point(164, 159);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(40, 40);
            this.multiBtn.TabIndex = 13;
            this.multiBtn.Text = "*";
            this.multiBtn.UseVisualStyleBackColor = true;
            this.multiBtn.Click += new System.EventHandler(this.OperationBtn_Click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.Location = new System.Drawing.Point(164, 113);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(40, 40);
            this.divisionBtn.TabIndex = 14;
            this.divisionBtn.Text = "/";
            this.divisionBtn.UseVisualStyleBackColor = true;
            this.divisionBtn.Click += new System.EventHandler(this.OperationBtn_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(118, 251);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(40, 40);
            this.button16.TabIndex = 15;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.EqualBtn_Click);
            // 
            // deletionBtn
            // 
            this.deletionBtn.Location = new System.Drawing.Point(26, 63);
            this.deletionBtn.Name = "deletionBtn";
            this.deletionBtn.Size = new System.Drawing.Size(86, 44);
            this.deletionBtn.TabIndex = 16;
            this.deletionBtn.Text = "DELETE";
            this.deletionBtn.UseVisualStyleBackColor = true;
            this.deletionBtn.Click += new System.EventHandler(this.DeletionBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(118, 63);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(86, 44);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // numberBoxTxt
            // 
            this.numberBoxTxt.Location = new System.Drawing.Point(26, 25);
            this.numberBoxTxt.Name = "numberBoxTxt";
            this.numberBoxTxt.Size = new System.Drawing.Size(178, 22);
            this.numberBoxTxt.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 368);
            this.Controls.Add(this.numberBoxTxt);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deletionBtn);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.divisionBtn);
            this.Controls.Add(this.multiBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.commaBtn);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button commaBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button multiBtn;
        private System.Windows.Forms.Button divisionBtn;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button deletionBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox numberBoxTxt;
    }
}

