using C__Todo_App_with_SQL_Server.DB;
using System;
using System.Data;
using System.Windows.Forms;

namespace C__Todo_App_with_SQL_Server.Classes
{
    public class TodoManager
    {
        // Update Todo
        public void updateTodo(string _id)
        {
            string sql = " usp_TodoList '" + _id + "', '', '', '', '', 'UPDATE'";
            DataSet ds = DBConnection.GetConnection(sql);
        }

        // Delete Todo
        public void deleteTodo(string _id)
        {
            string sql = " usp_TodoList '" + _id + "', '', '', '', '', 'DELETE'";
            DataSet ds = DBConnection.GetConnection(sql);
        }

        // Add Todo
        public void addTodo(TextBox txtTitle, DateTimePicker dtpDate, TextBox txtDescription)
        {
            string sql = " usp_TodoList '', '" + txtTitle.Text + "', '" + DateTime.Parse(dtpDate.Value.ToString()) + "', '', '" + txtDescription.Text + "', 'ADD'";
            DataSet ds = DBConnection.GetConnection(sql);
        }
    }
}
