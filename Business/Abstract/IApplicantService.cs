using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService //İş sınıflarının interface leri genelde bu şekilde isimlendirilir.
    {
        public void ApplyForMask(Person person); //Metoda bir nesne vererek parametre geçişinin sağlanması işlemine Encapsulation denir.

        public List<Person> GetList();

        public bool CheckPerson(Person person);
    }
}
