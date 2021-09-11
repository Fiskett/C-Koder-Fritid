using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiskens_Hav_av_skatter
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Player p = new Player();


            Console.WriteLine("Välkommen till Fiskens Aquarum av både skatter och faror.");
            Console.WriteLine("Är du redo för att starta ditt äventyr");
            string start = Console.ReadLine();
            if (start == "Nej" || start == "nej")
            {
                Console.WriteLine("Nahe dra hem då och lev ditt tråkiga liv då. Hälsa Morsan ;)");
                return;
            }
            Console.WriteLine("Framför dig ser du tre vägar. \n En leder till en liten stad du ser en skylt där det står Tibro\n Den andra vägen leder till en Dojo där du ser massa ninjor utövar Taekwando\n Den tredje vägen leder till en kamping med en kamel utanför?");
            Console.WriteLine("Vill du till Tibro, Dojon eller Kamelen?");
            p.IsAt = Console.ReadLine();

            bool loop = false;
            while(loop == false)
            {
                if (p.IsAt == "Kamelen")
                {
                    p = GoToKamelen(p);
                    p = GoToHome(p);
                }
                if (p.IsAt == "Tibro")
                {
                    p = GoToTibro(p);
                    p = GoToHome(p);
                   
                }
                if (p.IsAt == "Dojon")
                {
                    p = GoToDojon(p);
                    p = GoToHome(p);
                }

            }
            
            
            
            
            
        }

        private static Player GoToHome(Player p)
        {
            Console.Clear();
            Console.WriteLine("Framför dig ser du tre vägar. \n En leder till en liten stad du ser en skylt där det står Tibro\n Den andra vägen leder till en Dojo där du ser massa ninjor utövar Taekwando\n Den tredje vägen leder till en kamping med en kamel utanför?");
            Console.WriteLine("Vill du till Tibro, Dojon eller Kamelen?");
            p.IsAt = Console.ReadLine();

            bool loop = false;
            while (loop == false)
            {
                if (p.IsAt == "Kamelen")
                {
                    p = GoToKamelen(p);
                }
                if (p.IsAt == "Tibro")
                {
                    p = GoToTibro(p);

                }
                if (p.IsAt == "Dojon")
                {
                    p = GoToDojon(p);
                }
            }
            return p;
        }

        private static Player GoToKamelen(Player p)
        {
            
            Console.WriteLine("Du går fram till Kamelen och ut kommer en dvärg på ca 140 cm. Han välkommnar dig till Prego och säger att han heter Dawan");
            while (p.IsAt == "Kamelen")
            {

            
                Console.WriteLine("Vill du köpa något?");
                string buy = Console.ReadLine();
                if (buy == "Nej" || buy == "nej") { p = GoToHome(p); }
                Console.WriteLine("Han förklarar att du kan köpa tre olika saker\n En flaska vodka\n Ett 20 pack nuggets\n En väldigt dyr stekpanna");
                string item = Console.ReadLine();

                if (item == "Vodka Flaska" || item == "Vodkan" || item == "Vodka")
                {
                    Console.WriteLine("Du bestämmer dig för att köpa Vodkan och tänker att du kan dricka den senare");
                    p.money = (p.money - 200);
                    p.vodka = true;

                }
                else if (item == "Nuggets" || item == "20 pack nuggets")
                {
                    Console.WriteLine("Du bestämmer dig för att köpa ett 20 pack nuggets ");
                    p.money = (p.money - 80);
                    p.nuggets = true;
                }
                else if (item == "Stekpanna" || item == "En väldigt dyr stekpanna")
                {
                    Console.WriteLine("Du bestämmer dig för att köpa en väldigt dyr stekpanna ");
                    p.money = (p.money - 1000);
                    p.stekpanna = true;
                }
                
            }
            return p;
        }
        private static Player GoToTibro(Player p)
        {
            Console.WriteLine("Du börjar gå mot Tibro och helt plötsligt så hoppar en rysk man utan tröja ut ur en buske. Han frågar ifall du har en flaska vodka.\n");
            if (p.vodka == true)
            {
                Console.WriteLine("Vill du ge den ryske mannen din flaska vodka");
                p.GiveVodka = Console.ReadLine();
                if (p.GiveVodka == "Ja")
                {
                    Console.WriteLine("Den ryske mannen introducerar sig som Christian han berättar att han sett en man med hörlurar i hörnet av Dojon ifall du ville träffa honom.");
                    Console.WriteLine("Du bestämmer dig för att gå tillbaka till korrsningen med din nya information");
                    p.vodka = false;
                    p.Max = true;
                    Console.ReadLine();
                    p = GoToHome(p);
                }
                else
                {
                    Console.WriteLine("Du säger att du inte har någon vodka flaska och går tillbaka till korrsningen.");
                    p = GoToHome(p);
                }
            
            }
            return p;
        }
        private static Player GoToDojon(Player p)
        {
            Console.WriteLine("Du går in i Dojon och så ser du en person som ser ut att ha ett väldigt ohälsosamt spel beroende");
            Console.WriteLine("Du bestämmer dig för att fråga vad främlingen heter. Han säger att han heter Knacke och frågar vad du vill");
            if (p.Max == true)
            {
                Console.WriteLine("Vill du fråga honom om han gillar änder eller om pojken i hörnet");
                p.QJack = Console.ReadLine();
                if (p.QJack == "Pojken" || p.QJack == "Pojken is hörnet")
                {
                    Console.WriteLine("Du frågar om pojken som sitter i hörnet. Knacke svarar att han heter Max, han vat inte riktigt hur eller när han kom in men att han bara var där en dag\n" +
                        "Knacke nämner också att han aldrig sett Max utan sina hörlurar");
                }
                else if (p.QJack == "Änder" || p.QJack == "änder")
                {
                    Console.WriteLine("Du frågar Knacke om han gillar änder. Han får ett stort leende på sitt ansikte och säger att han älskar de lite för mycket ;)");
                }
            }
            else
            {
                Console.WriteLine("Du frågar Knacke om han gillar änder. Han får ett stort leende på sitt ansikte och säger att han älskar de lite för mycket ;)");
                Console.ReadLine();
            }
            return p;
        }

       
    }
}
