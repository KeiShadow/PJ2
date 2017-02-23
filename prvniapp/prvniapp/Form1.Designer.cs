namespace prvniapp
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
            this.list = new System.Windows.Forms.ListBox();
            this.text = new System.Windows.Forms.TextBox();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(216, 95);
            this.list.TabIndex = 0;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(128, 113);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(100, 20);
            this.text.TabIndex = 1;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(12, 153);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(35, 23);
            this.but1.TabIndex = 2;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(53, 153);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(35, 23);
            this.but2.TabIndex = 3;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(94, 153);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(35, 23);
            this.but3.TabIndex = 4;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // but4
            // 
            this.but4.Location = new System.Drawing.Point(12, 182);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(35, 23);
            this.but4.TabIndex = 5;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // but5
            // 
            this.but5.Location = new System.Drawing.Point(53, 182);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(35, 23);
            this.but5.TabIndex = 6;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // but6
            // 
            this.but6.Location = new System.Drawing.Point(94, 182);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(35, 23);
            this.but6.TabIndex = 7;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.but6_Click);
            // 
            // but7
            // 
            this.but7.Location = new System.Drawing.Point(12, 211);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(35, 23);
            this.but7.TabIndex = 8;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but7_Click);
            // 
            // but8
            // 
            this.but8.Location = new System.Drawing.Point(53, 211);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(35, 23);
            this.but8.TabIndex = 9;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but8_Click);
            // 
            // but9
            // 
            this.but9.Location = new System.Drawing.Point(94, 211);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(35, 23);
            this.but9.TabIndex = 10;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but9_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(152, 153);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 23);
            this.sum.TabIndex = 11;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(152, 182);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(152, 211);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(35, 23);
            this.ok.TabIndex = 13;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(193, 211);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(35, 23);
            this.result.TabIndex = 14;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 246);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.list);
            this.Name = "Form1";
            this.Text = "Kalkulacka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button result;
    }
}

