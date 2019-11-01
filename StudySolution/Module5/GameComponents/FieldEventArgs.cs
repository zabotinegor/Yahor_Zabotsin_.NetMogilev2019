namespace GameComponents
{
    delegate void AccountStateHandler(object sender, FieldEventArgs e);

    class FieldEventArgs
    {
        public string Message { get; private set; }

        public FieldEventArgs(string message)
        {
            Message = message;
        }
    }
}
