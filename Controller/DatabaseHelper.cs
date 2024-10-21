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



        public List<Discipline> GetAllDisciplines()
        {
            List<Discipline> disciplines = new List<Discipline>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Открываем соединение с базой данных

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Discipline", conn);  // Запрос на получение всех студентов
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Добавляем каждую дисциплину в список
                        disciplines.Add(new Discipline
                        {
                            ID_Discipline = (int)reader["ID_Discipline"],
                            Name = reader["Name"].ToString(),
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine("Ошибка при получении данных дисциплин: " + ex.Message);
                }
            }

            return disciplines;
        }


        public List<Discipline> GetDisciplinesSortedBy(string sortBy)
        {
            List<Discipline> disciplines = new List<Discipline>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Открываем соединение с базой данных

                    // Динамическая сортировка по полю, переданному в параметр sortBy
                    string query = $"SELECT * FROM Discipline ORDER BY {sortBy}";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Добавляем отсортированные дисциплины в список
                        disciplines.Add(new Discipline
                        {
                            ID_Discipline = (int)reader["ID_Discipline"],
                            Name = reader["Name"].ToString(),
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine("Ошибка при получении данных дисциплин: " + ex.Message);
                }
            }

            return disciplines;  // Возвращаем список студентов с примененной сортировкой
        }

        public List<Grade> GetAllGrades()
        {
            List<Grade> grades = new List<Grade>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Открываем соединение с базой данных

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Grade", conn);  // Запрос на получение всех студентов
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Добавляем каждую оценку в список
                        grades.Add(new Grade
                        {
                            ID_Grade = (int)reader["ID_Grade"],
                            ID_Student = (int)reader["ID_Student"],
                            GradeValue = (int)reader["Grade"],
                            ID_Discipline = (int)reader["ID_Dicsipline"],
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine("Ошибка при получении данных оценок: " + ex.Message);
                }
            }

            return grades;
        }

        public List<Grade> GetGradesSortedBy(string sortBy)
        {
            List<Grade> grades = new List<Grade>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Открываем соединение с базой данных

                    // Динамическая сортировка по полю, переданному в параметр sortBy
                    string query = $"SELECT * FROM Grade ORDER BY {sortBy}";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Добавляем отсортированные оценки в список
                        grades.Add(new Grade
                        {
                            ID_Grade = (int)reader["ID_Grade"],
                            ID_Student = (int)reader["ID_Student"],
                            GradeValue = (int)reader["Grade"],
                            ID_Discipline = (int)reader["ID_Dicsipline"],
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine("Ошибка при получении данных оценок: " + ex.Message);
                }
            }

            return grades;  // Возвращаем список оценок с примененной сортировкой
        }

        // Метод для добавления нового студента в базу данных
        public bool AddStudent(Student newStudent)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Student (Full_name, Major, Course, Semester, Group_name) " +
                                   "VALUES (@Full_name, @Major, @Course, @Semester, @Group_name)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Добавляем параметры для вставки данных
                    cmd.Parameters.AddWithValue("@Full_name", newStudent.Full_name);
                    cmd.Parameters.AddWithValue("@Major", newStudent.Major);
                    cmd.Parameters.AddWithValue("@Course", newStudent.Course);
                    cmd.Parameters.AddWithValue("@Semester", newStudent.Semester);
                    cmd.Parameters.AddWithValue("@Group_name", newStudent.Group_name);

                    int rowsAffected = cmd.ExecuteNonQuery(); // Выполнение запроса

                    // Если добавлена хотя бы одна строка, возвращаем true
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine("Ошибка при добавлении студента: " + ex.Message);
                    return false;
                }
            }

        }
    }
}