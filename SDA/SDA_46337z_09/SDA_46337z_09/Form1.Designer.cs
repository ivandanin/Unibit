
namespace SDA_46337z_09
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbDeleteVertex = new System.Windows.Forms.ComboBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.btnDeleteEdge = new System.Windows.Forms.Button();
            this.btnDeleteVertex = new System.Windows.Forms.Button();
            this.btnTS = new System.Windows.Forms.Button();
            this.btnShowMatrix = new System.Windows.Forms.Button();
            this.btnClearGraph = new System.Windows.Forms.Button();
            this.btnCreateGraph1 = new System.Windows.Forms.Button();
            this.btnCreateGraph4 = new System.Windows.Forms.Button();
            this.btnCreateGraph3 = new System.Windows.Forms.Button();
            this.btnCreateGraph2 = new System.Windows.Forms.Button();
            this.btnCreateGraph5 = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnMST = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.tbLabelVertex = new System.Windows.Forms.TextBox();
            this.listVertex2 = new System.Windows.Forms.ListBox();
            this.listVertex1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Въвеждане на връх";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Име на върха";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Изтриване на връх";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Име на върха";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ребро между два върха";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Матрица на съседство";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Краен връх";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Начален връх";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(350, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 239);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // cbDeleteVertex
            // 
            this.cbDeleteVertex.FormattingEnabled = true;
            this.cbDeleteVertex.Location = new System.Drawing.Point(344, 54);
            this.cbDeleteVertex.Name = "cbDeleteVertex";
            this.cbDeleteVertex.Size = new System.Drawing.Size(253, 23);
            this.cbDeleteVertex.TabIndex = 14;
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(153, 377);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(112, 25);
            this.btnAddEdge.TabIndex = 16;
            this.btnAddEdge.Text = "Добави ребро";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // btnDeleteEdge
            // 
            this.btnDeleteEdge.Location = new System.Drawing.Point(153, 408);
            this.btnDeleteEdge.Name = "btnDeleteEdge";
            this.btnDeleteEdge.Size = new System.Drawing.Size(112, 25);
            this.btnDeleteEdge.TabIndex = 17;
            this.btnDeleteEdge.Text = "Изтрий ребро";
            this.btnDeleteEdge.UseVisualStyleBackColor = true;
            this.btnDeleteEdge.Click += new System.EventHandler(this.btnDeleteEdge_Click);
            // 
            // btnDeleteVertex
            // 
            this.btnDeleteVertex.Location = new System.Drawing.Point(485, 97);
            this.btnDeleteVertex.Name = "btnDeleteVertex";
            this.btnDeleteVertex.Size = new System.Drawing.Size(112, 25);
            this.btnDeleteVertex.TabIndex = 18;
            this.btnDeleteVertex.Text = "Изтрий връх";
            this.btnDeleteVertex.UseVisualStyleBackColor = true;
            this.btnDeleteVertex.Click += new System.EventHandler(this.btnDeleteVertex_Click);
            // 
            // btnTS
            // 
            this.btnTS.Location = new System.Drawing.Point(700, 250);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(112, 25);
            this.btnTS.TabIndex = 27;
            this.btnTS.Text = "TS";
            this.btnTS.UseVisualStyleBackColor = true;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // btnShowMatrix
            // 
            this.btnShowMatrix.Location = new System.Drawing.Point(700, 219);
            this.btnShowMatrix.Name = "btnShowMatrix";
            this.btnShowMatrix.Size = new System.Drawing.Size(112, 25);
            this.btnShowMatrix.TabIndex = 28;
            this.btnShowMatrix.Text = "Покажи матрица";
            this.btnShowMatrix.UseVisualStyleBackColor = true;
            this.btnShowMatrix.Click += new System.EventHandler(this.btnShowMatrix_Click);
            // 
            // btnClearGraph
            // 
            this.btnClearGraph.Location = new System.Drawing.Point(700, 188);
            this.btnClearGraph.Name = "btnClearGraph";
            this.btnClearGraph.Size = new System.Drawing.Size(112, 25);
            this.btnClearGraph.TabIndex = 29;
            this.btnClearGraph.Text = "Изтрий граф";
            this.btnClearGraph.UseVisualStyleBackColor = true;
            this.btnClearGraph.Click += new System.EventHandler(this.btnClearGraph_Click);
            // 
            // btnCreateGraph1
            // 
            this.btnCreateGraph1.Location = new System.Drawing.Point(700, 31);
            this.btnCreateGraph1.Name = "btnCreateGraph1";
            this.btnCreateGraph1.Size = new System.Drawing.Size(112, 25);
            this.btnCreateGraph1.TabIndex = 30;
            this.btnCreateGraph1.Text = "Създай граф 1";
            this.btnCreateGraph1.UseVisualStyleBackColor = true;
            this.btnCreateGraph1.Click += new System.EventHandler(this.btnCreateGraph1_Click);
            // 
            // btnCreateGraph4
            // 
            this.btnCreateGraph4.Location = new System.Drawing.Point(700, 124);
            this.btnCreateGraph4.Name = "btnCreateGraph4";
            this.btnCreateGraph4.Size = new System.Drawing.Size(112, 25);
            this.btnCreateGraph4.TabIndex = 31;
            this.btnCreateGraph4.Text = "Създай граф 4";
            this.btnCreateGraph4.UseVisualStyleBackColor = true;
            // 
            // btnCreateGraph3
            // 
            this.btnCreateGraph3.Location = new System.Drawing.Point(700, 93);
            this.btnCreateGraph3.Name = "btnCreateGraph3";
            this.btnCreateGraph3.Size = new System.Drawing.Size(112, 25);
            this.btnCreateGraph3.TabIndex = 32;
            this.btnCreateGraph3.Text = "Създай граф 3";
            this.btnCreateGraph3.UseVisualStyleBackColor = true;
            this.btnCreateGraph3.Click += new System.EventHandler(this.btnCreateGraph3_Click);
            // 
            // btnCreateGraph2
            // 
            this.btnCreateGraph2.Location = new System.Drawing.Point(700, 62);
            this.btnCreateGraph2.Name = "btnCreateGraph2";
            this.btnCreateGraph2.Size = new System.Drawing.Size(112, 25);
            this.btnCreateGraph2.TabIndex = 33;
            this.btnCreateGraph2.Text = "Създай граф 2";
            this.btnCreateGraph2.UseVisualStyleBackColor = true;
            this.btnCreateGraph2.Click += new System.EventHandler(this.btnCreateGraph2_Click);
            // 
            // btnCreateGraph5
            // 
            this.btnCreateGraph5.Location = new System.Drawing.Point(700, 157);
            this.btnCreateGraph5.Name = "btnCreateGraph5";
            this.btnCreateGraph5.Size = new System.Drawing.Size(112, 25);
            this.btnCreateGraph5.TabIndex = 34;
            this.btnCreateGraph5.Text = "Създай граф 5";
            this.btnCreateGraph5.UseVisualStyleBackColor = true;
            // 
            // btnDFS
            // 
            this.btnDFS.Location = new System.Drawing.Point(700, 281);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(112, 25);
            this.btnDFS.TabIndex = 35;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = true;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnMST
            // 
            this.btnMST.Location = new System.Drawing.Point(700, 343);
            this.btnMST.Name = "btnMST";
            this.btnMST.Size = new System.Drawing.Size(112, 25);
            this.btnMST.TabIndex = 36;
            this.btnMST.Text = "MST";
            this.btnMST.UseVisualStyleBackColor = true;
            this.btnMST.Click += new System.EventHandler(this.btnMST_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(700, 312);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(112, 25);
            this.btnBFS.TabIndex = 37;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(700, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 25);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Затвори";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.Location = new System.Drawing.Point(153, 97);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(112, 25);
            this.btnAddVertex.TabIndex = 15;
            this.btnAddVertex.Text = "Добави връх";
            this.btnAddVertex.UseVisualStyleBackColor = true;
            this.btnAddVertex.Click += new System.EventHandler(this.btnAddVertex_Click);
            // 
            // tbLabelVertex
            // 
            this.tbLabelVertex.Location = new System.Drawing.Point(12, 54);
            this.tbLabelVertex.Name = "tbLabelVertex";
            this.tbLabelVertex.Size = new System.Drawing.Size(253, 23);
            this.tbLabelVertex.TabIndex = 40;
            // 
            // listVertex2
            // 
            this.listVertex2.FormattingEnabled = true;
            this.listVertex2.ItemHeight = 15;
            this.listVertex2.Location = new System.Drawing.Point(153, 207);
            this.listVertex2.Name = "listVertex2";
            this.listVertex2.Size = new System.Drawing.Size(112, 154);
            this.listVertex2.TabIndex = 41;
            // 
            // listVertex1
            // 
            this.listVertex1.FormattingEnabled = true;
            this.listVertex1.ItemHeight = 15;
            this.listVertex1.Location = new System.Drawing.Point(12, 207);
            this.listVertex1.Name = "listVertex1";
            this.listVertex1.Size = new System.Drawing.Size(112, 154);
            this.listVertex1.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.listVertex1);
            this.Controls.Add(this.listVertex2);
            this.Controls.Add(this.tbLabelVertex);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.btnMST);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnCreateGraph5);
            this.Controls.Add(this.btnCreateGraph2);
            this.Controls.Add(this.btnCreateGraph3);
            this.Controls.Add(this.btnCreateGraph4);
            this.Controls.Add(this.btnCreateGraph1);
            this.Controls.Add(this.btnClearGraph);
            this.Controls.Add(this.btnShowMatrix);
            this.Controls.Add(this.btnTS);
            this.Controls.Add(this.btnDeleteVertex);
            this.Controls.Add(this.btnDeleteEdge);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.btnAddVertex);
            this.Controls.Add(this.cbDeleteVertex);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbDeleteVertex;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Button btnDeleteEdge;
        private System.Windows.Forms.Button btnDeleteVertex;
        private System.Windows.Forms.Button btnTS;
        private System.Windows.Forms.Button btnShowMatrix;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreateGraph1;
        private System.Windows.Forms.Button btnCreateGraph4;
        private System.Windows.Forms.Button btnCreateGraph3;
        private System.Windows.Forms.Button btnCreateGraph2;
        private System.Windows.Forms.Button btnCreateGraph5;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnMST;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.Button btnClearGraph;
        private System.Windows.Forms.TextBox tbLabelVertex;
        private System.Windows.Forms.ListBox listVertex2;
        private System.Windows.Forms.ListBox listVertex1;
    }
}

