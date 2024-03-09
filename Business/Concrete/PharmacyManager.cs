using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PharmacyManager : ISupplierService //Buradaki GiveMask metodunun içerisi eczanenin iş mantığına göre düznelenmelidir. Ptt KPS Servisten doğrulama yaparken
                                                    //eczane bu işlemi Medula üzerinden yapabilir. Veya Ptt adrese gönderim yaparken eczaneye gidilerek maske alınması gibi
                                                    //bir süreç olabilir.
                                                    //SOLID Open-Close Principle --> Yeni bir özellik geldiğinde eski kodlara dokunmaman gerekiyor. Dokunmak zorunda kalıyorsan
                                                    //bu prensibi uygulayamamışsın demektir.
    {
        public void GiveMask(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
