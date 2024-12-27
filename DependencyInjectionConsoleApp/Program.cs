using DependencyInjectionConsoleApp;

var teacher = new Teacher { FirstName = "Serhat", LastName = "Uzun" };

var classRoom = new ClassRoom(teacher);
Console.WriteLine("Öğretmen Bilgileri");
classRoom.GetInfo();