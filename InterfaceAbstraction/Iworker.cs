using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction
{
    // İsim, Soyisim, Depertman ve Görev metodu bilgileri soyut ve ortak olduğu için interface kullanıyoruz.
    public interface Iworker
    {
        //Propertleri tanımlıyoruz.
        string Name { get; set; }
        string Surname { get; set; }
        string Department { get; set; }
        public void Duty();
    }
}