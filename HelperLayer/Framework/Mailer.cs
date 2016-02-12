using System.Collections.Specialized;
using System.Net;
using System.Text;
using HelperLayer.Modals;

namespace HelperLayer.Framework {
    public class Mailer {
        public static string Username = "yourname@example.com";
        public static string ApiKey = "31578bd8-4cd4-468f-b695-b44ab1f82540";

        public string SendEmail(Email email) {
            WebClient client = new WebClient();
            NameValueCollection values = new NameValueCollection();
            values.Add("username", Username);
            values.Add("api_key", ApiKey);
            values.Add("from", email.From);
            values.Add("from_name", email.Name);
            values.Add("subject", email.Subject);
            if (email.BodyHtml != null)
                values.Add("body_html", email.BodyHtml);
            if (email.BodyText != null)
                values.Add("body_text", email.BodyText);
            values.Add("to", email.To);
            byte[] response = client.UploadValues("https://api.elasticemail.com/mailer/send", values);
            return Encoding.UTF8.GetString(response);
        }
    }
}
