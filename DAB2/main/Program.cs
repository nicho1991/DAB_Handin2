using DAB2._1;
using System.Data.Entity;

namespace DAB2_2
{
    public class Program
    {
        private static void Main()
        {
            using (var db = new personIndexContext())
            {
                var adressOne = new Adress("Værkmestergade","22A","8000","Aarhus");
                db.AdressesSet.Add(adressOne);
            }
        }
    }

}