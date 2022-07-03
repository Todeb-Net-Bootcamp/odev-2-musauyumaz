using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiBilgileri
{
    public abstract class Card  //Günlük hayatta bolca kullandığımız ehliyet ve kimliklerimizin ortak özelliklerini bir sınıfta topladım
    {//Bu sınıfı abstract class haline getirdim çünkü bu sınıftan türetilen nesne benim hiç bir işime yaramayacak bu yüzden bu sınıfta ehliyet ve kimlikteki ortak özellikleri tuttum ve kod tekrarından kaçındım gerçek hayatta sadece kimlik ve ehliyet nesnelerinin birer somut örneği vardır card nesnesinin bir örneği oluşturulamaz
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CardDateOfIssue { get; set; }
        public DateTime CardExpireDate
        {
            get
            { return CardDateOfIssue.AddYears(10); }//burada sadece get methodunu kullandım çünkü Son kullanma tarihi alınan tarihin 10 yıl sonrası olarak ayarlanır nu yüzden herhangi set'lenme işlemini kullanıcıya yaptırmak istemedim
        }


        public virtual void WriteCardInformation()
        {
            Console.WriteLine("Identity Number : {0} \n First Name : {1} \n Last Name : {2} \n BirthDate : {3} \n Card Expired Date : {4} \n", IdentityNumber, FirstName, LastName, DateOfBirth, CardExpireDate);
        }
    }
}
