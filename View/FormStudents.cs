using PSP.Model;
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
    public partial class FormStudents : Form

    {
        private DatabaseHelper db;
        public FormStudents(List<Student> students)
        {
            InitializeComponent();
            db = new DatabaseHelper();  // Инициализация контроллера
            dataGridViewStudents.DataSource = students; // Отображение студентов
            comboBoxSortBy.Items.Add("Full_name");
            comboBoxSortBy.Items.Add("Course");
            comboBoxSortBy.Items.Add("Semester");
            comboBoxSortBy.Items.Add("Major");
            comboBoxSortBy.Items.Add("Group_name");
            comboBoxSortBy.SelectedIndex = 0;  // Установим начальный элемент
        }


        private void btnSort_Click(object sender, EventArgs e)
        {
            string selectedSortBy = comboBoxSortBy.SelectedItem.ToString();

            // Выполняем сортировку
            List<Student> sortedStudents = db.GetStudentsSortedBy(selectedSortBy);

            // Обновляем DataGridView с отсортированными студентами
            dataGridViewStudents.DataSource = sortedStudents;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Создаем и открываем форму добавления студента
            FormAddStudent formAddStudent = new FormAddStudent();
            formAddStudent.ShowDialog(); // Используем ShowDialog для модального окна
        }

        
    }
}
