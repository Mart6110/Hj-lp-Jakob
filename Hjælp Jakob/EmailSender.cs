using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Jakob
{
    public class EmailSender
    {
        // Sends a message via SMTP
        public void SendMessage(Message message, bool isHTML)
        {
            if (isHTML)
            {
                message.Body = ConvertBodyToHTML(message.Body);
            }
        }

        // Converts plain text to HTML
        private string ConvertBodyToHTML(string plainText)
        {
            return "<html><body>" + plainText + "</body></html>";
        }
    }
}
