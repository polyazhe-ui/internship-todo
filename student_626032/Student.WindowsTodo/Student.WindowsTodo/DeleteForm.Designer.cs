namespace Student.WindowsTodo
{
    partial class DeleteForm
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
            bCancelDeletion = new Button();
            bDelete = new Button();
            confirmDeletionLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            bCancelDeletion.Location = new Point(147, 103);
            bCancelDeletion.Name = "button1";
            bCancelDeletion.Size = new Size(109, 39);
            bCancelDeletion.TabIndex = 0;
            bCancelDeletion.Text = "Отмена";
            bCancelDeletion.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            bDelete.Location = new Point(262, 103);
            bDelete.Name = "button2";
            bDelete.Size = new Size(109, 39);
            bDelete.TabIndex = 1;
            bDelete.Text = "Создать";
            bDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            confirmDeletionLabel.Font = new Font("Segoe UI", 12F);
            confirmDeletionLabel.Location = new Point(12, 20);
            confirmDeletionLabel.Name = "label1";
            confirmDeletionLabel.Size = new Size(359, 70);
            confirmDeletionLabel.TabIndex = 2;
            confirmDeletionLabel.Text = "Вы действительно хотите удалить задачу? Если да, то нажмите кнопку \"Удалить\", иначе нажмите \"Отмена\". ";
            confirmDeletionLabel.UseMnemonic = false;
            confirmDeletionLabel.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 154);
            Controls.Add(confirmDeletionLabel);
            Controls.Add(bDelete);
            Controls.Add(bCancelDeletion);
            Name = "Form3";
            Text = "Удалить задачу";
            ResumeLayout(false);
        }

        #endregion

        private Button bCancelDeletion;
        private Button bDelete;
        private Label confirmDeletionLabel;
    }
}