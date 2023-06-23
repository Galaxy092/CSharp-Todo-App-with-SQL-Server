using System.Windows.Forms;

namespace C__Todo_App_with_SQL_Server
{
    public static class Validator
    {
        private static string title = "Todo";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        public static bool IsPresent(TextBox textBox)
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
