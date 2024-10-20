using PSP.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PSP.Controller
{
    public class DatabaseHelper
    {
        private string connectionString;

        // Конструктор, который получает строку подключения к базе данных
        public DatabaseHelper()
        {
            // Замените строку подключения на вашу актуальную строку подключения
            connectionString = "Data Source=localhost;Initial Catalog=PSP;Integrated Security=True";
        }

        // Метод для получения списка студентов из базы данных
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Открываем соединение с базой данных

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Student", conn);  // Запрос на получение всех студентов
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Добавляем каждого студента в список
                        students.Add(new Student
                        {
                            ID_Student = (int)reader["ID_Student"],
                            Full_name = reader["Full_name"].ToString(),
                            Major = reader["Major"].ToString(),
                            Course = (int)reader["Course"],
                            Semester = (int)reader["Semester"],
                            Group_name = reader["Group_name"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine("Ошибка при получении данных студентов: " + ex.Message);
                }
            }

            return students;
        }

        public List<Student> GetStudentsSortedBy(string sortBy)
        {
            List<Student> students = new List<Student>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Открываем соединение с базой данных

                    // Динамическая сортировка по полю, переданному в параметр sortBy
                    string query = $"SELECT * FROM Student ORDER BY {sortBy}";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Добавляем отсортированных студентов в список
                        students.Add(new Student
                        {
                            ID_Student = (int)reader["ID_Student"],
                            Full_name = reader["Full_name"].ToString(),
                            Major = reader["Major"].ToString(),
                            Course = (int)reader["Course"],
                            Semester = (int)reader["Semester"],
                            Group_name = reader["Group_name"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine("Ошибка при получении данных студентов: " + ex.Message);
                }
            }

            return students;  // Возвращаем список студентов с примененной сортировкой
        }
    }
}
