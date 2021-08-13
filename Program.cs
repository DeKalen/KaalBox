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
            Console.WriteLine("Hallo, welkom bij kaalbox                   Je kunt altijd stoppen door weg in te typen                                                versie 1.00");

            Console.WriteLine("\nTyp je naam");
            Console.WriteLine(" ");
            string persoonNaam = Console.ReadLine();
          

            Console.WriteLine("\nWelkom " + persoonNaam);
            Optie:
            Console.WriteLine("\nEr zijn deze opties beschikbaar\n\nKaalquiz , Na-apen , Dobbelsteen , Rekenmachine");
            Console.WriteLine(" ");
            string spelOptie = Console.ReadLine();
            if (spelOptie == "K")
            {
                Console.WriteLine("\nWelkom bij Kaalquiz \nGebruik hoofdletters!!!");
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.WriteLine("\nHoeveel procent van de mannen rond de dertigste zijn kaal.\nA.35% B.20% C.86%");
                string quizAntwoord01 = Console.ReadLine();
                int quiztrys = 0;
                if (quizAntwoord01 == "A")
                {
                    Console.WriteLine("Dat is fout, klik enter om door te gaan");
                    Console.ReadLine();
                    goto Vraag01;
                }
                else if (quizAntwoord01 == "B")
                {
                    Console.WriteLine("Dat is goed, klik enter om door te gaan");
                    Console.ReadLine();
                    quiztrys++;
                    goto Vraag01;
                }
                else if (quizAntwoord01 == "C")
                {
                    Console.WriteLine("Dat is fout, klik enter om door te gaan");
                    Console.ReadLine();
                    goto Vraag01;
                }

                Vraag01:
                Console.WriteLine("Hoe zijn mannen kaal rond de vijftigste.\nA.redelijk B.weinig C.allemaal");
                string quizAntwoord02 = Console.ReadLine();
                if (quizAntwoord02 == "A")
                {
                    Console.WriteLine("Dat is goed, klik enter om door te gaan");
                    Console.ReadLine();
                    quiztrys++;
                    goto Vraag02;
                }
                else if (quizAntwoord02 == "B")
                {
                    Console.WriteLine("Dat is fout, klik enter om door te gaan");
                    Console.ReadLine();
                    goto Vraag02;
                }
                else if (quizAntwoord02 == "C")
                {
                    Console.WriteLine("Dat is fout, klik enter om door te gaan");
                    Console.ReadLine();
                    goto Vraag02;
                }

                Vraag02:
                Console.WriteLine("Is marco kaal\nA.ja B.mischien C.ZEKER");
                string quizAntwoord03 = Console.ReadLine();
                if (quizAntwoord03 == "A")
                {
                    Console.WriteLine("Dat is goed, klik enter om door te gaan");
                    Console.ReadLine();
                    quiztrys++;
                    goto Vraag03;
                }
                else if (quizAntwoord03 == "B")
                {
                    Console.WriteLine("Dat is goed, klik enter om door te gaan");
                    Console.ReadLine();
                    quiztrys++;
                    goto Vraag03;
                }
                else if (quizAntwoord03 == "C")
                {
                    Console.WriteLine("Dat is goed, klik enter om door te gaan");
                    Console.ReadLine();
                    quiztrys++;
                    goto Vraag03;
                }

                Vraag03:
                Console.WriteLine("Is kaalheid erfelijk\nA.Nee B.Tuurlijk niet C.Ja");
                string quizAntwoord04 = Console.ReadLine();
                if (quizAntwoord04 == "A")
                {
                    Console.WriteLine("Helaas is het fout, klik enter om door te gaan");
                    Console.ReadLine();
                    goto Vraag04;
                }
                else if (quizAntwoord04 == "B")
                {
                    Console.WriteLine("Dat is fout, klik enter om door te gaan");
                    Console.ReadLine();
                    goto Vraag04;
                }
                else if (quizAntwoord04 == "C")
                {
                    Console.WriteLine("Dat is helaas goed, klik enter om door te gaan");
                    Console.ReadLine();
                    quiztrys++;
                    goto Vraag04;
                }
                Vraag04:
                Console.WriteLine("Als je op je 40ste nog haar hebt, wordt je niet meer kaal\nA.Niet waar.B.Wel waar");
                string quizAntwoord05 = Console.ReadLine();
                if (quizAntwoord05 == "A")
                {
                    Console.WriteLine("Dat is goed, klik enter om door te gaan");
                    Console.ReadLine();
                    quiztrys++;
                    goto Vraag05;
                }
                else if (quizAntwoord05 == "B")
                {
                    Console.WriteLine("Dat is fout, klik enter om door te gaan");
                    Console.ReadLine();
                    goto Vraag05;
                }
                Vraag05:
                Console.WriteLine("Eens kaal altijd kaal\nA.Ja B.Nee");
                string quizAntwoord06 = Console.ReadLine();
                if (quizAntwoord06 == "A")
                {
                    Console.WriteLine("Je hebt zeker goed,klik enter om door te gaan");
                    Console.ReadLine();
                    quiztrys++;
                    goto Vraageinde;
                }
                else if (quizAntwoord06 == "B")
                {
                    Console.WriteLine("Je hebt het zeker niet goed wat denk je wel, klik enter om door te gaan");
                    Console.ReadLine();
                    goto Vraageinde;

                }
                Vraageinde:
                Console.WriteLine("Je hebt het einde van de quiz bereikt.\nJe hebt " + quiztrys + " vragen goed beantwoord.\nTyp A om te andere opties te zien of typ W om weg te gaan");
                string vraagOptie = Console.ReadLine();
                if (vraagOptie == "A")
                {
                    goto Optie;
                }
                else if (vraagOptie == "W")
                {
                    goto Einde;
                }

            }
            else if (spelOptie == "N")
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
                        Console.WriteLine("typ O om terug te gaan of typ A om de andere opties te kiezen of typ W om weg te gaan");
                        string Apenoptie = Console.ReadLine();
                        if (Apenoptie == "O")
                        {
                            goto Apen;
                        }
                        else if (Apenoptie == "A")
                        {
                            goto Optie;
                        }
                        else if (Apenoptie == "W")
                        {
                            goto Einde;
                        }


            }
            else if (spelOptie == "D")
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
                    Console.WriteLine("\ntyp O om terug te gaan of typ A om de andere opties te kiezen of\ntyp D om de andere dobbelsteen opties te kiezen of typ W om weg te gaan");
                    string Dobbeloptie01 = Console.ReadLine();
                    if (Dobbeloptie01 == "O")
                    {
                        goto Dobbel01;
                    }
                    else if (Dobbeloptie01 == "A")
                    {
                        goto Optie;
                    }
                    else if (Dobbeloptie01 == "D")
                    {
                        goto Dobbel;
                    }
                    else if (Dobbeloptie01 == "W")
                    {
                        goto Einde;
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

                            Console.WriteLine("\ntyp O om terug te gaan of typ A om de andere opties te kiezen of\ntyp D om de andere dobbelsteen opties te kiezen of typ W om weg te gaan");
                            string dobbeloptie02 = Console.ReadLine();
                            if (dobbeloptie02 == "O")
                            {
                                goto Dobbel02;
                            }
                            else if (dobbeloptie02 == "A")
                            {
                                goto Optie;
                            }
                            else if (dobbeloptie02 == "D")
                            {
                                goto Dobbel;
                            }
                            else if (dobbeloptie02 == "W")
                            {
                                goto Einde;
                            }
                }
            }
            else if (spelOptie == "R")
            {
                Reken:
                double num01;
                double num02;
                Console.WriteLine("Voer een nummer in");

                num01 = Convert.ToDouble( Console.ReadLine() );
                Console.WriteLine("Voer een tweede nummer in");
                num02 = Convert.ToDouble( Console.ReadLine() );
                Console.WriteLine("\nWil Je * - + / ^");
                string rekenOptie = Console.ReadLine();
                if (rekenOptie == "*")
                {
                    double result = num01 * num02;
                    Console.WriteLine("Het resultaat is " + result);
                    Console.WriteLine("\nOm opnieuw te rekenen typ O , Om andere opties te kijken typ A , Om weg te gaan typ W");
                    string rekenEinde = Console.ReadLine();
                    if (rekenEinde == "O")
                    {
                        goto Reken;
                    }
                    else if (rekenEinde == "A")
                    {
                        goto Optie;
                    }
                    else if (rekenEinde == "W")
                    {
                        goto Einde;
                    }
                }
                else if (rekenOptie == "-")
                {
                    double result01 = num01 - num02;
                    Console.WriteLine("Het resultaat is " + result01);
                    Console.WriteLine("\nOm opnieuw te rekenen typ O , Om andere opties te kijken typ A , Om weg te gaan typ W");
                    string rekenEinde01 = Console.ReadLine();
                    if (rekenEinde01 == "opnieuw")
                    {
                        goto Reken;
                    }
                    else if (rekenEinde01 == "andere")
                    {
                        goto Optie;
                    }
                    else if (rekenEinde01 == "weg")
                    {
                        goto Einde;
                    }
                }
                else if (rekenOptie == "+")
                {
                    double result02 = num01 + num02;
                    Console.WriteLine("Het resultaat is "+ result02);
                    Console.WriteLine("\nOm opnieuw te rekenen typ O , Om andere opties te kijken typ A , Om weg te gaan typ W");
                    string rekenEinde02 = Console.ReadLine();
                    if (rekenEinde02 == "O")
                    {
                        goto Reken;
                    }
                    else if (rekenEinde02 == "A")
                    {
                        goto Optie;
                    }
                    else if (rekenEinde02 == "W")
                    {
                        goto Einde;
                    }
                }
                else if (rekenOptie == "/")
                {
                    double result03 = num01 / num02;
                    Console.WriteLine("Het resultaat is " + result03);
                    Console.WriteLine("\nOm opnieuw te rekenen typ O , Om andere opties te kijken typ A , Om weg te gaan typ W");
                    string rekenEinde03 = Console.ReadLine();
                    if (rekenEinde03 == "O")
                    {
                        goto Reken;
                    }
                    else if (rekenEinde03 == "A")
                    {
                        goto Optie;
                    }
                    else if (rekenEinde03 == "W")
                    {
                        goto Einde;
                    }
                }
            }
            else if (spelOptie == "weg")
            {
                goto Einde;
            }

            Einde:
            Console.WriteLine("Typ kaal om weg te gaan");
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
