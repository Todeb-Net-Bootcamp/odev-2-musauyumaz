using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiBilgileri
{
    public class DrivingLicence : Card//Bu sınıfta sadece Ehliyete özel özellikleri tuttum ve Card sınıfından kalıtım alarak Card sınıfının özelliklerinide kullanır hale geldim
    {
        public string LicenceNumber { get; set; }
        public string PlaceOfBirth { get; set; }
        public string BloodGroup { get; set; }

        public override void WriteCardInformation()//Card Sınıfındaki methodu bu sınıfta ezerek yani yeniden içini doldurarak ehliyete göre ayarladım
        {
            Console.WriteLine("Identity Number : {0} \n First Name : {1} \n Last Name : {2} \n Date Of Birth : {3}  Place Of Birth : {4}\n Card Issue Date : {5} Card Expired Date : {6} \n Blood Group : {7} \n", base.IdentityNumber, base.FirstName, base.LastName, base.DateOfBirth, this.PlaceOfBirth, base.CardDateOfIssue, base.CardExpireDate, this.BloodGroup);
        }
    }
}
