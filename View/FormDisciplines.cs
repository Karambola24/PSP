using PSP.Controller;
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

namespace PSP.View
{
    public partial class FormDisciplines : Form
    {
        private DatabaseHelper db;
        public FormDisciplines(List<Discipline> disciplines)
        {
            InitializeComponent();
            db = new DatabaseHelper();  // Инициализация контроллера
            dataGridViewDisciplines.DataSource = disciplines; // Отображение студентов
        }

       
    }
}
