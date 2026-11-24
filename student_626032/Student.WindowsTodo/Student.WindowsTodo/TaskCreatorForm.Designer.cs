namespace Student.WindowsTodo
{
    partial class TaskCreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bCancel = new Button();
            bCreateTask = new Button();
            tbTaskTitle = new TextBox();
            label2 = new Label();
            tbTaskDescription = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            bCancel.Location = new Point(514, 374);
            bCancel.Name = "button1";
            bCancel.Size = new Size(134, 49);
            bCancel.TabIndex = 0;
            bCancel.Text = "Отмена";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            bCreateTask.Location = new Point(654, 374);
            bCreateTask.Name = "button2";
            bCreateTask.Size = new Size(134, 49);
            bCreateTask.TabIndex = 1;
            bCreateTask.Text = "Создать";
            bCreateTask.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            tbTaskTitle.Location = new Point(22, 59);
            tbTaskTitle.Multiline = true;
            tbTaskTitle.Name = "textBox1";
            tbTaskTitle.Size = new Size(749, 41);
            tbTaskTitle.TabIndex = 5;
            tbTaskTitle.Text = "Введите заголовок задачи...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 118);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 6;
            label2.Text = "Описание задачи:";
            // 
            // textBox2
            // 
            tbTaskDescription.Location = new Point(22, 155);
            tbTaskDescription.Multiline = true;
            tbTaskDescription.Name = "textBox2";
            tbTaskDescription.Size = new Size(749, 195);
            tbTaskDescription.TabIndex = 7;
            tbTaskDescription.Text = "Введите описание задачи...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 8;
            label1.Text = "Текст задачи:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 443);
            Controls.Add(label1);
            Controls.Add(tbTaskDescription);
            Controls.Add(label2);
            Controls.Add(tbTaskTitle);
            Controls.Add(bCreateTask);
            Controls.Add(bCancel);
            Name = "Form2";
            Text = "Новая задача";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bCancel;
        private Button bCreateTask;
        private TextBox tbTaskTitle;
        private Label label2;
        private TextBox tbTaskDescription;
        private Label label1;
    }
}