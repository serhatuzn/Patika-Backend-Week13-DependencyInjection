using DependencyInjection.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using DependencyInjection.Interface;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public TeacherController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet]
        public IActionResult GetTeacher()
        {
            var classRoom = new ClassRoom(_teacher);
            classRoom.StartClass();

            return Ok();
        }

        [HttpPost]
        public IActionResult AddGet(Teacher teacher)
        {
            if (teacher == null)
                return BadRequest("Öğremtne Bilgileri eksik");

            var classRoom = new ClassRoom(teacher); // Gelen Öğretmeni 
            classRoom.StartClass(); // Sınıfı Başlatıyoruz

            return Ok(new { Message = "Sınıf Başarıyla Başlatıldı", Teacher = teacher });
        }
    }
}
