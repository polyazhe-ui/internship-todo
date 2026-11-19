namespace Student.WindowsTodo
{
    /// <summary>
    /// Вторая форма для создания задачи.
    /// </summar
    public partial class TaskCreatorForm : Form
    {
        /// <summary>
        /// Созданная задача.
        /// </summary>
        public Task? CreatedTask { get; private set; }

        /// <summary>
        /// Инициализирует вторую форму приложения.
        /// </summary>
        public TaskCreatorForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent; 
            FormBorderStyle = FormBorderStyle.FixedDialog;  
            MaximizeBox = false;
            MinimizeBox = false;

            tbTaskTitle.Text = "";
            tbTaskTitle.PlaceholderText = "Введите заголовок задачи...";
            tbTaskDescription.Text = "";
            tbTaskDescription.PlaceholderText = "Введите описание задачи...";

            bCancel.DialogResult = DialogResult.Cancel; 
            CancelButton = bCancel;                     

            bCreateTask.Click += bCreateTask_Click;             
        }

        /// <summary>
        /// Кнопка «Создать».
        /// </summary>
        /// /// <param name="sender">Кнопка, вызвавшая обработчик.</param>
        /// <param name="e">Данные о событии нажатия кнопки.</param>
        private void bCreateTask_Click(object? sender, EventArgs e)
        {
            string taskTitle = tbTaskTitle.Text.Trim();

            if (string.IsNullOrEmpty(taskTitle))
            {
                MessageBox.Show(
                    "Введите заголовок задачи.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbTaskTitle.Focus();
                return;           
            }

            CreatedTask = new Task
            {
                Title = taskTitle,
                Description = tbTaskDescription.Text.Trim()
            };

            DialogResult = DialogResult.OK;
        }
    }
}