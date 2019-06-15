/*
MIT License

Copyright (c) 2019 AlexTemnyakov

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace Password_Generator_with_GUI
{
    partial class PasswordGenerator
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
            this.countOfPasswordsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthOfPasswordUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.countOfPasswordsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthOfPasswordUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // countOfPasswordsUpDown
            // 
            this.countOfPasswordsUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.countOfPasswordsUpDown.Location = new System.Drawing.Point(58, 37);
            this.countOfPasswordsUpDown.Name = "countOfPasswordsUpDown";
            this.countOfPasswordsUpDown.Size = new System.Drawing.Size(57, 20);
            this.countOfPasswordsUpDown.TabIndex = 0;
            this.countOfPasswordsUpDown.ValueChanged += new System.EventHandler(this.CountOfPasswordsUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of passwords";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(104, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Length of a password";
            // 
            // lengthOfPasswordUpDown
            // 
            this.lengthOfPasswordUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.lengthOfPasswordUpDown.Location = new System.Drawing.Point(217, 38);
            this.lengthOfPasswordUpDown.Name = "lengthOfPasswordUpDown";
            this.lengthOfPasswordUpDown.Size = new System.Drawing.Size(57, 20);
            this.lengthOfPasswordUpDown.TabIndex = 4;
            this.lengthOfPasswordUpDown.ValueChanged += new System.EventHandler(this.LengthOfPasswordUpDown_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(58, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Only digits and letters";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 184);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lengthOfPasswordUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countOfPasswordsUpDown);
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.countOfPasswordsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthOfPasswordUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown countOfPasswordsUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lengthOfPasswordUpDown;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

