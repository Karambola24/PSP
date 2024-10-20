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
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            List<Student> sortedStudents = db.GetStudentsSortedBy("Full_name");  // Сортировка по имени
            dataGridViewStudents.DataSource = sortedStudents;  // Обновление отображения
        }
    }
}
