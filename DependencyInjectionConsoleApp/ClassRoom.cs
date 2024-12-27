using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConsoleApp
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }
        public void GetInfo()
        {
            Console.WriteLine(_teacher.GetInfo());
        }
    }
}