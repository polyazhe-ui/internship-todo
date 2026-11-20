namespace Student.WindowsTodo
{
    /// <summary>
    /// Третья форма для подтверждения удаления задачи.
    /// </summary>
    public partial class DeleteForm : Form
    {
        /// <summary>
        /// Инициализирует третью форму приложения.
        /// </summary>
        /// <param> name="taskTitle">Заголовок задачи для удаления.</param>
        public DeleteForm(string taskTitle)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            confirmDeletionLabel.Visible = true;
            confirmDeletionLabel.Text = $"Вы действительно хотите удалить задачу «{taskTitle}»?";

            bCancelDeletion.Text = "Отмена";
            bCancelDeletion.DialogResult = DialogResult.Cancel;

            bDelete.Text = "Удалить";
            bDelete.DialogResult = DialogResult.OK;

        }
    }
}