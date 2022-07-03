using System;

namespace KisiBilgileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IdentityCard identityCard = new IdentityCard() // Burada Kimlikten bir örnek oluşturduk ve atamalarını gerçekleştirdik
            {
                Id = 1,
                IdentityNumber = "12345678910",
                FirstName = "Musa",
                LastName = "Uyumaz",
                DateOfBirth = DateTime.Parse("14/02/1999"),
                CardDateOfIssue = DateTime.Parse("20/01/2017"),
                Nationality = "T.C",
                Gender = "E",
                IssuedBy = "T.C İÇİŞLERİ BAKANLIĞI",

            };
            DrivingLicence drivingLicence = new DrivingLicence() // Burada Ehliyetten bir örnek oluşturduk ve atamalarını gerçekleştirdik
            {
                Id = 2,
                IdentityNumber = "12345678910",
                FirstName = "Musa",
                LastName = "Uyumaz",
                DateOfBirth = DateTime.Parse("14/02/1999"),
                CardDateOfIssue = DateTime.Parse("20/01/2017"),
                BloodGroup = "A+",
                LicenceNumber = "12345",
                PlaceOfBirth = "Eskişehir",
            };
            Console.WriteLine("************* Kimlik *************");
            identityCard.WriteCardInformation();

            Console.WriteLine("************* Ehliyet *************");
            drivingLicence.WriteCardInformation();
        }

    }
}
