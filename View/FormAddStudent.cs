using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSP.Controller;
namespace PSP.View
{
    public partial class FormAddStudent : Form
    {
        private StudentController studentController;

        public FormAddStudent()
        {
            InitializeComponent();
            studentController = new StudentController();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Получаем введенные данные
            string fullName = txtFullName.Text.Trim();
            string major = txtMajor.Text.Trim();
            string course = numericUpDownCourse.Value.ToString();
            string semester = numericUpDownSemester.Value.ToString();
            string group = txtGroup.Text.Trim();

            // Вызываем метод контроллера для валидации и добавления студента
            string resultMessage = studentController.ValidateAndAddStudent(fullName, major, course, semester, group);

            // Выводим результат
            MessageBox.Show(resultMessage, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFormFields();
        }
        private void ClearFormFields()
        {
            txtFullName.Clear();
            txtMajor.Clear();
            numericUpDownCourse.Value = 1;
            numericUpDownSemester.Value = 1;
            txtGroup.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
