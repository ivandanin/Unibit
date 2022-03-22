
namespace SDA_46337z_MyProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.avgBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ученик:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оценка:";
            // 
            // student
            // 
            this.student.Location = new System.Drawing.Point(23, 54);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(110, 23);
            this.student.TabIndex = 4;
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(163, 54);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(110, 23);
            this.grade.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(464, 225);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(279, 54);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(115, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Добави";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // avgBtn
            // 
            this.avgBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avgBtn.Location = new System.Drawing.Point(279, 87);
            this.avgBtn.Name = "avgBtn";
            this.avgBtn.Size = new System.Drawing.Size(208, 23);
            this.avgBtn.TabIndex = 8;
            this.avgBtn.Text = "Средна аритметична оценка";
            this.avgBtn.UseVisualStyleBackColor = true;
            this.avgBtn.Click += new System.EventHandler(this.avgBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 375);
            this.Controls.Add(this.avgBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.student);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button avgBtn;
    }
}

