using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSplit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBoxFileName.Text = dialog.FileName;
                }
            }
        }

        private void textBoxFileName_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void textBoxFileName_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                textBoxFileName.Text = files.First(); //select the first one 
        }

        void ReportProgress(int value)
        {
            labelFilesCreated.Text = $"{value} files created";
        }

        private CancellationTokenSource cts;

        private async void buttonSplitFile_Click(object sender, EventArgs e)
        {

            if (buttonSplitFile.Text == "Cancel")
            {
                cts.Cancel();
            }
            else if (buttonSplitFile.Text == "Split File")
            {
                if (string.IsNullOrEmpty(textBoxFileName.Text))
                {
                    MessageBox.Show("Please choose a file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                buttonSplitFile.Text = "Cancel";

                buttonChoose.Enabled = false;
                textBoxFileName.Enabled = false;
                numericHeaderLines.Enabled = false;
                numericMaxLines.Enabled = false;
                checkBoxCountHeaderLines.Enabled = false;
                labelFilesCreated.Visible = true;

                var progressIndicator = new Progress<int>(ReportProgress);


                var filePath = Path.GetFullPath(textBoxFileName.Text);
                var headerLines = Convert.ToInt32(numericHeaderLines.Value);
                var maxLines = Convert.ToInt32(numericMaxLines.Value);
                var countHeaderLines = checkBoxCountHeaderLines.Checked;

                cts = new CancellationTokenSource();

                bool isSuccess = false;
                string message = "";
                var task = Task.Run(() => SplitFile(filePath, headerLines, maxLines, countHeaderLines, progressIndicator, cts.Token), cts.Token);

                try
                {
                    (isSuccess, message) = await task;                    
                }
                catch (OperationCanceledException ex)
                {
                    isSuccess = false;
                    message = "Cancelled";
                }

                if (!isSuccess)
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                buttonSplitFile.Text = "Split File";
                buttonChoose.Enabled = true;
                textBoxFileName.Enabled = true;
                numericHeaderLines.Enabled = true;
                numericMaxLines.Enabled = true;
                checkBoxCountHeaderLines.Enabled = true;

            }
        }


        private async Task<(bool isSuccess, string message)> SplitFile(string filePath, int headerLines, int maxLines, bool countHeaderLines, IProgress<int> progress, CancellationToken ct)
        {

            string fileExtension = Path.GetExtension(filePath);
            string filePathWithoutExtension = filePath.Substring(0, filePath.Length - fileExtension.Length);

            if (!File.Exists(filePath)) return (false, "File not found");


            var fileNumber = 0;
            try
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    var headers = new string[headerLines];
                    while (!sr.EndOfStream)
                    {
                        fileNumber++;
                        if (fileNumber == 1 && headerLines > 0)
                        {
                            for (var lineNumber = 0; lineNumber < headerLines; lineNumber++)
                            {
                                var s = sr.ReadLine();
                                headers[lineNumber] = s;
                            }
                        }

                        using (StreamWriter writer = new StreamWriter(filePathWithoutExtension + "_" + fileNumber.ToString("0000") + fileExtension))
                        {
                            if (progress != null)
                            {
                                progress.Report(fileNumber);
                            }

                            if (headerLines > 0)
                            {
                                foreach (var header in headers)
                                {
                                    ct.ThrowIfCancellationRequested();
                                    writer.WriteLine(header);
                                }
                            }

                            for (var lineNumber = countHeaderLines ? headerLines : 0; lineNumber < maxLines; lineNumber++)
                            {
                                var s = sr.ReadLine();
                                if (s == null) break;
                                ct.ThrowIfCancellationRequested();
                                writer.WriteLine(s);
                            }
                        }
                    }
                }
            } 
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
            return (true, $"Completed. Created {fileNumber} files.");
        }
    }
}
