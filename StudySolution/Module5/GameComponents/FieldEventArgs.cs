namespace GameComponents
{
    public delegate void FieldStateHandler(object sender, FieldEventArgs e);

    public class FieldEventArgs
    {
        public string Message { get; private set; }

        public FieldEventArgs(string message)
        {
            Message = message;
        }
    }
}
