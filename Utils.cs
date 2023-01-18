namespace TextEditor
{
    class Utils
    {
        public class Rtf
        {
            static public void LoadFile(RichTextBox textBox, string fileName)
            {
                textBox.LoadFile(fileName);
            }

            static public void SaveFile(RichTextBox textBox, string fileName)
            {
                textBox.SaveFile(fileName);
            }
        }
        
        private static string extensionsAllowed = "Text Files (*.txt)|*.txt|Formatted Text Files (*.rtf)|*.rtf";
        
        static public SaveFileDialog SetupSaveDialog()
        {
            return new SaveFileDialog
            {
                Filter = extensionsAllowed,
                Title = "Save a Text File",
                CheckWriteAccess = true
            };
        }
        
        static public OpenFileDialog SetupFileDialog()
        {
            return new OpenFileDialog
            {
                Filter = extensionsAllowed,
                Title = "Select a Text File",
                CheckFileExists = true,
                CheckPathExists = true,
                FileName = ""
            };
        }
    }
}
