using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService; //constructordan ulaşmak için

        //ihtiyac duyulan sınıfı newlemek yerine onun interfacı yazılır
        //mikro servis implementesi.
        public PttManager(IApplicantService applicantService) {
            //constructor new yapılınca çalışır.
            _applicantService = applicantService; //fieldların alt çizgiyle baslama sebebi.
        }



        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");
            }
        }
    }
}
