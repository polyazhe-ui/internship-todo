namespace Student.WindowsTodo
{
    /// <summary>
    /// Третья форма для подтверждения удаления задачи.
    /// </summar
    public partial class Form3 : Form
    {
        /// <summary>
        /// Инициализирует третью форму приложения.
        /// </summary>
        /// <param name="taskTitle">Заголовок задачи для удаления.</param>
        public Form3(string taskTitle)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            label1.Visible = true;
            label1.Text = $"Вы действительно хотите удалить задачу «{taskTitle}»?";

            button1.Text = "Отмена";
            button1.DialogResult = DialogResult.Cancel;

            button2.Text = "Удалить";
            button2.DialogResult = DialogResult.OK;

        }
    }
}