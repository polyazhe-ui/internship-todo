using Task = Student.WindowsTodo.Task;

namespace Student.WindowsTodo
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Созданная задача. Form1 заберёт её после закрытия окна.
        /// </summary>
        public Task? CreatedTask { get; private set; }

        public Form2()
        {
            InitializeComponent();

            // Внешний вид окна-диалога.
            StartPosition = FormStartPosition.CenterParent; // по центру Form1
            FormBorderStyle = FormBorderStyle.FixedDialog;  // нельзя растягивать
            MaximizeBox = false;
            MinimizeBox = false;

            // Подсказки вместо «настоящего» текста.
            textBox1.Text = "";
            textBox1.PlaceholderText = "Введите заголовок задачи...";
            textBox2.Text = "";
            textBox2.PlaceholderText = "Введите описание задачи...";

            // Кнопки.
            button1.DialogResult = DialogResult.Cancel; // «Отмена» просто закрывает окно
            CancelButton = button1;                     // Esc = «Отмена»

            button2.Click += button2_Click;             // «Создать» — сначала проверка
        }

        /// <summary>
        /// Кнопка «Создать».
        /// </summary>
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

                textBox1.Focus(); // ставим курсор в поле заголовка
                return;           // окно НЕ закрывается
            }

            CreatedTask = new Task
            {
                Title = title,
                Description = textBox2.Text.Trim()
            };

            // Если у модальной формы задать DialogResult, она сразу закрывается,
            // а ShowDialog() в Form1 вернёт это значение.
            DialogResult = DialogResult.OK;
        }
    }
}