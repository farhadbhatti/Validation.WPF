using System;

namespace CGI.Validation.WPF
{
    public class MessageEventArgs : EventArgs
    {
        public MessageEventArgs()
        {
            this.Message = string.Empty;
            this.Caption = string.Empty;
        }

        public string Message { get; set; }

        public string Caption { get; set; }
    }
}
