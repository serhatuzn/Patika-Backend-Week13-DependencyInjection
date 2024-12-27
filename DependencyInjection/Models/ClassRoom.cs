using DependencyInjection.Interface;

namespace DependencyInjection.Models
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }
        public string GetInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
