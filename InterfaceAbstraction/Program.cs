//Çalışan örneklerini oluşturuyoruz.
using InterfaceAbstraction;

Iworker softwareDeveloper = new SoftwareDeveloper
{
    Name = "Şükra",
    Surname = "Kayhan",
    Department = "Yazılım Geliştirme"
};

Iworker projectManager = new ProjectManager
{
    Name = "ayse",
    Surname = "yılmaz",
    Department = "Proje Yönetimi"
};

Iworker salesRepresentative = new SalesRepresentative
{
    Name = "ceren",
    Surname = "korkmaz",
    Department = "Satış Danışmanı"
};

//Görevleri çağırma
Console.WriteLine($"{softwareDeveloper.Name} {softwareDeveloper.Surname}: ");
softwareDeveloper.Duty();

Console.WriteLine($"{projectManager.Name} {projectManager.Surname}: ");
projectManager.Duty();

Console.WriteLine($"{salesRepresentative.Name} {salesRepresentative.Surname}: ");
salesRepresentative.Duty();