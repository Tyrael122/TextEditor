namespace TextEditor
{
    class EditorControler
    {
        static public Font ChangeFontStyle(Font font, FontStyle fontStyle)
        {
            return new Font(font, font.Style ^ fontStyle);
        }

        static public Font ChangeFontSize(Font font, int amount)
        {
            return new Font(font.FontFamily, font.Size + amount, font.Style);
        }
    }
}
