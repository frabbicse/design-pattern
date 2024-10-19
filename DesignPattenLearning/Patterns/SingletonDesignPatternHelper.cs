using SingletonDesignPattern;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenLearning.Patterns
{
    public class SingletonDesignPatternHelper
    {
        public static void GetOutput()
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
                );
        }
        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
