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
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Office.Interop.Word;
using System.Net.Mail;

namespace generate_dean_list_cert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         *   Control what happens when clicking in or out of the text boxes.
         *   When clicking into the text box, empty the watermark text and
         *   allow the user to type if the water mark is there. If the watermark
         *   is not there, do nothing. When clicking out of the text box, if the
         *   box is empty, set the water mark but if it is not empty, do nothing.
         */
        private void TemplateCertificate_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TemplateCertificate.Text == "Template Certificate")
            {
                TemplateCertificate.Text = "";
                TemplateCertificate.Foreground = Brushes.Black;
            }
        }

        private void TemplateCertificate_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TemplateCertificate.Text == "")
            {
                TemplateCertificate.Text = "Template Certificate";
                TemplateCertificate.Foreground = Brushes.LightGray;
            }
        }

        private void InputStudentFile_GotFocus(object sender, RoutedEventArgs e)
        {
            if (InputStudentFile.Text == "Input Student File (CSV)")
            {
                InputStudentFile.Text = "";
                InputStudentFile.Foreground = Brushes.Black;
            }
        }

        private void InputStudentFile_LostFocus(object sender, RoutedEventArgs e)
        {
            if (InputStudentFile.Text == "")
            {
                InputStudentFile.Text = "Input Student File (CSV)";
                InputStudentFile.Foreground = Brushes.LightGray;
            }
        }

        private void OutputLocation_GotFocus(object sender, RoutedEventArgs e)
        {
            if (OutputLocation.Text == "Output Location")
            {
                OutputLocation.Text = "";
                OutputLocation.Foreground = Brushes.Black;
            }
        }

        private void OutputLocation_LostFocus(object sender, RoutedEventArgs e)
        {
            if (OutputLocation.Text == "")
            {
                OutputLocation.Text = "Output Location";
                OutputLocation.Foreground = Brushes.LightGray;
            }
        }

        private void Year_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Year.Text == "Year")
            {
                Year.Text = "";
                Year.Foreground = Brushes.Black;
            }
        }

        private void Year_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Year.Text == "")
            {
                Year.Text = "Year";
                Year.Foreground = Brushes.LightGray;
            }
        }

        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "Your Name")
            {
                Name.Text = "";
                Name.Foreground = Brushes.Black;
            }
        }

        private void Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "")
            {
                Name.Text = "Your Name";
                Name.Foreground = Brushes.LightGray;
            }
        }

        private void Email_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Email.Text == "Your Email")
            {
                Email.Text = "";
                Email.Foreground = Brushes.Black;
            }
        }

        private void Email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Your Email";
                Email.Foreground = Brushes.LightGray;
            }
        }
        /*
         *  End the text box stuff...
         */

        /*
         *  Allow selection of the files and folders by clicking buttons.
         *  Once the file or folder is selected, replace the text box with
         *  the location
         */
        private void Select_TemplateCertificate_Click(object sender, RoutedEventArgs e)
        {
            // Init the OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            // Only allow *.docx files for editing, but allow select for all
            openFileDialog.Filter = "Microsoft Word Files (*.docx)|*.docx|All Files (*.*)|*.*";

            // Now, get the file location and put it in the text box
            if (openFileDialog.ShowDialog() == true)
            {
                // Go ahead and make sure the color of the text box is correct
                TemplateCertificate.Foreground = Brushes.Black;

                // Now, go ahead and put the file name into the text box
                TemplateCertificate.Text = openFileDialog.FileName;
            }
        }

        private void Select_InputStudentFile_Click(object sender, RoutedEventArgs e)
        {
            // Init the OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            // Only allow *.csv files for the input, but allow select for all
            openFileDialog.Filter = "Comma Separated Files (*.csv)|*.csv|All Files (*.*)|*.*";

            // Now, get the file location and put it in the text box
            if (openFileDialog.ShowDialog() == true)
            {
                // Go ahead and make sure the color of the text box is correct
                InputStudentFile.Foreground = Brushes.Black;

                // Now, go ahead and put the file name into the text box
                InputStudentFile.Text = openFileDialog.FileName;
            }
        }

        private void Select_OutputLocation_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = openFolderDialog.ShowDialog();

            // Now, get the file location and put it in the text box
            if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(openFolderDialog.SelectedPath))
            {
                // Go ahead and make sure the color of the text box is correct
                OutputLocation.Foreground = Brushes.Black;

                // Now, go ahead and put the file name into the text box
                OutputLocation.Text = openFolderDialog.SelectedPath;
            }
        }
        /*
         *  End the file stuff...
         */
         
        /*
         *  Let's go ahead and define a function to find and replace
         *  to make our life easier later on
         */
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceWithText)
        {
            //options
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }

        private String PromptEmailMessage()
        {
            // Show the email prompt, but don't continue until it get's closed
            PromptEmailWindow messagePrompt = new PromptEmailWindow() { Owner = this };
            messagePrompt.ShowDialog();

            // Now, get the email message
            String emailMsg = messagePrompt.EmailMsg;

            // Return the email message
            return emailMsg;
        }

        private void SendEmail(String docPath, String emailFrom, String nameFrom, String emailTo, String fileName, String emailBody)
        {
            // Connect to the SMTP server
            SmtpClient smtpClient = new SmtpClient("exchange.centre.edu");

            // Setup and configure the message
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(new MailAddress(emailFrom, nameFrom), new MailAddress(emailTo));
            message.Subject = "Dean's Certificate";
            message.Body = emailBody;

            // Setup the certificate attachment
            Attachment certificate = new Attachment(docPath);
            certificate.Name = fileName + ".docx";

            // Attach the certificate to the message
            message.Attachments.Add(certificate);

            // Send the email...already in a try catch through the other method
            smtpClient.Send(message);
        }

        /*
         *  This will handle what happens when the user clicks the Generate button.
         *  We want to ensure that we have all of the proper information and then
         *  we will generate the certificates and email them out.
         */
        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            // Disable the view so nothing can happen while 
            MainView.IsEnabled = false;

            // Let's make sure all of the information is there by checking the text
            List<String> missingInfo = new List<String>();
            if (TemplateCertificate.Text == "Template Certificate")
                missingInfo.Add("Template Certificate File");
            if (InputStudentFile.Text == "Input Student File (CSV)")
                missingInfo.Add("Input Student File");
            if (OutputLocation.Text == "Output Location")
                missingInfo.Add("Output Location Folder");
            if (Year.Text == "Year")
                missingInfo.Add("Year");
            if (Term.SelectedIndex == 0)
                missingInfo.Add("Term");
            if (Name.Text == "Your Name")
                missingInfo.Add("Your Name");
            if (Email.Text == "Your Email")
                missingInfo.Add("Your Email");

            // If there is anything missing, we'll stop and let them know
            if(missingInfo.Count > 0)
            {
                String missingString = "Please ensure you have inputted ";
                foreach (String mI in missingInfo)
                    missingString += mI + ", ";
                missingString += "to continue.";

                // Now, announce to the user and re-enable the view
                GenerateComplete.Text = missingString;
                MainView.IsEnabled = true;
                return;
            }

            // Now, if we're here, we know we have all the information we need to proceed
            String templatePath = TemplateCertificate.Text;
            String inputPath = InputStudentFile.Text;
            String outputFolder = OutputLocation.Text;
            String year = Year.Text;
            String term = "";
            if (Term.SelectedIndex == 1)
                term = "Fall";
            else
                term = "Spring";

            String sendName = Name.Text;
            String sendEmail = Email.Text;

            // Let's prompt for an email message and get the email message
            String emailMsg = PromptEmailMessage();

            // Now, let's loop through each of the students in the input file
            try
            {
                // Students list so it's accessible elsewhere
                List<String[]> students = new List<String[]>();

                using (var reader = new StreamReader(@inputPath))
                {
                    // Skip the first line
                    reader.ReadLine();

                    // Add them to a list of arrays with:
                    //  0 => First Name
                    //  1 => Last Name
                    //  2 => Email
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        students.Add(values);
                    }
                }

                // Now, let's loop through each student and generate a certificate for each
                // Open only one word application
                Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();

                foreach (String[] studentArray in students)
                {
                    // Get the student's information so it's easier to use
                    String fname = studentArray[0];
                    String lname = studentArray[1];
                    String email = studentArray[2];

                    // Copy the template for the specific student
                    String outputFilePath = outputFolder + "\\" + fname + lname + year + term + ".docx";
                    File.Copy(templatePath, outputFilePath);

                    // Now, open the doc file and replace the wildcards with the information
                    Document document = ap.Documents.Open(@outputFilePath);
                    document.Activate();

                    FindAndReplace(ap, "#FNAME#", fname);
                    FindAndReplace(ap, "#LNAME#", lname);
                    FindAndReplace(ap, "#YEAR#", year);
                    FindAndReplace(ap, "#TERM#", term);

                    // Now, save and close the word document
                    document.Save();
                    document.Close();

                    // Now, let's send the email with the certificate
                    SendEmail(outputFilePath, sendEmail, sendName, email, "Certificate " + term + " " + year, emailMsg);
                }

                // Ensure the word application is closed
                ap.Quit();
            }
            catch (Exception ex)
            {
                GenerateComplete.Text = "An error occurred: " + ex;
                MainView.IsEnabled = true;
                return;
            }

            // At the end, we'll re-enable the main view and let the user know it's complete
            GenerateComplete.Text = "Generation Complete!";
            MainView.IsEnabled = true;
        }
    }
}
