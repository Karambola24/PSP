
namespace PSP.View
{
    partial class FormAddStudent
    {
        // Объявление компонентов формы
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.NumericUpDown numericUpDownCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownSemester;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblGroup;

        // Освобождение ресурсов
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Инициализация компонентов формы
        private void InitializeComponent()
        {
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.numericUpDownCourse = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSemester = new System.Windows.Forms.NumericUpDown();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(112, 24);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(151, 20);
            this.txtFullName.TabIndex = 0;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(112, 57);
            this.txtMajor.Margin = new System.Windows.Forms.Padding(2);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(151, 20);
            this.txtMajor.TabIndex = 1;
            // 
            // numericUpDownCourse
            // 
            this.numericUpDownCourse.Location = new System.Drawing.Point(112, 89);
            this.numericUpDownCourse.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCourse.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownCourse.TabIndex = 2;
            this.numericUpDownCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSemester
            // 
            this.numericUpDownSemester.Location = new System.Drawing.Point(112, 122);
            this.numericUpDownSemester.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownSemester.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSemester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSemester.Name = "numericUpDownSemester";
            this.numericUpDownSemester.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownSemester.TabIndex = 3;
            this.numericUpDownSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(112, 154);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(2);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(151, 20);
            this.txtGroup.TabIndex = 4;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(112, 195);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(65, 24);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Text = "Добавить";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(198, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 24);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(37, 13);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "ФИО:";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(20, 57);
            this.lblMajor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(88, 13);
            this.lblMajor.TabIndex = 8;
            this.lblMajor.Text = "Специальность:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(20, 91);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(34, 13);
            this.lblCourse.TabIndex = 9;
            this.lblCourse.Text = "Курс:";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(20, 124);
            this.lblSemester.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(54, 13);
            this.lblSemester.TabIndex = 10;
            this.lblSemester.Text = "Семестр:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(20, 154);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(45, 13);
            this.lblGroup.TabIndex = 11;
            this.lblGroup.Text = "Группа:";
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 244);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.numericUpDownSemester);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddStudent";
            this.Text = "Добавить студента";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
