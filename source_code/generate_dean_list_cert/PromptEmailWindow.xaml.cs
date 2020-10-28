using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace generate_dean_list_cert
{
    /// <summary>
    /// Interaction logic for PromptEmail.xaml
    /// </summary>

    public partial class PromptEmailWindow : Window
    {
        // Variable to store the email message so that we can retrieve it later
        private String EmailMsgValue;

        // Getter and setter for EmailMsgValue
        public String EmailMsg
        {
            get
            {
                if (EmailMsgValue == "Begin typing your message here...")
                    return "";
                else
                    return EmailMsgValue;
            }

            set { EmailMsgValue = value; }
        }

        public PromptEmailWindow()
        {
            EmailMsg = "";
            InitializeComponent();
        }

        /*
         *  Whenever the user clicks on the textbox, it will prepare for typing
         */
        private void EmailMessage_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailMessage.Text == "Begin typing your message here...")
            {
                EmailMessage.Text = "";
                EmailMessage.Foreground = Brushes.Black;
            }
        }

        /*
         *  Whenever the user clicks outside of the textbox, update the
         *  email message string for the window and then put the default prompt
         *  back into the textbox
         */
        private void EmailMessage_LostFocus(object sender, RoutedEventArgs e)
        {
            // Set the email message variable for the object
            EmailMsg = EmailMessage.Text;

            // Now, check if we need to replace to the default prompt
            if (EmailMessage.Text == "")
            {
                EmailMessage.Text = "Begin typing your message here...";
                EmailMessage.Foreground = Brushes.LightGray;
            }
        }

        /*
         *  When the user clicks the close button, let's close the window
         *  so our program can continue. We'll also double check to make sure the
         *  email message is the most updated.
         */
        private void ClosePromptEmail_Click(object sender, RoutedEventArgs e)
        {
            // Make sure the EmailMsg variable is the most updated
            EmailMsg = EmailMessage.Text;

            // Now, close the current window since we're finished
            Close();
        }
    }
}
