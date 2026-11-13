using Task = Student.WindowsTodo.Task;

namespace Student.WindowsTodo
{
    public partial class Form1 : Form
    {
        private readonly List<Task> tasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();        

            StartPosition = FormStartPosition.CenterScreen;
            SetupGrid();
        }

        /// <summary>
        /// Настраивает таблицу.
        /// </summary>
        private void SetupGrid()
        {
            dataGridView2.AllowUserToAddRows = false;    
            dataGridView2.AllowUserToDeleteRows = false; 
            dataGridView2.ReadOnly = true;               
            dataGridView2.RowHeadersVisible = false;     
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Column1.FillWeight = 30;
            Column2.FillWeight = 55;
            Column3.FillWeight = 15;
        }

        /// <summary>
        /// Создаёт таблицу по списку задач.
        /// </summary>
        private void RefreshGrid()
        {
            dataGridView2.Rows.Clear();

            foreach (Task n in tasks)
            {
                int rowIndex = dataGridView2.Rows.Add(n.Title, n.Description);
                dataGridView2.Rows[rowIndex].Tag = n;
            }
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            using (Form2 addForm = new Form2())
            {
                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.OK && addForm.CreatedTask != null)
                {
                    tasks.Add(addForm.CreatedTask);
                    RefreshGrid();
                }
            }
        }

        /// <summary>
        /// Клик по содержимому ячейки (нас интересует кнопка «Удалить»).
        /// Подписка уже есть в Form1.Designer.cs.
        /// </summary>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // e.RowIndex == -1 означает клик по заголовку столбца.
            // Ещё проверяем, что кликнули именно по столбцу с кнопкой.
            if (e.RowIndex < 0 || e.ColumnIndex != Column3.Index)
            {
                return;
            }

            if (dataGridView2.Rows[e.RowIndex].Tag is not Task task)
            {
                return;
            }

            using (Form3 confirmForm = new Form3(task.Title))
            {
                if (confirmForm.ShowDialog(this) == DialogResult.OK)
                {
                    tasks.Remove(task);
                    RefreshGrid();
                }
            }
        }
    }
}