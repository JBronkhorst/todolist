namespace To_Do_List_App
{
    partial class ToDoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.toDoListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1278, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1278, 22);
            this.textBox2.TabIndex = 2;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(14, 183);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(1278, 23);
            this.descriptionTextbox.TabIndex = 3;
            this.descriptionTextbox.Text = "Description:";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(14, 128);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(1278, 23);
            this.titleTextbox.TabIndex = 4;
            this.titleTextbox.Text = "Title:";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(14, 238);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(315, 46);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(335, 238);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(315, 46);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(656, 238);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(315, 46);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(977, 237);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(315, 46);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toDoListView
            // 
            this.toDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toDoListView.BackgroundColor = System.Drawing.Color.White;
            this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDoListView.Location = new System.Drawing.Point(17, 291);
            this.toDoListView.Name = "toDoListView";
            this.toDoListView.RowHeadersWidth = 51;
            this.toDoListView.RowTemplate.Height = 24;
            this.toDoListView.Size = new System.Drawing.Size(1275, 360);
            this.toDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1307, 663);
            this.Controls.Add(this.toDoListView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ToDoList";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label descriptionTextbox;
        private System.Windows.Forms.Label titleTextbox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView toDoListView;
    }
}

