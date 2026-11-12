namespace Student.WindowsTodo
{
    public partial class Form3 : Form
    {
        /// <param name="taskTitle">Заголовок удаляемой задачи — покажем его в вопросе.</param>
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

            CancelButton = button1; // Esc = отмена
        }
    }
}