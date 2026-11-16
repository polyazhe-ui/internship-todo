using Task = Student.WindowsTodo.Task;

namespace Student.WindowsTodo
{
    /// <summary>
    /// Вторая форма для создания задачи.
    /// </summar
    public partial class Form2 : Form
    {
        /// <summary>
        /// Созданная задача.
        /// </summary>
        public Task? CreatedTask { get; private set; }

        /// <summary>
        /// Инициализирует вторую форму приложения.
        /// </summary>
        public Form2()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent; 
            FormBorderStyle = FormBorderStyle.FixedDialog;  
            MaximizeBox = false;
            MinimizeBox = false;

            textBox1.Text = "";
            textBox1.PlaceholderText = "Введите заголовок задачи...";
            textBox2.Text = "";
            textBox2.PlaceholderText = "Введите описание задачи...";

            button1.DialogResult = DialogResult.Cancel; 
            CancelButton = button1;                     

            button2.Click += button2_Click;             
        }

        /// <summary>
        /// Кнопка «Создать».
        /// </summary>
        /// /// <param name="sender">Кнопка, вызвавшая обработчик.</param>
        /// <param name="e">Данные о событии нажатия кнопки.</param>
        private void button2_Click(object? sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show(
                    "Введите заголовок задачи.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox1.Focus();
                return;           
            }

            CreatedTask = new Task
            {
                Title = title,
                Description = textBox2.Text.Trim()
            };

            DialogResult = DialogResult.OK;
        }
    }
}