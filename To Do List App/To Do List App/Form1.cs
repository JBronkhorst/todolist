using System;
using System.Data;
using System.Windows.Forms;

namespace To_Do_List_App
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void ToDoList_Load(object sender, EventArgs e)
        {
            // Create columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            // Point datagridview to datasource
            toDoListView.DataSource = todoList;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextbox.Text = "";
            descriptionTextbox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Fill text fields with data from table
            titleTextbox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextbox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleTextbox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextbox.Text;
            }
            else
            {
                todoList.Rows.Add(titleTextbox.Text, descriptionTextbox.Text);
            }
            // Clear fields
            titleTextbox.Text = "";
            descriptionTextbox.Text = "";
            isEditing = false;
        }
    }
}