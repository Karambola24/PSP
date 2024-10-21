using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using PSP.Controller;
using PSP.View;
using PSP.Model;


namespace PSP
{
     public partial class Form1 : Form
    {
        private DatabaseHelper db;  // Экземпляр класса для работы с базой данных

        public Form1()
        {
            InitializeComponent();
            db = new DatabaseHelper();  // Инициализация DatabaseHelper
        }

        // Обработчик нажатия кнопки "Показать студентов"
        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            List<Student> students = db.GetAllStudents();  // Получаем список студентов из базы данных

            // Открываем новую форму и передаем ей список студентов
            FormStudents formStudents = new FormStudents(students);
            formStudents.Show();  // Открываем новую форму
        }

        private void btnShowDisciplines_Click(object sender, EventArgs e)
        {
            List<Discipline> disciplines = db.GetAllDisciplines();  // Получаем список студентов из базы данных
            // Открываем новую форму и передаем ей список студентов
            FormDisciplines formDisciplines = new FormDisciplines(disciplines);
            formDisciplines.Show();  // Открываем новую форму
        }
    }
}
