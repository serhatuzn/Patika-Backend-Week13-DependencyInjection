
# Dependency Injection Pratiği - Öğretmen ve Sınıf Yönetimi 📚

Bu proje, **Dependency Injection** (DI) tasarım deseni ile yazılmış bir öğretmen ve sınıf yönetimi uygulamasıdır. Öğretmen bilgileri ve sınıf işlemleri DI kullanılarak yönetilmektedir.

## 🚀 Başlangıç

Projeyi çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

### 1. Projeyi Klonlayın

Projeyi bilgisayarınıza klonlamak için terminal veya komut istemcisinde şu komutu çalıştırın:
```bash
git clone https://github.com/kullanici-adi/proje-adi.git
```

### 2. .NET SDK'yı Yükleyin

Projenin çalışabilmesi için .NET SDK'nın yüklü olması gerekmektedir. Eğer yüklü değilse, [dotnet.microsoft.com](https://dotnet.microsoft.com/download) üzerinden en güncel sürümü indirebilirsiniz.

### 3. Projeyi Çalıştırın

Projeyi çalıştırmak için aşağıdaki komutları sırasıyla kullanabilirsiniz:
```bash
cd DependencyInjectionConsoleApp
dotnet run
```

Bu komut, öğretmen bilgilerini alacak ve konsola yazdıracaktır.

## 🛠️ Teknolojiler

- **C#**: Uygulama dili
- **.NET 6/7**: Uygulamanın çalıştığı platform
- **Dependency Injection**: Bileşenlerin bağımlılıklarını dışarıdan enjekte etme tasarım deseni

## 📁 Proje Yapısı

```
/DependencyInjectionConsoleApp
├── /DependencyInjectionConsoleApp
│   ├── ClassRoom.cs          # Sınıf ve Öğretmen ilişkisi
│   ├── Teacher.cs            # Teacher sınıfı ve ITeacher arayüzü
│   └── Program.cs            # Ana çalışma dosyası
└── README.md                 # Proje açıklaması (bu dosya)
```

## 📝 Kod Açıklamaları

### Teacher.cs

`Teacher.cs` dosyasında öğretmen bilgilerini tutan bir sınıf (`Teacher`) ve öğretmenin bilgilerini döndüren bir arayüz (`ITeacher`) bulunmaktadır.

```csharp
namespace DependencyInjectionConsoleApp
{
    public interface ITeacher
    {
        string GetInfo();
    }

    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            return $"Öğretmen: {FirstName} {LastName}";
        }
    }
}
```

- **Teacher** sınıfı, öğretmenin adını ve soyadını tutar ve `GetInfo()` metodu ile öğretmenin bilgilerini döndürür.
- **ITeacher** arayüzü, öğretmen bilgilerini almak için bir metod (`GetInfo()`) tanımlar.

### ClassRoom.cs

`ClassRoom.cs` dosyasında, öğretmen bilgisini almak ve bu bilgiyi yazdırmak için bir sınıf bulunmaktadır. Öğretmen bilgisi, DI kullanılarak sınıfa aktarılmaktadır.

```csharp
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
```

- **ClassRoom** sınıfı, `ITeacher` arayüzünü kullanarak öğretmen bilgisini alır.
- `GetInfo()` metodu, öğretmenin bilgilerini konsola yazdırır.

### Program.cs

`Program.cs` dosyasında, öğretmen nesnesi oluşturulur ve DI kullanılarak sınıfa aktarılır.

```csharp
using DependencyInjectionConsoleApp;

var teacher = new Teacher { FirstName = "Serhat", LastName = "Uzun" };
var classRoom = new ClassRoom(teacher);

Console.WriteLine("Öğretmen Bilgileri:");
classRoom.GetInfo();
```

- **Program.cs** dosyası, öğretmen nesnesini oluşturur ve sınıfa DI yoluyla aktarır. Ardından, sınıf üzerinden öğretmen bilgisini alır ve yazdırır.

## 🌟 Katkıda Bulunma

Projeye katkıda bulunmak için şu adımları izleyebilirsiniz:

1. Fork işlemi yapın.
2. Yeni bir branş oluşturun (`git checkout -b feature/ÖzellikAdı`).
3. Yapmak istediğiniz değişiklikleri gerçekleştirin.
4. Değişikliklerinizi commit'leyin (`git commit -am 'Yeni özellik eklendi'`).
5. Branşı GitHub'da push'layın (`git push origin feature/ÖzellikAdı`).
6. Bir pull request açın.

## 📑 Lisans

Bu proje, MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için [LICENSE](LICENSE) dosyasına göz atabilirsiniz.

---

Projeye katkı sağlamak isterseniz, pull request gönderebilirsiniz! 😊
