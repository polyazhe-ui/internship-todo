using System.ComponentModel;

namespace Student.WindowsTodo
{
    public partial class TaskViewerForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            gvTask = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            ((ISupportInitialize)gvTask).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 20);
            button1.Name = "button1";
            button1.Size = new Size(132, 49);
            button1.TabIndex = 0;
            button1.Text = "Добавить задачу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += bAddTask_Click;
            // 
            // gvTask
            // 
            gvTask.AllowUserToAddRows = false;
            gvTask.AllowUserToDeleteRows = false;
            gvTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTask.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            gvTask.Location = new Point(12, 90);
            gvTask.MultiSelect = false;
            gvTask.Name = "gvTask";
            gvTask.ReadOnly = true;
            gvTask.RowHeadersVisible = false;
            gvTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvTask.Size = new Size(776, 333);
            gvTask.TabIndex = 2;
            gvTask.CellContentClick += gvTask_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Задача";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Описание";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Удалить";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            Column3.Text = "Удалить ";
            Column3.UseColumnTextForButtonValue = true;
            // 
            // TaskViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvTask);
            Controls.Add(button1);
            Name = "TaskViewerForm";
            Text = "Todo";
            ((ISupportInitialize)gvTask).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView gvTask;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
    }



}
