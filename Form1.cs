namespace TextEditor
{
    public partial class Form1 : Form
    {
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void showStatusBarWarning(string message)
        {
            statusBarTimer.Enabled = true;
            statusBar.Visible = true;
            lblStatusBar.Text = message;
        }
        
        private void btnSelectTextFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = Utils.SetupFileDialog())
            {
                fileDialog.ShowDialog();

                if (fileDialog.FileName != "")
                {
                    fileName = fileDialog.FileName;
                    using (StreamReader reader = File.OpenText(fileDialog.FileName))
                    {
                        if (Path.GetExtension(fileName) == ".rtf")
                            textBox.LoadFile(fileName);
                        else
                            textBox.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                    }
                
                    btnSaveTextFile.Enabled = true;
                    btnSaveAs.Enabled = true;
                    ActiveForm.Text = Path.GetFileName(fileName);

                    showStatusBarWarning("File opened successfully!");
                }
            }
        }

        private void btnSaveTextFile_Click(object sender, EventArgs e)
        {
            if (fileName != "")
            {
                if (Path.GetExtension(fileName) == ".rtf")
                    textBox.SaveFile(fileName);
                else
                    textBox.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                    
                showStatusBarWarning("File saved successfully!");
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = Utils.SetupSaveDialog())
            {
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    fileName = saveFileDialog.FileName;

                    if (Path.GetExtension(fileName) == ".rtf")
                        textBox.SaveFile(fileName);
                    else
                        textBox.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                    
                    btnSaveTextFile.Enabled = true;

                    showStatusBarWarning($"File saved successfully as {fileName}.");
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveAs.Enabled = true;
        }

        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            if (btnWordWrap.Checked)
            {
                btnWordWrap.Checked = false;
                textBox.WordWrap = false;
            }
            else
            {
                btnWordWrap.Checked = true;
                textBox.WordWrap = true;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
        }

        private void fontDialog_Apply(object sender, EventArgs e)
        {
            textBox.Font = fontDialog.Font;
        }

        private void btnMakeItalic_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = EditorControler.ChangeFontStyle(textBox.SelectionFont, FontStyle.Italic);
        }

        private void btnMakeBold_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = EditorControler.ChangeFontStyle(textBox.SelectionFont, FontStyle.Bold);
        }

        private void btnMakeUnderlined_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = EditorControler.ChangeFontStyle(textBox.SelectionFont, FontStyle.Underline);
        }

        private void btnIncreaseFontSize_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = EditorControler.ChangeFontSize(textBox.SelectionFont, 1);
        }

        private void btnDecreaseFontSize_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = EditorControler.ChangeFontSize(textBox.SelectionFont, -1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.OemMinus)
            {
                if (textBox.ZoomFactor > 1)
                    textBox.ZoomFactor -= 1;
            }
            else if (e.Control && e.KeyCode == Keys.Oemplus)
            {
                if (textBox.ZoomFactor < 10)
                    textBox.ZoomFactor += 1;
            }
            
            if (e.Control && e.KeyCode == Keys.S)
            {
                if (btnSaveTextFile.Enabled)
                    btnSaveTextFile_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.O)
                btnSelectTextFile_Click(sender, e);
        }
        
        private void statusBarTimer_Tick(object sender, EventArgs e)
        {
            statusBar.Visible = false;
            statusBarTimer.Enabled = false;
        }
    }
}