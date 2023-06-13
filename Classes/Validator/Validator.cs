using Bunifu.UI.WinForms;
using System.Windows.Forms;

namespace C__Todo_App_with_SQL_Server
{
    public static class Validator
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        public static bool IsPresent(BunifuTextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field. ", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
