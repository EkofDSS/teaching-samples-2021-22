
using System;

namespace DSS.AutoImplementedProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Poruka p = new Poruka();
            p.Sadrzaj = "Mickey Mouse";
            Console.WriteLine(p.Sadrzaj);
            p.Sadrzaj = "Donald Duck";
            p.PrikazNaKonzolu();
        }

    }

}
