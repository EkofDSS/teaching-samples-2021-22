
using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace DSS.BreakfastTasks
{
    class Program
    {
        private static OranzDjus SipajOranzDjus()
        {
            Console.WriteLine(">>>Priprema oranz djusa: sipanje.");
            return new OranzDjus();
        }

        private static void NamaziDzem(Tost tost) =>
            Console.WriteLine(">>>Mazanje dzemom: dzem se stavlja na tost.");

        private static void NamaziPuter(Tost tost) =>
            Console.WriteLine(">>>Mazanje puterom: puter se stavlja na tost.");

        private static async Task<Tost> IspeciTostHlebAsync(int brojKriski)
        {
            for (int kriska = 0; kriska < brojKriski; kriska++)
            {
                Console.WriteLine(">>>Pecenje tost hleba: stavlja se kriska helba u toster.");
            }
            Console.WriteLine(">>>Pecenje tost hleba: pocinje thleb da se pece...");
            await Task.Delay(3000);
            Console.WriteLine(">>>Pecenje tost hleba: uklanjaju se ispecene kriske hleba iz tostera.");
            return new Tost();
        }

        private static async Task<Slanina> IsprziSlaninuAsync(int brojParcica)
        {
            Console.WriteLine($">>>Przenje slanine: postavljanje {brojParcica} parcica slanine u tiganj.");
            Console.WriteLine(">>>Przenje slanine: przenje jedne strane slanine...");
            await Task.Delay(3000);
            for (int parce = 0; parce < brojParcica; parce++)
            {
                Console.WriteLine(">>>Przenje slanine: okretanje jednog parceta slanine");
            }
            Console.WriteLine(">>>Przenje slanine: przenje druge strane slanine......");
            await Task.Delay(3000);
            Console.WriteLine(">>>Przenje slanine: postavljanje ispryene slanine u tanjir");
            return new Slanina();
        }

        private static async Task<Jaje> IsprziJajaAsync(int koliko)
        {
            Console.WriteLine(">>>Przenje jaja: zagrejavanje tanjira za przenje jaja...");
            await Task.Delay(3000);
            Console.WriteLine($">>>Przenje jaja: lupanje {koliko} jaja.");
            Console.WriteLine(">>>Przenje jaja: przenje jaja...");
            await Task.Delay(3000);
            Console.WriteLine(">>>Przenje jaja: stavljanje jaja na tanjir.");
            return new Jaje();
        }

        static async Task<Tost> PripremiTostSaPuteromDzemomAsync(int brojKriski)
        {
            var tost = await IspeciTostHlebAsync(brojKriski);
            NamaziPuter(tost);
            NamaziDzem(tost);

            return tost;
        }

        private static Kafa SipajEkspresKafu()
        {
            Console.WriteLine(">>>Sipanje kafe: uspi kafu.");
            return new Kafa();
        }

        public static async Task Main(string[] args)
        {
            var stoperica = Stopwatch.StartNew();

            Kafa soljaKafe = SipajEkspresKafu();
            Console.WriteLine("{0} ms: kafa je pripremljena.", stoperica.ElapsedMilliseconds);

            Task<Jaje> przenjeJaja = IsprziJajaAsync(2);
            Task<Slanina> przenjeSlanine = IsprziSlaninuAsync(3);
            Task<Tost> pripremanjeTosta = PripremiTostSaPuteromDzemomAsync(2);

            Jaje jaje = await przenjeJaja;
            Console.WriteLine("{0} ms: jaja su pripremljena.", stoperica.ElapsedMilliseconds);

            Slanina slanina = await przenjeSlanine;
            Console.WriteLine("{0} ms: slanina je pripremljena.", stoperica.ElapsedMilliseconds);

            Tost tost = await pripremanjeTosta;
            Console.WriteLine("{0} ms: tost je pripremljen.", stoperica.ElapsedMilliseconds);

            OranzDjus oranzDjus = SipajOranzDjus();
            Console.WriteLine("{0} ms: oranz djus je pripremljen.", stoperica.ElapsedMilliseconds);

            Console.WriteLine("{0} ms: dorucak je spreman!", stoperica.ElapsedMilliseconds);
        }
    }
}

/*  Izlaz dobijen prilikom izvrsavanja programa:
>>>Sipanje kafe: uspi kafu.
15 ms: kafa je pripremljena.
>>>Przenje jaja: zagrejavanje tanjira za przenje jaja...
>>>Przenje slanine: postavljanje 3 parcica slanine u tiganj.
>>>Przenje slanine: przenje jedne strane slanine...
>>>Pecenje tost hleba: stavlja se kriska helba u toster.
>>>Pecenje tost hleba: stavlja se kriska helba u toster.
>>>Pecenje tost hleba: pocinje thleb da se pece...
>>>Pecenje tost hleba: uklanjaju se ispecene kriske hleba iz tostera.
>>>Przenje slanine: okretanje jednog parceta slanine
>>>Przenje slanine: okretanje jednog parceta slanine
>>>Przenje slanine: okretanje jednog parceta slanine
>>>Przenje slanine: przenje druge strane slanine......
>>>Przenje jaja: lupanje 2 jaja.
>>>Przenje jaja: przenje jaja...
>>>Mazanje puterom: puter se stavlja na tost.
>>>Mazanje dzemom: dzem se stavlja na tost.
>>>Przenje slanine: postavljanje ispryene slanine u tanjir
>>>Przenje jaja: stavljanje jaja na tanjir.
6068 ms: jaja su pripremljena.
6068 ms: slanina je pripremljena.
6069 ms: tost je pripremljen.
>>>Priprema oranz djusa: sipanje.
6069 ms: oranz djus je pripremljen.
6069 ms: dorucak je spreman!

 */


