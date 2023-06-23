using C__Todo_App_with_SQL_Server.DB;
using System;
using System.Data;
using System.Windows.Forms;

namespace C__Todo_App_with_SQL_Server.Classes
{
    public class TodoManager
    {
        // Update Todo
        public void vUpdateData(string _id)
        {
            string sql = " usp_TodoList '" + _id + "', '', '', '', '', 'UPDATE'";
            DataSet ds = DBConnection.vFillDataSet(sql);
        }

        // Delete Todo
        public void vDeleteData(string _id)
        {
            string sql = " usp_TodoList '" + _id + "', '', '', '', '', 'DELETE'";
            DataSet ds = DBConnection.vFillDataSet(sql);
        }

        // Add Todo
        public void vAddData(TextBox txtTitle, DateTimePicker dtpDate, TextBox txtDescription)
        {
            string sql = " usp_TodoList '', '" + txtTitle.Text + "', '" + DateTime.Parse(dtpDate.Value.ToString()) + "', '', '" + txtDescription.Text + "', 'ADD'";
            DataSet ds = DBConnection.vFillDataSet(sql);
        }
    }
}
