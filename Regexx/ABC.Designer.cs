namespace Regexx
{
    partial class ABC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ABResult = new System.Windows.Forms.Label();
            this.InputCheck = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.TextBox();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.CheckCLick = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ABResult);
            this.panel1.Controls.Add(this.InputCheck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Check);
            this.panel1.Controls.Add(this.txt_text);
            this.panel1.Controls.Add(this.CheckCLick);
            this.panel1.Location = new System.Drawing.Point(14, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 425);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Write your range of chars [a-z]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "שאלה 1";
            // 
            // ABResult
            // 
            this.ABResult.AutoSize = true;
            this.ABResult.Location = new System.Drawing.Point(331, 267);
            this.ABResult.Name = "ABResult";
            this.ABResult.Size = new System.Drawing.Size(49, 20);
            this.ABResult.TabIndex = 6;
            this.ABResult.Text = "Result";
            // 
            // InputCheck
            // 
            this.InputCheck.AutoSize = true;
            this.InputCheck.Location = new System.Drawing.Point(221, 106);
            this.InputCheck.Name = "InputCheck";
            this.InputCheck.Size = new System.Drawing.Size(86, 20);
            this.InputCheck.TabIndex = 5;
            this.InputCheck.Text = "Input Check";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Checker";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(311, 58);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(125, 27);
            this.Check.TabIndex = 3;
            this.Check.TextChanged += new System.EventHandler(this.Check_TextChanged);
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(311, 103);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(125, 27);
            this.txt_text.TabIndex = 2;
            // 
            // CheckCLick
            // 
            this.CheckCLick.Location = new System.Drawing.Point(311, 159);
            this.CheckCLick.Name = "CheckCLick";
            this.CheckCLick.Size = new System.Drawing.Size(94, 29);
            this.CheckCLick.TabIndex = 0;
            this.CheckCLick.Text = "Check";
            this.CheckCLick.UseVisualStyleBackColor = true;
            this.CheckCLick.Click += new System.EventHandler(this.CheckCLick_Click);
            // 
            // ABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ABC";
            this.Size = new System.Drawing.Size(810, 444);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ABResult;
        private System.Windows.Forms.Label InputCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Check;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Button CheckCLick;
    }
}
