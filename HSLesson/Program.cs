using HSLesson.Data.Access;
using HSLesson.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HSLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SubjectsStudents> result;
            using(var context = new HighContext())
            {
                #region заполнение таблиц
                //var mentor = new Mentor
                //{
                //    FullName = "Колтыкшашев Кайрат",
                //    Stage = 13
                //};

                //var math = new Subject
                //{
                //    SubjectName = "Математика",
                //    Mentor = mentor
                //};

                //var english = new Subject
                //{
                //    SubjectName = "Английский язык",
                //    Mentor = mentor
                //};

                //var firstStudent = new Student
                //{
                //    FullName = "Скидан Олег Сергеевич",
                //    GroupName = "SEP-182",
                //};

                //var secondStudent = new Student
                //{
                //    FullName = "Сагадиев Ернар Габитович",
                //    GroupName = "SEP-182",
                //};

                //var firstSubjectStudent = new SubjectsStudents
                //{
                //    Subject = math,
                //    Student = firstStudent,
                //};

                //var secondSubjectStudent = new SubjectsStudents
                //{
                //    Subject = english,
                //    Student = firstStudent,
                //};

                //var thirdSubjectStudent = new SubjectsStudents
                //{
                //    Subject = math,
                //    Student = secondStudent,
                //};

                //var fourthSubjectStudent = new SubjectsStudents
                //{
                //    Subject = english,
                //    Student = secondStudent,
                //};

                //context.Add(mentor);
                //context.Add(firstStudent);
                //context.Add(secondStudent);
                //context.Add(math);
                //context.Add(english);
                //context.Add(firstSubjectStudent);
                //context.Add(secondSubjectStudent);
                //context.Add(thirdSubjectStudent);
                //context.Add(fourthSubjectStudent);
                #endregion

                // 3 типа загрузки:
                // Eager, Explicit, Lazy (жадная, явная, ленивая)
                // Жадная - помимо требуемой сущности скачивается все связи через Include (включить в)
                // Явная - скачивает явную конкретную зависимость для сущности (одну или набор)
                // Ленивая - заранее дает возможность в случае необходимости сделать доп запрос в рамках одного контекста

                //var result = context.SubjectsStudents.Include(x => x.Student).ToList(); // Жадная
                //var result = context.SubjectsStudents.Include(x => x.Student).Include(x => x.Subject).ToList(); // Жадная => загрузка студента и сабджекта
                //var result = context.SubjectsStudents.Include(x => x.Student).Include(x => x.Subject).ThenInclude(s => s.Mentor).ToList(); // Жадная => получение элементов каждого студента/сабджекта

                //var result = context.SubjectsStudents.ToList(); // Явная, первый запрос
                //context.Entry(result.FirstOrDefault()).Reference(x => x.Student).Load(); // это Второй запрос
                //foreach(var res in result)
                //{
                //    Console.WriteLine($"Name: {res.Student.FullName}");
                //}

                result = context.SubjectsStudents.ToList(); // Ленивая
                Console.WriteLine(result.FirstOrDefault().Student.FullName); // Иожно получить значения в текущем контексте
            }
        }
    }
}
