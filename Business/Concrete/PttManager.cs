using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager /*: ISupplierService*/
    {
        IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            //Bir iş veya dal sınıfı başka bir sınıfı new lerse bu uygulama ileride değişikliğe karşı direnç gösterir. new
            //lediği sınıfa olan bağımlılığından dolayı. Bu sistem doğru bir sistem değildir... Yapılması gereken Dependency Injection tasarım desenini kullanmaktır.
            //PersonManager personManager = new PersonManager(); 

            //if (personManager.CheckPerson(person))
            //{
            //    Console.WriteLine(person.FirstName + " için maske verildi...");
            //}

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi...");
            }
        }
    }
}
