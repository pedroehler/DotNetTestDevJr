using System.Collections.Generic;
using TestDotNetVrSystem.HelpClasses;

namespace TestDotNetVrSystem
{
    public class Task4
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informções dos Students
         */
        public static List<Student> GetStudentsByBirth()
        {
            var repository = new Repository();
            List<Student> students = new List<Student>();

            foreach (var item in repository.Students)
            {
                if (item.Birth.Year == 2020)
                {
                    students.Add(item);
                }
            }

            return students;
        }
    }
}
