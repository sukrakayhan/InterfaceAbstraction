using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction
{
    //Yazılım geliştirici sınıfı oluşturup Çalışan interfaceini implemente ediyoruz.
    public class SoftwareDeveloper : Iworker
    {
        //Propertyleri tanımlıyoruz.
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        public void Duty()
        {
            Console.WriteLine("Yazılım geliştirici olarak çalışıyorum.");
        }
    }
}