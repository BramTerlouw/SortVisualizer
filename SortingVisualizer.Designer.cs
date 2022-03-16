
namespace SortingVisualizer
{
    partial class SortingVisualizer
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
            this.cmbAlgorithms = new System.Windows.Forms.ComboBox();
            this.pnlSortVisualizer = new System.Windows.Forms.Panel();
            this.btnResetVisualizer = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithm:";
            // 
            // cmbAlgorithms
            // 
            this.cmbAlgorithms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgorithms.FormattingEnabled = true;
            this.cmbAlgorithms.Items.AddRange(new object[] {
            "Bubble Sort",
            "QuickSort",
            "Insertion Sort",
            "Selection Sort"});
            this.cmbAlgorithms.Location = new System.Drawing.Point(111, 13);
            this.cmbAlgorithms.Name = "cmbAlgorithms";
            this.cmbAlgorithms.Size = new System.Drawing.Size(121, 23);
            this.cmbAlgorithms.TabIndex = 1;
            // 
            // pnlSortVisualizer
            // 
            this.pnlSortVisualizer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSortVisualizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlSortVisualizer.Location = new System.Drawing.Point(13, 48);
            this.pnlSortVisualizer.Name = "pnlSortVisualizer";
            this.pnlSortVisualizer.Size = new System.Drawing.Size(806, 470);
            this.pnlSortVisualizer.TabIndex = 2;
            // 
            // btnResetVisualizer
            // 
            this.btnResetVisualizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetVisualizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.btnResetVisualizer.FlatAppearance.BorderSize = 0;
            this.btnResetVisualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetVisualizer.Location = new System.Drawing.Point(720, 9);
            this.btnResetVisualizer.Name = "btnResetVisualizer";
            this.btnResetVisualizer.Size = new System.Drawing.Size(98, 33);
            this.btnResetVisualizer.TabIndex = 3;
            this.btnResetVisualizer.Text = "Reset";
            this.btnResetVisualizer.UseVisualStyleBackColor = false;
            this.btnResetVisualizer.Click += new System.EventHandler(this.btnResetVisualizer_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(618, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 33);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Sort";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // SortingVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(831, 530);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnResetVisualizer);
            this.Controls.Add(this.pnlSortVisualizer);
            this.Controls.Add(this.cmbAlgorithms);
            this.Controls.Add(this.label1);
            this.Name = "SortingVisualizer";
            this.Text = "Sorting Vizualizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlgorithms;
        private System.Windows.Forms.Panel pnlSortVisualizer;
        private System.Windows.Forms.Button btnResetVisualizer;
        private System.Windows.Forms.Button btnStart;
    }
}

