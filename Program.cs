using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using System.IO;namespace ConsoleApp1{    public class Program    {        static void Main(string[] args)        {            MainMenu();        }        static void MainMenu()        {            Console.Clear();            Console.WriteLine("\t\tVälkommen till min app!");            Console.WriteLine("");            Console.WriteLine("\t\tVälj bland alternativen!");            Console.WriteLine("");            Console.WriteLine("\t0: Stäng ner");            Console.WriteLine("\t1: \"Hello world\"");            Console.WriteLine("\t2: Presentation");            Console.WriteLine("\t3: Ändra färger");            Console.WriteLine("\t4: Dagens datum");            Console.WriteLine("\t5: Jämför två tal");            Console.WriteLine("\t6: Gissa talet!");            Console.WriteLine("\t7: Skriver i en fil");            Console.WriteLine("\t8: Läser från en fil");            Console.WriteLine("\t9: Matematisk operation");            Console.WriteLine("\t10: En multiplikations tabell");            Console.WriteLine("\t11: Slumpmässiga tal i stigande ordning");            Console.WriteLine("\t12: Palindrom");            Console.WriteLine("\t13: Siffror som är mellan två tal");            Console.WriteLine("\t14: Udda och jämna värden");            Console.WriteLine("\t15: Summan av siffror");            Console.WriteLine("\t16: Spel");


            String minaAlternativ = Console.ReadLine();            switch (minaAlternativ)            {                case "0":                    Exit();                    break;                case "1":                    Intro();                    break;                case "2":                    Present();                    break;                case "3":                    Färg();                    break;                case "4":
                    displayDate();                    break;                case "5":                    Compare();                    break;                case "6":                    SlumpmässigGenerator();                    break;                case "7":                    FileSave();                    break;                case "8":                    FileRead();                    break;                case "9":                    MathOper();                    break;                case "10":                    multiplikationstabell();                    break;                case "11":                    RandomArray();                    break;                case "12":                    palindrom();                    break;                case "13":                    DisplayNum();                    break;                case "14":                    evenity();                    break;                case "15":                    Addition();                    break;                case "16":                    Person();                    break;                default:                    break;            }            MainMenu();        }        static void Exit()        {            Console.WriteLine("Är du säker på att du vill avsluta?");            Console.WriteLine("Tryck \"Enter\" för att avsluta");            Console.ReadLine();            System.Environment.Exit(1);        }        static void Intro()        {            Console.WriteLine("\"Hello World\"");            Console.ReadLine();        }        static void Present()        {            Console.WriteLine("Skriv in ditt förnamn");            String Förnamn = Console.ReadLine();            Console.WriteLine("Skriv in ditt efternamn");            String Efternamn = Console.ReadLine();
            Console.WriteLine("Skriv in ditt ålder");
            int Ålder =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Namn: " + Förnamn + " " + Efternamn);            Console.WriteLine("Ålder: " + Ålder);            Console.ReadLine();        }        static void Färg()        {
            Console.WriteLine("Textens färg ändras");            if (Console.ForegroundColor == ConsoleColor.Gray)            {                Console.ForegroundColor = ConsoleColor.Blue;            }            else            {                Console.ForegroundColor = ConsoleColor.Gray;            }            Console.ReadLine();        }        static void displayDate()        {            DateTime localDate = DateTime.Now;            Console.WriteLine("Dagens datum är " + localDate.ToShortDateString());            Console.ReadLine();        }

        static void Compare()        {            Console.WriteLine("Ange det första numret");            Double förstNum = Convert.ToDouble(Console.ReadLine());            Console.WriteLine("Ange det andra numret");            Double andraNum = Convert.ToDouble(Console.ReadLine());            Console.WriteLine("Det större nummer är " + Math.Max(förstNum, andraNum));

            /*if(förstNum > andraNum)            {                Console.WriteLine("Det större nummer är " + förstNum);            }            else if(förstNum < andraNum)            {                Console.WriteLine("Det större nummer är " + andraNum);            }            else             {                Console.WriteLine("De två siffrorna är lika, vilka är " + förstNum);            }*/
            Console.ReadLine();        }        static void SlumpmässigGenerator()        {
            System.Random random = new System.Random();
            int randNum = random.Next(1, 101);
            int userNum;
            int tried = 0;
            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            userNum = Convert.ToInt32(Console.ReadLine());
            tried++;
            while (randNum != userNum)
            {
                if (randNum > userNum)
                {
                    Console.WriteLine("Talet var för litet");
                }
                else
                {
                    Console.WriteLine("Talet var för stor");
                }
                Console.WriteLine("Gissa igen ett tal mellan 1 och 100");
                userNum = Convert.ToInt32(Console.ReadLine());
                tried++;
            }
            Console.WriteLine("Du har hittat talet efter " + tried + " försök. Det talet är " + randNum + ".");

            Console.ReadLine();        }

        static void FileSave()
        {
            String path = "filename.txt";
            Console.WriteLine("Skriv in en textrad");
            String input = Console.ReadLine();
            if (File.Exists(path))
            {
                File.AppendAllText(path, "\n" + input);
            }
            else
            {
                File.Create("path");
                File.WriteAllText(path, input);
            }

            Console.ReadLine();

            
        }
        static void FileRead()
        {
            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
            Console.ReadLine();
        }
        static void MathOper()
        {
            Console.WriteLine("Ange ett decimaltal");
            double num = Convert.ToDouble(Console.ReadLine());            Console.WriteLine("");            Console.WriteLine("Roten ur " + num + " är " + Math.Sqrt(num));            Console.WriteLine("");            Console.WriteLine(num + " upphöjt till 2 är " + Math.Pow(num, 2));            Console.WriteLine("");            Console.WriteLine(num + " upphöjt till 10 är " + Math.Pow(num, 10));
            Console.ReadLine();
        }
        static void multiplikationstabell()
        {
            Console.WriteLine("\t \t \t Multiplikationtabell");
            Console.WriteLine(" ");
            /* Console.Write("\t");
             for(int i=1;i<=10;i++)
             {
                 Console.Write(i +"\t");
             }
             Console.WriteLine("");
             for (int j = 1; j <= 10; j++)
             {
                 Console.Write(j + "\v");
             }*/
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("   ");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        static void RandomArray()
        {
            System.Random random = new System.Random();
            Console.WriteLine("Ange storleken av arrayer ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] RandNum = new int[size];
            int[] OrderNum = new int[size];
            for (int i = 0; i < size; i++)
            {
                RandNum[i] = random.Next();
                OrderNum[i] = RandNum[i];
            }
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (OrderNum[i] > OrderNum[j])
                    {
                        int temp = OrderNum[i];
                        OrderNum[i] = OrderNum[j];
                        OrderNum[j] = temp;
                    }
                }
            }
            Console.WriteLine("De slumpmässigt genererade talen är\n");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(RandNum[i] + "\n");
            }
            Console.WriteLine("De ordnade talen i stigande ordning är\n");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(OrderNum[i] + "\n");
            }
            Console.ReadLine();
        }
        static void palindrom()
        {
            Console.WriteLine("Ange ett ord");
            String input = Console.ReadLine();
            String word = input.ToLower();
            int len = word.Length;
            bool pal = true;
            for (int i = 0; i < len; i++)
            {
                if (word[i] != word[len - 1 - i])
                {
                    pal = false;
                    break;
                }
            }
            if (pal == true)
            {
                Console.WriteLine(input + " är en palindrom.");
            }
            else
            {
                Console.WriteLine(input + " är inte en palindrom.");
            }
            Console.ReadLine();
        }
        static void DisplayNum()
        {
            Console.WriteLine("Ange det första numret");            int förstNum = Convert.ToInt32(Console.ReadLine());            Console.WriteLine("Ange det andra numret");            int andraNum = Convert.ToInt32(Console.ReadLine());

            int min = Math.Min(förstNum, andraNum);
            int max = Math.Max(förstNum, andraNum);
            Console.WriteLine("\nSiffror som är mellan " + min + " och " + max + " är\n");
            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void evenity()
        {
            Console.WriteLine("Ange siffrorna separerade med komma ");
            String input = Console.ReadLine();
            List<int> listnums = new List<int>(input.Split(',').Select(int.Parse));
            int listlength = listnums.Count();
            for (int i = 0; i < listlength - 1; i++)
            {
                for (int j = i + 1; j < listlength; j++)
                {
                    if (listnums[i] > listnums[j])
                    {
                        int temp = listnums[i];
                        listnums[i] = listnums[j];
                        listnums[j] = temp;
                    }
                }
            }
            List<int> evennums = new List<int>();
            List<int> oddnums = new List<int>();
            for (int i = 0; i < listlength; i++)
            {

                if (listnums[i] % 2 == 0)
                {
                    evennums.Add(listnums[i]);
                }
                else
                {
                    oddnums.Add(listnums[i]);
                }
            }
            Console.WriteLine("\nDe jämna siffrorna är  ");
            foreach (var even in evennums)
            {
                Console.Write(even + "  ");
            }
            Console.WriteLine("\n\nDe udda siffrorna är  ");
            foreach (var odd in oddnums)
            {
                Console.Write(odd + "  ");
            }
            Console.ReadLine();
        }
        static void Addition()
        {
            Console.WriteLine("Ange siffrorna separerade med komma ");
            String input = Console.ReadLine();
            List<int> listnums = new List<int>(input.Split(',').Select(int.Parse));
            int listlength = listnums.Count();
            int result = 0;

            for (int i = 0; i < listlength; i++)
            {
                result += listnums[i];
            }
            Console.WriteLine("\nDen totala summan är " + result);


            Console.ReadLine();
        }
        
        static void Person()

        {
            Console.WriteLine("Ange namnet på din karaktär");
            String MyName = Console.ReadLine();
            Character my = new Character(MyName);
            /*my.name = MyName;
            System.Random random = new System.Random();
            my.Hälsa = random.Next(1, 11);
            my.Stryka = random.Next(1, 11);
            my.Tur = random.Next(1, 11);*/

            Console.WriteLine("Ange namnet på en motståndare");
            String OppName = Console.ReadLine();
            Character Opponent = new Character(OppName);
            Console.WriteLine("");
            my.display();
            Console.WriteLine("");
            Opponent.display();
            /* Opponent.name = OppName;
             Opponent.Hälsa = random.Next(1, 11);
             Opponent.Stryka = random.Next(1, 11);
             Opponent.Tur = random.Next(1, 11);*/
            Console.ReadLine();
        }
        
    }    public class Character
    {
        String name;
        int Hälsa;
        int Stryka;
        int Tur;
       public Character(String name)
        {
            this.name = name;
            System.Random random = new System.Random();
            Hälsa = random.Next(1, 11);
            Stryka = random.Next(1, 11);
            Tur = random.Next(1, 11);
        }
        public void display()
        {
            Console.WriteLine(name +" har fått "+ Hälsa +" poäng för Hälsa, "+ Stryka +" poäng för Stryka och "+ Tur+" poäng för Tur.");
        }
    }}