using C__Todo_App_with_SQL_Server.Classes;
using C__Todo_App_with_SQL_Server.DB;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__Todo_App_with_SQL_Server
{
    public partial class frmTodo : Form
    {
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        DataGridViewButtonColumn col_update = new DataGridViewButtonColumn();
        DataGridViewButtonColumn col_delete = new DataGridViewButtonColumn();
        public TodoManager todoMgr = new TodoManager();

        public frmTodo()
        {
            InitializeComponent();
        }

        private void frmTodo_Load(object sender, EventArgs e)
        {
            // Load Data
            vLoadData();
            // Get recent data time
            dtpDate.Text = DateTime.Now.ToShortTimeString();
        }

        // Get All Todo
        public void vLoadData()
        {
            // SQL Query to Read Data
            string sql = " usp_TodoList '', '', '', '', '', 'VIEW'";

            // Execute SQL Query
            DataSet ds = DBConnection.vFillDataSet(sql);

            dgv.Columns.Clear();
            // Customize Column Name, Text, HeaderText and ColumnTextForButtonValue
            chk.Name = "Chk"; chk.HeaderText = "Check";
            col_update.Name = "Update"; col_update.Text = "Update"; col_update.HeaderText = "Update";
            col_update.UseColumnTextForButtonValue = true;
            col_delete.Name = "Delete"; col_delete.Text = "Delete"; col_delete.HeaderText = "Delete";
            col_delete.UseColumnTextForButtonValue = true;


            dgv.DataSource = ds.Tables[0];

            // Add Columns Check, Update and Delete
            dgv.Columns.Add(chk);
            dgv.Columns.Add(col_update);
            dgv.Columns.Add(col_delete);

            // Set Width for Columns
            dgv.Columns[0].Width = dgv.Width / 21;
            dgv.Columns[1].Width = (int)(dgv.Width / 7.5);
            dgv.Columns[2].Width = (int)(dgv.Width / 6.3);
            dgv.Columns[3].Width = dgv.Width / 10;
            dgv.Columns[4].Width = (int)(dgv.Width / 3.45);
            dgv.Columns[5].Width = dgv.Width / 14;
            dgv.Columns[6].Width = dgv.Width / 10;
            dgv.Columns[7].Width = dgv.Width / 10;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgv.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgv.Columns[i].Width;

                // Remove AutoSizing:
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgv.Columns[i].Width = colw;
            }
        }

        // Button Add with Event Click to Add Data and LoadData
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                todoMgr.vAddData(txtTitle, dtpDate, txtDescription);
                txtTitle.Text = "";
                txtDescription.Text = "";
            }
            vLoadData();
            txtTitle.Focus();
        }

        // Validate TextBox
        private bool IsValidData()
        {
            return Validator.IsPresent(txtTitle) &&
                Validator.IsPresent(txtDescription);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
            try
            {
                if (dgv["chk", e.RowIndex].Value==null)
                {
                    return;
                }
                else if (bool.Parse(dgv["chk", e.RowIndex].Value.ToString()) == true && e.ColumnIndex == col_update.Index)
                {
                    string _id = dgv["ID", e.RowIndex].Value.ToString();
                    todoMgr.vUpdateData(_id);
                    vLoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == col_delete.Index)
            {
                string id = dgv["ID", e.RowIndex].Value.ToString();
                todoMgr.vDeleteData(id);
                vLoadData();
            }
        }
    }
}
