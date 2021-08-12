using System;

namespace kaal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kaal Box";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WindowWidth = 150;
            Console.WindowHeight = 40;
            Console.WriteLine("Hallo, welkom bij kaalbox                   Je kunt altijd stoppen door kaal in te typen                                           BETA  versie 1.10");

            Console.WriteLine("\nTyp je naam");
            Console.WriteLine(" ");
            string persoonNaam = Console.ReadLine();
            

            Console.WriteLine("\nWelkom " + persoonNaam);
            Optie:
            Console.WriteLine("\nEr zijn deze opties beschikbaar\n\nKaalquiz , Na-apen , Dobbelsteen");
            Console.WriteLine(" ");
            string spelOptie = Console.ReadLine();
            if (spelOptie == "kaalquiz")
            {
                Console.WriteLine("\nWelkom bij Kaalquiz \nGebruik hoofdletters!!!");
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.WriteLine("\nBegin");
                Console.ReadLine();
                Console.WriteLine("\nHoeveel procent van de mannen rond de dertigste zijn kaal.\nA.35% B.20% C.86%");
                string quizAntwoord01 = Console.ReadLine();
                if (quizAntwoord01 == "A")
                {
                    Console.WriteLine("Dat is fout");
                    Console.ReadLine();
                }
                else if (quizAntwoord01 == "B")
                {
                    Console.WriteLine("Dat is goed, klik enter om door te gaan");
                    Console.ReadLine();
                }
                else if (quizAntwoord01 == "C")
                {
                    Console.WriteLine("Dat is fout, klik enter om door te gaan");
                    Console.ReadLine();
                }
            }
            else if (spelOptie == "na-apen")
            {   Apen:
                Console.WriteLine("Welkom bij Na-apen klik op enter om te beginnen");
                        Console.ReadLine();
                        Console.WriteLine("Begin");
                        string naApen01 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen01);
                        string naApen02 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen02);
                        string naApen03 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen03);
                        string naApen04 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen04);
                        string naApen05 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen05);
                        string naApen06 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen06);
                        string naApen07 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen07);
                        string naApen08 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen08);
                        string naApen09 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen09);
                        string naApen10 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen10);
                        string naApen11 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen11);
                        string naApen12 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen12);
                        string naApen13 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen13);
                        string naApen14 = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine(naApen14);
                        Console.WriteLine("Je hebt het einde bereikt");
                        Console.WriteLine("typ opnieuw om terug te gaan of andere om de andere opties te kiezen");
                        string Apenoptie = Console.ReadLine();
                        if (Apenoptie == "opnieuw")
                        {
                            goto Apen;
                        }
                        else if (Apenoptie == "andere")
                        {
                            goto Optie;
                        }


            }
            else if (spelOptie == "dobbelsteen")
            {
                Console.WriteLine("De bedoeling is om een of twee dobbelsteen(nen) te gooien totdat je het zelfde aantal ogen heb");
                Dobbel:
                Console.WriteLine("\nHoeveel dobbelstenen 1 of 2");
                string dobbelEen = Console.ReadLine();
                if (dobbelEen == "1")
                {
                    Console.WriteLine("Je koos 1 dobbelsteen, klik enter om te beginnen");
                    Console.ReadLine();
                    Dobbel01:
                    Random numberGen = new Random();
                    int roll = 0;
                    int trys = 0;

                    Console.WriteLine("Klik enter om te gooien");


                    while(roll != 6) {
                    Console.ReadKey();
                    roll = numberGen.Next(1, 7);
                    Console.WriteLine("Je gooide :" + roll);
                    trys++;
                    }

                    Console.WriteLine("\nHet duurde je " + trys + " pogingen om een zes te gooien.");
                    Console.WriteLine("\ntyp opnieuw om terug te gaan of andere om de andere opties te kiezen of dobbelsteen om de andere dobbelsteen opties te kiezen");
                    string Dobbeloptie01 = Console.ReadLine();
                    if (Dobbeloptie01 == "opnieuw")
                    {
                        goto Dobbel01;
                    }
                    else if (Dobbeloptie01 == "andere")
                    {
                        goto Optie;
                    }
                    else if (Dobbeloptie01 == "dobbelsteen")
                    {
                        goto Dobbel;
                    }
                }
                else if (dobbelEen == "2")
                {
                    Console.WriteLine("Je koos 2 dobbelstenen, klik enter om te beginnen");
                            Console.ReadLine();
                            Dobbel02:
                            Random numberGen = new Random();
                            int roll01 = 0;
                            int roll02 = 1;
                            int trys01 = 0;

                            Console.WriteLine("Klik enter om te gooien");

                            while (roll01 != roll02) {
                                Console.ReadKey();
                                roll01 = numberGen.Next(1, 7);
                                roll02 = numberGen.Next(1, 7);
                                Console.WriteLine("\nDobbelsteen 1: " + roll02);
                                Console.WriteLine("\nDobbelsteen 2: " + roll01);
                                trys01++;

                            }

                            Console.WriteLine("\nHet duurde je " + trys01 + " pogingen om even te gooien");

                            Console.WriteLine("\ntyp opnieuw om terug te gaan of andere om de andere opties te kiezen of dobbelsteen om de andere dobbelsteen opties te kiezen");
                            string dobbeloptie02 = Console.ReadLine();
                            if (dobbeloptie02 == "opnieuw")
                            {
                                goto Dobbel02;
                            }
                            else if (dobbeloptie02 == "andere")
                            {
                                goto Optie;
                            }
                            else if (dobbeloptie02 == "dobbelsteen")
                            {
                                goto Dobbel;
                            }
                }
            }

            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
