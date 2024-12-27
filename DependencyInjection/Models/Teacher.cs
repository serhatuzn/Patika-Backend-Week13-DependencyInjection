using DependencyInjection.Interface;

namespace DependencyInjection.Models
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
