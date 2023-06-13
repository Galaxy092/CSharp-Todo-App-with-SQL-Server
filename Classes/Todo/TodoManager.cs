using C__Todo_App_with_SQL_Server.DB;
using System;
using System.Data;

namespace C__Todo_App_with_SQL_Server.Classes
{
    public static class TodoManager
    {
        // Update Todo
        public static void vUpdateData(string _id)
        {
            string sql = " usp_TodoList '" + _id + "', '', '', '', '', 'UPDATE'";
            DataSet ds = DBConnection.vFillDataSet(sql);
        }

        // Delete Todo
        public static void vDeleteData(string _id)
        {
            string sql = " usp_TodoList '" + _id + "', '', '', '', '', 'DELETE'";
            DataSet ds = DBConnection.vFillDataSet(sql);
        }

        // Add Todo
        public static void vAddData(Bunifu.UI.WinForms.BunifuTextBox txtTitle, Bunifu.UI.WinForms.BunifuDatePicker dtpDate, Bunifu.UI.WinForms.BunifuTextBox txtDescription)
        {
            string sql = " usp_TodoList '', '" + txtTitle.Text + "', '" + DateTime.Parse(dtpDate.Value.ToString()) + "', '', '" + txtDescription.Text + "', 'ADD'";
            DataSet ds = DBConnection.vFillDataSet(sql);
        }
    }
}
