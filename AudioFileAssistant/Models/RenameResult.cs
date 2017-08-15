namespace AudioFileAssistant.Models
{
    internal struct RenameResult
    {
        private bool _success;
        private string _message;

        public bool Success
        {
            get { return _success; }
            set { _success = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        
    }
}
