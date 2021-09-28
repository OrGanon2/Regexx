namespace Regexx
{
    partial class FirstName_LastName
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
            this.FullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameResult = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(267, 199);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(242, 27);
            this.FullName.TabIndex = 0;
            this.FullName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "שאלה 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Name";
            // 
            // NameResult
            // 
            this.NameResult.AutoSize = true;
            this.NameResult.Location = new System.Drawing.Point(362, 335);
            this.NameResult.Name = "NameResult";
            this.NameResult.Size = new System.Drawing.Size(49, 20);
            this.NameResult.TabIndex = 5;
            this.NameResult.Text = "Result";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(337, 232);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(94, 29);
            this.Check.TabIndex = 6;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // FirstName_LastName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Check);
            this.Controls.Add(this.NameResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullName);
            this.Name = "FirstName_LastName";
            this.Size = new System.Drawing.Size(775, 508);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameResult;
        private System.Windows.Forms.Button Check;
    }
}
