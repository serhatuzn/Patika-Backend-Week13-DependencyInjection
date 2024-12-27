using System;
using DependencyInjectionConsoleApp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConsoleApp
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            return $"Öğretmen Adı : {FirstName} || Soyadı : {LastName}";
        }
    }
}
