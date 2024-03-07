using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    internal class ForeignerManager : IApplicantService
    {
        //SonarQube
        //Bİr yazılımda ne kadar çok if statement varsa kaliteden o kadar ödün verilmiştir denilebilir.
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
