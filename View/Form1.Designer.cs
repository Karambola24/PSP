namespace PSP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnShowDisciplines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(12, 105);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(175, 23);
            this.btnShowStudents.TabIndex = 0;
            this.btnShowStudents.Text = "Вывести список студентов";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // btnShowDisciplines
            // 
            this.btnShowDisciplines.Location = new System.Drawing.Point(269, 105);
            this.btnShowDisciplines.Name = "btnShowDisciplines";
            this.btnShowDisciplines.Size = new System.Drawing.Size(236, 23);
            this.btnShowDisciplines.TabIndex = 1;
            this.btnShowDisciplines.Text = "Показать список дисциплин";
            this.btnShowDisciplines.UseVisualStyleBackColor = true;
            this.btnShowDisciplines.Click += new System.EventHandler(this.btnShowDisciplines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowDisciplines);
            this.Controls.Add(this.btnShowStudents);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnShowDisciplines;
    }
}

