using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
            Feladat9();
            Feladat10();
            Feladat11();
            Feladat12();
            Feladat13();
            Feladat14();
            Feladat15();
            Feladat16();
            Feladat17();
            Feladat18();
            Feladat19();
            Feladat20();
            Feladat21();
            Feladat22();
            Feladat23();
            Feladat24();
            Feladat25();
            Feladat26();
            Feladat27();
            Feladat28();
            Console.ReadLine();
        }
        static void Feladat1()
        {
            Console.Write("Kérem az első valós számot: ");
            double elsoValos = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a második valós számot: ");
            double masodikValos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"x = {elsoValos}");
            Console.WriteLine($"y = {masodikValos}");
            Console.WriteLine("-----------------");
            Console.ReadLine();
            Console.WriteLine($"x + y = {elsoValos + masodikValos}");
            Console.WriteLine($"x - y = {elsoValos - masodikValos}");
            Console.WriteLine($"x * y = {elsoValos * masodikValos}");
            Console.WriteLine($"x / y = {elsoValos / masodikValos}");
            Console.WriteLine($"x ^ 2 = {Math.Pow(elsoValos, 2)}");
            Console.WriteLine($"y ^ 3 = {Math.Pow(masodikValos, 2)}");
            Console.WriteLine($"x ^ 2 = {Math.Pow(elsoValos, 3)}");
            Console.WriteLine($"y ^ 3 = {Math.Pow(masodikValos, 3)}");
            Console.ReadLine();
        }
        static void Feladat2()
        {
            Console.Write("Kérem d valós számot: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem n egész számot: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A/az {d} {n} tizedes jegyre kerektett értéke: {Math.Round(d, n)}");
            Console.ReadLine();
        }
        static void Feladat3()
        {
            Console.Write("Kérek egy Forint összeget: ");
            double forint = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{forint} HUF = {forint * 0.0025} EUR = {forint * 0.0028} USD");
        }
        static void Feladat4()
        {
            Console.WriteLine("A háromszög oldalai:");
            Console.Write("A oldala = ");
            double oldal = Convert.ToDouble(Console.ReadLine());
            Console.Write("A oldalhoz tartozó magasság = ");
            double magassag = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine($"A háromszög területe (T) = {oldal * magassag / 2}");
            Console.ReadLine();
        }
        static void Feladat5()
        {
            Console.Write("Adja meg a születési évét: ");
            int szev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az aktuális évét: ");
            int ev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a szemüvegkeret árát: ");
            int keret = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a lencse árát: ");
            int lencse = Convert.ToInt32(Console.ReadLine());
            int kedvezmeny = ev - szev;
            Console.WriteLine($"Ön a szemüvegkeret árából, ami {keret} Ft, {kedvezmeny}% kedvezményt kap!");
            Console.WriteLine($"A szemüveglencse ára: {lencse} Ft");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Szemüvege vételára: {keret * kedvezmeny / 100 + lencse} Ft");
            Console.ReadLine();
        }
        static void Feladat6()
        {
            Console.Write("1. szám: ");
            double elso = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. szám: ");
            double masodik = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A két szám összege: {elso + masodik}");
            Console.WriteLine($"A két szám hányadosa: {elso / masodik}");
            Console.ReadLine();
        }
        static void Feladat7()
        {
            Console.Write("Adjon meg egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"2es osztási maradék: {szam % 2}");
            Console.WriteLine($"3as osztási maradék: {szam % 3}");
            Console.ReadLine();
        }
        static void Feladat8()
        {
            Console.Write("Adjon meg egy páros számot: ");
            int paros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A szám fele: {paros / 2}");
            Console.ReadLine();
        }
        static void Feladat9()
        {
            Console.Write("Adjon meg egy valós számot: ");
            double valos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A szám harmada: {valos / 3}");
            Console.ReadLine();
        }
        static void Feladat10()
        {
            Console.Write("Adja meg a medence átmérőjét (m): ");
            double atmero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg a medence mélységét (m) :");
            double melyseg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A medencébe {atmero * melyseg} köbméter víz fér.");
            Console.ReadLine();
        }
        static void Feladat11()
        {
            Console.Write("Adja meg A értékét: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg B értékét: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double minusza = 0 - a;
            double x = minusza * b;
            Console.WriteLine($" x = {x}");
            Console.ReadLine();
        }
        static void Feladat12()
        {
            Console.Write("Adja meg a tank méretét (l) : ");
            double tank = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg az út hosszát (km) : ");
            double ut = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Az autó átleg fogyasztása: {tank / ut * 100}l/100km");
            Console.ReadLine();
        }
        static void Feladat13()
        {
            Console.WriteLine("Adja meg a fizetését (Ft) : ");
            double fizetes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg az emelés százalékát(Ft) : ");
            double szazalek = Convert.ToDouble(Console.ReadLine());
            double emeles = fizetes / 100 * szazalek;
            Console.WriteLine($"Az emelés utáni fizetés összege: {emeles + fizetes} Ft.");
            Console.ReadLine();
        }
        static void Feladat14()
        {
            Console.Write("Adja meg, hogy mennyi pénzt tud havonta félre rakni (Ft) :");
            int havi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a laptop árát (Ft) : ");
            int ar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A laptopot {ar / havi} hónap múlva tudja megvásárolni.");
        }
        static void Feladat15()
        {
            Console.Write("Adja meg a kölcsön összegét (Ft) : ");
            int osszeg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a futamidőt (év) : ");
            int ev = Convert.ToInt32(Console.ReadLine());
            int ho = ev * 12;
            int reszlet = osszeg / ho;
            Console.WriteLine($"A havi törlesztő részlet összege: {reszlet} Ft.");
            Console.ReadLine();
        }
        static void Feladat16()
        {
            Console.Write("Adja meg a terület magasságát (m) : ");
            double magassag = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a terület szélességét (m) : ");
            double szelesseg = Convert.ToDouble(Console.ReadLine());
            double magcsempe = magassag * 100 / 20;
            double magcsempeveg = magcsempe / 10 + magcsempe;
            double szelcsempe = szelesseg * 100 / 20;
            double szelcsempeveg = szelcsempe / 10 + szelcsempe;
            Console.WriteLine($"A munka elvégzéséhez {Math.Round(szelcsempe * magcsempe)} db csempére van szügség");
            Console.ReadLine();
        }
        static void Feladat17()
        {
            Console.Write("Adja meg az első időpont óráját: ");
            int elsoora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az első időpont percét: ");
            int elsoperc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az első időpont másodpercét: ");
            int elsosec = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a második időpont óráját: ");
            int masodora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a második időpont percét: ");
            int masodperc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a második időpont másodpercét: ");
            int masodsec = Convert.ToInt32(Console.ReadLine());
            int elso = elsosec + elsoperc * 60 + elsoora * 3600;
            int masod = masodsec + masodperc * 60 + masodora * 3600;
            Console.WriteLine($"A két időpont közötti különbség: {masod - elso} másodperc");
            Console.ReadLine();

        }
        static void Feladat18()
        {
            Console.Write("Adja meg az 5 koronások számát: ");
            int otosok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a 3 koronások számát: ");
            int harmasok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az 1 koronások számát: ");
            int egyesek = Convert.ToInt32(Console.ReadLine());
            int osszeg = egyesek + harmasok * 3 + otosok * 5;
            Console.WriteLine($"A végösszeg: {osszeg} korona.");
            Console.ReadLine();

        }
        static void Feladat19()
        {
            Console.Write("Adja meg a dinnyék átmérőjét (cm) :");
            double atmero = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a dinnyék számát: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double veg = atmero * n + atmero * 60;
            Console.WriteLine($"{n} db dinnye átkötéséhez, {veg} cm-nyi szalag szügséges");
            Console.ReadLine();
        }
        static void Feladat20()
        {
            Console.Write("Adja meg a kert hosszát (m) :");
            double hossz = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a kert szélességét (m) : ");
            double szel = Convert.ToDouble(Console.ReadLine());
            double terulet = szel * hossz;
            double csomag = terulet / 5;
            Console.WriteLine($"{Math.Ceiling(csomag)} csomagra lesz szügség");
            Console.ReadLine();
        }
        static void Feladat21()
        {
            Console.Write("Adja meg az első egész számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a második egész számot: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A két szám összegének négyzetgyöke: {Math.Sqrt(a + b)}");
            Console.ReadLine();
        }
        static void Feladat22()
        {
            Console.Write("Adjon meg egy pozitív valós számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());
            double elotte = Math.Ceiling(szam);
            double utana = Math.Floor(szam);
            double kozelebb = Math.Round(szam);
            double egesz = Math.Floor(szam);
            double tort = szam - egesz;
            Console.WriteLine($"A megadott szám a {elotte} és a {utana} egész számok között van, és ezek közül a {kozelebb} számhoz van közelebb.");
            Console.WriteLine($"A szám egész része: {egesz}");
            Console.WriteLine($"A szám törtrésze: {tort}");
            Console.ReadLine();
        }
        static void Feladat23()
        {
            Console.Write("Adjon meg egy valós számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.Write(Math.Round(szam,2));
        }
        static void Feladat24()
        {
            Console.Write("Adjon meg egy nagyobb egész számot: ");
            int nagyobb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adjon meg egy kisebb egész számot: ");
            int kisebb = Convert.ToInt32(Console.ReadLine());
            int kulonbseg = nagyobb - kisebb;
            Console.WriteLine(kulonbseg);
            Console.WriteLine(Math.Abs(kulonbseg));
            Console.ReadLine();
        }
        static void Feladat25()
        {
            Console.Write("Adja meg az 1. pont x koordinátáját: ");
            double elsox = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg az 1. pont y koordinátáját: ");
            double elsoy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a 2. pont x koordinátáját: ");
            double masodikx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a 2. pont y koordinátáját: ");
            double masodiky = Convert.ToDouble(Console.ReadLine());
            double a = Math.Abs(elsox - masodikx);
            double b = Math.Abs(elsoy - masodiky);
            double a2 = Math.Pow(a,2);
            double b2 = Math.Pow(b,2);
            double c2 = a2 + b2;
            double c = Math.Sqrt(c2);
            Console.WriteLine($"A két pont távolsága {c} egység.");
            Console.ReadLine();

        }
        static void Feladat26()
        {
            Console.Write("Adja meg az első ember nevét: ");
            string elsonev = Console.ReadLine();
            Console.Write("Adja meg az első ember tettömegét (kg) : ");
            double elsotomeg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg az első ember magasságát (cm) : ");
            double elsomagassag = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adja meg a második ember nevét: ");
            string masodiknev = Console.ReadLine();
            Console.Write("Adja meg a második ember tettömegét (kg) : ");
            double masodiktomeg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a második ember magasságát (cm) : ");
            double masodikmagassag = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adja meg a harmadik ember nevét: ");
            string harmadiknev = Console.ReadLine();
            Console.Write("Adja meg a harmadik ember tettömegét (kg) : ");
            double harmadiktomeg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a harmadik ember magasságát (cm) : ");
            double harmadikmagassag = Convert.ToDouble(Console.ReadLine());

            double atlagmagassag = (elsomagassag + masodikmagassag + harmadikmagassag) / 3;
            double ossztomeg = elsotomeg + masodiktomeg + harmadiktomeg;
            Console.WriteLine($"Az átlagmagasság: {atlagmagassag}");
            Console.WriteLine($"A testössztömeg: {ossztomeg}");
            double elsobmi = elsotomeg / Math.Pow(elsomagassag / 100,2);
            double masodikbmi = masodiktomeg / Math.Pow(masodikmagassag / 100, 2);
            double harmadikbmi = harmadiktomeg / Math.Pow(harmadikmagassag / 100, 2);
            Console.WriteLine($"{elsonev} TTI-je: {Math.Round(elsobmi,2)}");
            Console.WriteLine($"{masodiknev} TTI-je: {Math.Round(masodikbmi,2)}");
            Console.WriteLine($"{harmadiknev} TTI-je: {Math.Round(harmadikbmi, 2)}");
            if (elsobmi > masodikbmi)
            {
                if (elsobmi > harmadikbmi)
                {
                    Console.WriteLine($"A legelhízottabb személy TTI értéke: {elsobmi}");
                }
                else
                {
                    Console.WriteLine($"A legelhízottabb személy TTI értéke: {harmadikbmi}");
                }
            }
            else
            {
                if (masodikbmi > harmadikbmi)
                {
                    Console.WriteLine($"A legelhízottabb személy TTI értéke: {masodikbmi}");
                }
                else
                {
                    Console.WriteLine($"A legelhízottabb személy TTI értéke: {harmadikbmi}");
                }
            }
            Console.ReadLine();
        }
        static void Feladat27()
        {
            Console.Write("Adja meg az átlagos havi villanyszámlájának költségét (Ft) : ");
            double havi = Convert.ToDouble(Console.ReadLine());
            double eves = havi * 12;
            Console.WriteLine($"Az éves energia költség: {eves} Ft.");
            double fogyasztas = eves / 39;
            double fedezet = fogyasztas / 100 * 85;
            double napelemek = fedezet / 310;
            double teto = napelemek * 1.7;
            Console.WriteLine($"A fedezéshez {napelemek} napelemre van szügség, melyek {teto} négyztméter helyet foglalnak a tetőn.");
            //A 27. feladat további elemeit sajnos nem állt módomban felfogni

        }
        static void Feladat28()
        {
            Console.Write("Adja meg a megvásárolni kívánt ingatlan értékét: ");
            double alap = Convert.ToDouble(Console.ReadLine());
            double ugynok = alap / 100 * 2.75;
            double ugyved = alap / 100 * 1.5;
            double illetek = alap / 100 * 4;
            double energetika = 40000;
            double tulajdoni = 6600;
            Console.WriteLine($"Az ingatlanügynök ára: {ugynok} Ft.");
            Console.WriteLine($"Az ügyvéd ára {ugyved} Ft.");
            Console.WriteLine($"Az illeték ára: {illetek} Ft.");
            Console.WriteLine($"Az energetikai tanusítvány kiállításának ára: {energetika} Ft.");
            Console.WriteLine($"A Tulajdoni lap lekérésének ára: {tulajdoni} Ft.");
            Console.WriteLine($"Így a teljes becsült összeg: {alap + ugynok + ugyved + illetek + energetika + tulajdoni} Ft.");
        }

    }
}
