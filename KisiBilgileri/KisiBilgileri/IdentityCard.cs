using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiBilgileri
{
    public class IdentityCard : Card //Bu sınıfta sadece kimliğe özel özellikleri tuttum ve Card sınıfından kalıtım alarak Card sınıfının özelliklerinide kullanır hale geldim
    {
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public string IssuedBy { get; set; }
    }
}
