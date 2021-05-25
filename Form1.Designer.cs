
namespace FileSplit
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
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelHeaderLines = new System.Windows.Forms.Label();
            this.labelMaxLinesPerFile = new System.Windows.Forms.Label();
            this.numericHeaderLines = new System.Windows.Forms.NumericUpDown();
            this.numericMaxLines = new System.Windows.Forms.NumericUpDown();
            this.labelHeaderLinesHelp = new System.Windows.Forms.Label();
            this.checkBoxCountHeaderLines = new System.Windows.Forms.CheckBox();
            this.buttonSplitFile = new System.Windows.Forms.Button();
            this.labelFilesCreated = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeaderLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxLines)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.AllowDrop = true;
            this.textBoxFileName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFileName.Location = new System.Drawing.Point(114, 11);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(744, 22);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFileName_DragDrop);
            this.textBoxFileName.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxFileName_DragOver);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(864, 10);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(55, 23);
            this.buttonChoose.TabIndex = 3;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(83, 14);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(25, 15);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "File";
            // 
            // labelHeaderLines
            // 
            this.labelHeaderLines.AutoSize = true;
            this.labelHeaderLines.Location = new System.Drawing.Point(36, 42);
            this.labelHeaderLines.Name = "labelHeaderLines";
            this.labelHeaderLines.Size = new System.Drawing.Size(72, 15);
            this.labelHeaderLines.TabIndex = 4;
            this.labelHeaderLines.Text = "Header lines";
            // 
            // labelMaxLinesPerFile
            // 
            this.labelMaxLinesPerFile.AutoSize = true;
            this.labelMaxLinesPerFile.Location = new System.Drawing.Point(12, 71);
            this.labelMaxLinesPerFile.Name = "labelMaxLinesPerFile";
            this.labelMaxLinesPerFile.Size = new System.Drawing.Size(96, 15);
            this.labelMaxLinesPerFile.TabIndex = 7;
            this.labelMaxLinesPerFile.Text = "Max lines per file";
            // 
            // numericHeaderLines
            // 
            this.numericHeaderLines.Location = new System.Drawing.Point(114, 40);
            this.numericHeaderLines.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericHeaderLines.Name = "numericHeaderLines";
            this.numericHeaderLines.Size = new System.Drawing.Size(55, 23);
            this.numericHeaderLines.TabIndex = 5;
            // 
            // numericMaxLines
            // 
            this.numericMaxLines.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericMaxLines.Location = new System.Drawing.Point(114, 69);
            this.numericMaxLines.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericMaxLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMaxLines.Name = "numericMaxLines";
            this.numericMaxLines.Size = new System.Drawing.Size(93, 23);
            this.numericMaxLines.TabIndex = 8;
            this.numericMaxLines.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelHeaderLinesHelp
            // 
            this.labelHeaderLinesHelp.AutoSize = true;
            this.labelHeaderLinesHelp.Location = new System.Drawing.Point(185, 42);
            this.labelHeaderLinesHelp.Name = "labelHeaderLinesHelp";
            this.labelHeaderLinesHelp.Size = new System.Drawing.Size(469, 15);
            this.labelHeaderLinesHelp.TabIndex = 6;
            this.labelHeaderLinesHelp.Text = "(If >0, then this number of header lines will be copied to the beginning of each " +
    "split file)";
            // 
            // checkBoxCountHeaderLines
            // 
            this.checkBoxCountHeaderLines.AutoSize = true;
            this.checkBoxCountHeaderLines.Location = new System.Drawing.Point(223, 70);
            this.checkBoxCountHeaderLines.Name = "checkBoxCountHeaderLines";
            this.checkBoxCountHeaderLines.Size = new System.Drawing.Size(277, 19);
            this.checkBoxCountHeaderLines.TabIndex = 9;
            this.checkBoxCountHeaderLines.Text = "Count header lines toward the max lines per file";
            this.checkBoxCountHeaderLines.UseVisualStyleBackColor = true;
            // 
            // buttonSplitFile
            // 
            this.buttonSplitFile.Location = new System.Drawing.Point(114, 98);
            this.buttonSplitFile.Name = "buttonSplitFile";
            this.buttonSplitFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSplitFile.TabIndex = 10;
            this.buttonSplitFile.Text = "Split File";
            this.buttonSplitFile.UseVisualStyleBackColor = true;
            this.buttonSplitFile.Click += new System.EventHandler(this.buttonSplitFile_Click);
            // 
            // labelFilesCreated
            // 
            this.labelFilesCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilesCreated.Location = new System.Drawing.Point(685, 105);
            this.labelFilesCreated.Name = "labelFilesCreated";
            this.labelFilesCreated.Size = new System.Drawing.Size(234, 16);
            this.labelFilesCreated.TabIndex = 12;
            this.labelFilesCreated.Text = "0 files created";
            this.labelFilesCreated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFilesCreated.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 129);
            this.Controls.Add(this.labelFilesCreated);
            this.Controls.Add(this.buttonSplitFile);
            this.Controls.Add(this.checkBoxCountHeaderLines);
            this.Controls.Add(this.labelHeaderLinesHelp);
            this.Controls.Add(this.numericMaxLines);
            this.Controls.Add(this.numericHeaderLines);
            this.Controls.Add(this.labelMaxLinesPerFile);
            this.Controls.Add(this.labelHeaderLines);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.textBoxFileName);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "File Split";
            ((System.ComponentModel.ISupportInitialize)(this.numericHeaderLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelHeaderLines;
        private System.Windows.Forms.Label labelMaxLinesPerFile;
        private System.Windows.Forms.NumericUpDown numericHeaderLines;
        private System.Windows.Forms.NumericUpDown numericMaxLines;
        private System.Windows.Forms.Label labelHeaderLinesHelp;
        private System.Windows.Forms.CheckBox checkBoxCountHeaderLines;
        private System.Windows.Forms.Button buttonSplitFile;
        private System.Windows.Forms.Label labelFilesCreated;
    }
}

