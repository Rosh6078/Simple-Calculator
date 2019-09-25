namespace calc
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
            this.txt3 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.quot = new System.Windows.Forms.Button();
            this.modu = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.SystemColors.Window;
            this.txt3.Enabled = false;
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(530, 27);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(175, 104);
            this.txt3.TabIndex = 2;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt3.TextChanged += new System.EventHandler(this.Txt3_TextChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.Window;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(186, 315);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(84, 72);
            this.add.TabIndex = 6;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.SystemColors.Window;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(302, 315);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(84, 72);
            this.min.TabIndex = 7;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.Min_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.Window;
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(186, 215);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(84, 72);
            this.mul.TabIndex = 8;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // quot
            // 
            this.quot.BackColor = System.Drawing.SystemColors.Window;
            this.quot.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quot.Location = new System.Drawing.Point(302, 215);
            this.quot.Name = "quot";
            this.quot.Size = new System.Drawing.Size(84, 72);
            this.quot.TabIndex = 9;
            this.quot.Text = "/";
            this.quot.UseVisualStyleBackColor = false;
            this.quot.Click += new System.EventHandler(this.Quot_Click);
            // 
            // modu
            // 
            this.modu.BackColor = System.Drawing.SystemColors.Window;
            this.modu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modu.Location = new System.Drawing.Point(413, 267);
            this.modu.Name = "modu";
            this.modu.Size = new System.Drawing.Size(84, 72);
            this.modu.TabIndex = 10;
            this.modu.Text = "%";
            this.modu.UseVisualStyleBackColor = false;
            this.modu.Click += new System.EventHandler(this.Modu_Click);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.Window;
            this.txt2.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F, System.Drawing.FontStyle.Bold);
            this.txt2.Location = new System.Drawing.Point(38, 81);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(413, 50);
            this.txt2.TabIndex = 11;
            this.txt2.TextChanged += new System.EventHandler(this.Txt2_TextChanged);
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt2_KeyPress);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.Window;
            this.txt1.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(38, 27);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(413, 48);
            this.txt1.TabIndex = 12;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt1_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(582, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 172);
            this.button1.TabIndex = 13;
            this.button1.Text = "CLR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.modu);
            this.Controls.Add(this.quot);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.min);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txt3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button quot;
        private System.Windows.Forms.Button modu;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

