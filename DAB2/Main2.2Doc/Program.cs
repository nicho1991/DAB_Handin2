using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAB2._2;
using DAB2._2.UnitOfWork;
using DocumentDB.Repository;
using DocumentDB;

namespace Main2._2Doc
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Setup
            //opret jesper
            var tlfJesper = new Telephone("88888888", "TeleDanmark", "Erhverv");
            var mailJesper = new Email("one@two-three.dk");
            var adr1 = new Adress("Ringvej", "7a", "8000", "Aarhus C");
            var adr2 = new Adress("Landmands vej", "1", "2900", "Hellerup");
            var personJesper = new Person(tlfJesper, adr1, "Jesper", "Jespersen", "Jes", "Mand", mailJesper);

            //giv jesper en alternativ adresse
            AltAdresse jesperAlternativ = new AltAdresse();
            jesperAlternativ.AlternativeAdress = adr2;
            jesperAlternativ.TypeOfAdress = "Secondary";
            personJesper.altAdresser.Add(jesperAlternativ);

            //opret Peter
            var tlf2 = new Telephone("77777777", "TeleDanmark", "Erhverv");
            var mailPeter = new Email("two@two-three.dk");
            //peter bor sammen med Jesper på samme primær adresse
            var person2 = new Person(tlf2, adr1, "Peter", "Jensen", "", "Mand", mailPeter);


            DocumentDBUnitOfWork x = new DocumentDBUnitOfWork(new DBContext());


            string s = Console.ReadLine();

           //x._PersonRepository.AddUser(personJesper).Wait();
         //  var person = x._PersonRepository.GetUserByEmail(mailJesper.UniqueEmail);
          //  Console.WriteLine("fandt: \n" + person.GivenName+ " "+person.MiddleName + " "+person.FamilyName);
           // x._PersonRepository.DeleteUserByEmail(mailJesper.UniqueEmail);

            #endregion

        }
    }
}
