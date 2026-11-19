using Task = Student.WindowsTodo.Task;

namespace Student.WindowsTodo
{

    /// <summary>
    /// Первая форма для просмотра задач. 
    /// </summary>
    public partial class TaskViewerForm : Form
    {
        private readonly List<Task> tasks = new List<Task>();

        /// <summary>
        /// Инициализирует главную форму приложения.
        /// </summary>
        public TaskViewerForm()
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
            gvTask.AllowUserToAddRows = false;    
            gvTask.AllowUserToDeleteRows = false; 
            gvTask.ReadOnly = true;               
            gvTask.RowHeadersVisible = false;     
            gvTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvTask.MultiSelect = false;

            gvTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Column1.FillWeight = 30;
            Column2.FillWeight = 55;
            Column3.FillWeight = 15;
        }

        /// <summary>
        /// Создаёт таблицу по списку задач.
        /// </summary>
        private void RefreshGrid()
        {
            gvTask.Rows.Clear();

            foreach (Task task in tasks)
            {
                int rowIndex = gvTask.Rows.Add(task.Title, task.Description);
                gvTask.Rows[rowIndex].Tag = task;
            }
        }

        /// <summary>
        /// Добавляет новую задачу в таблицу.
        /// </summary>
        /// <param name="sender">Кнопка, вызвавающая обработчик.</param>
        /// <param name="e">Данные о событии нажатия кнопки.</param>
        private void bAddTask_Click(object? sender, EventArgs e)
        {
            using (TaskCreatorForm addForm = new TaskCreatorForm())
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
        /// Обработка клика по кнопке удаления.
        /// </summary>
        /// <param name="sender">Таблица задач.</param>
        /// <param name="e">Данные о событии.</param>
        private void gvTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != Column3.Index)
            {
                return;
            }

            if (gvTask.Rows[e.RowIndex].Tag is not Task task)
            {
                return;
            }

            using (DeleteForm confirmForm = new DeleteForm(task.Title))
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
