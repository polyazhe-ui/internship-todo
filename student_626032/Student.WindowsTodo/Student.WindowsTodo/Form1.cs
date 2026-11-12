using Task = Student.Task;

namespace Student.WindowsTodo
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Список задач — то же самое, что было в Main() консольной версии.
        /// Теперь это поле формы, чтобы его видели все методы.
        /// </summary>
        private readonly List<Task> tasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();          // сначала создаём все элементы

            StartPosition = FormStartPosition.CenterScreen;
            SetupGrid();

            // Подписываем кнопку «Добавить задачу» на наш обработчик.
            button1.Click += button1_Click;
        }

        /// <summary>
        /// Настраивает внешний вид и поведение таблицы.
        /// </summary>
        private void SetupGrid()
        {
            dataGridView2.AllowUserToAddRows = false;    // убираем пустую строку внизу
            dataGridView2.AllowUserToDeleteRows = false; // запрещаем удаление клавишей Delete
            dataGridView2.ReadOnly = true;               // ячейки нельзя редактировать
            dataGridView2.RowHeadersVisible = false;     // убираем серый столбец слева
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;

            // Столбцы растягиваются на всю ширину таблицы в заданных пропорциях.
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Column1.FillWeight = 30;
            Column2.FillWeight = 55;
            Column3.FillWeight = 15;
        }

        /// <summary>
        /// Перерисовывает таблицу по списку задач (аналог WatchTaskList).
        /// </summary>
        private void RefreshGrid()
        {
            dataGridView2.Rows.Clear();

            foreach (Task t in tasks)
            {
                // Rows.Add принимает значения ячеек по порядку столбцов
                // и возвращает индекс новой строки.
                int rowIndex = dataGridView2.Rows.Add(t.Title, t.Description);

                // Tag — «карман» для любых своих данных.
                // Кладём туда саму задачу, чтобы потом точно знать, что удалять.
                dataGridView2.Rows[rowIndex].Tag = t;
            }
        }

        /// <summary>
        /// Кнопка «Добавить задачу» (аналог AddTask).
        /// </summary>
        private void button1_Click(object? sender, EventArgs e)
        {
            using (Form2 addForm = new Form2())
            {
                // ShowDialog открывает окно МОДАЛЬНО: код останавливается на этой строке,
                // пока Form2 не закроется, а Form1 в это время недоступна.
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