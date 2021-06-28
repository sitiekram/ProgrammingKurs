﻿using System;


            String minaAlternativ = Console.ReadLine();
                    displayDate();
            Console.WriteLine("Skriv in ditt ålder");
            int Ålder =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Textens färg ändras");

        static void Compare()

            /*if(förstNum > andraNum)
            Console.ReadLine();
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

            Console.ReadLine();

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
            double num = Convert.ToDouble(Console.ReadLine());
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
            Console.WriteLine("Ange det första numret");

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
        
    }
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
    }