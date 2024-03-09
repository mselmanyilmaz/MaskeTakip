using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        //Çıplak (Kalıtım almamış) class kalmasın...
        public void ApplyForMask(Person person) //Metoda bir nesne vererek parametre geçişinin sağlanması işlemine Encapsulation denir.
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person) 
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;

            
        }
    }
}
