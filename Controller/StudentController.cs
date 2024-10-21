using PSP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PSP.Controller
{
    public class StudentController
    {
        private DatabaseHelper db;

        public StudentController()
        {
            db = new DatabaseHelper();
        }

        // Метод для валидации и добавления нового студента
        public string ValidateAndAddStudent(string fullName, string major, string courseStr, string semesterStr, string groupName)
        {
            try
            {
                // Регулярное выражение для валидации имени (только буквы и пробелы)
                if (!Regex.IsMatch(fullName, @"^[a-zA-Zа-яА-Я\s-]+$"))
                {
                    return "Имя должно содержать только буквы и пробелы.";
                }

                // Проверка специальности на пустоту
                if (string.IsNullOrEmpty(major))
                {
                    return "Специальность не может быть пустой.";
                }

                if (!Regex.IsMatch(major, @"^[a-zA-Zа-яА-Я\s-]+$"))
                {
                    return "Специальность должно содержать только буквы и пробелы.";
                }

                // Проверка на числовые значения для курса и семестра
                if (!int.TryParse(courseStr, out int course) || course < 1 || course > 6)
                {
                    return "Курс должен быть числом от 1 до 6.";
                }

                if (!int.TryParse(semesterStr, out int semester) || semester < 1  || semester > 2)
                {
                    return "Семестр должен быть числом (1 или 2).";
                }

                // Проверка группы на пустоту
                if (string.IsNullOrEmpty(groupName))
                {
                    return "Группа не может быть пустой.";
                }

                // Создаем объект студента
                Student newStudent = new Student
                {
                    Full_name = fullName,
                    Major = major,
                    Course = course,
                    Semester = semester,
                    Group_name = groupName
                };

                // Добавляем студента в базу данных через модель
                bool isSuccess = db.AddStudent(newStudent);

                if (isSuccess)
                {
                    return "Студент успешно добавлен.";
                }
                else
                {
                    return "Произошла ошибка при добавлении студента.";
                }
            }
            catch (Exception ex)
            {
                return "Произошла ошибка: " + ex.Message;
            }
        }
    }
}
