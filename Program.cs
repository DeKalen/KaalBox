using System;
using System.Collections.Generic;
using System.Text;

namespace kaal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kaal Box";
            Console.WindowWidth = 150;
            Console.WindowHeight = 40;
            Console.WriteLine("Hallo, welkom bij kaalbox                   Als je niet weet hoe iets werkt typ help                                                versie 1.10");

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
                Console.WriteLine("Je hebt het einde van de quiz bereikt.\nJe hebt " + quiztrys + " vragen goed beantwoord.");
                QuizOptie:
                string vraagOptie = Console.ReadLine();
                if (vraagOptie == "A")
                {
                    goto Optie;
                }
                else if (vraagOptie == "W")
                {
                    goto Einde;
                }
                else if (vraagOptie == "help")
                {
                    Console.WriteLine("A: andere opties\nW: weg gaan");
                    goto QuizOptie;
                }
                else if (vraagOptie == "C")
                {
                    Console.Clear();
                    goto Optie;
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
                        ApenOptie01:
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
                        else if (Apenoptie == "help")
                        {
                            Console.WriteLine("O: opnieuw\nA: andere opties\nW: weg gaan");
                            goto ApenOptie01;
                        }
                        else if (Apenoptie == "C")
                        {
                            Console.Clear();
                            goto Optie;
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
                    DobbelSteenOptie:
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
                    else if (Dobbeloptie01 == "help")
                    {
                        Console.WriteLine("O: opnieuw\nA: andere opties\nD: andere dobbelsteen opties\nW: weg gaan");
                        goto DobbelSteenOptie;
                    }
                    else if (Dobbeloptie01 == "C")
                    {
                        Console.Clear();
                        goto Optie;
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
                            DobbelSteenOptie01:
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
                            else if (dobbeloptie02 == "help")
                            {
                                Console.WriteLine("O: opnieuw\nA: andere opties\nD: andere dobbelsteen opties\nW: weg gaan");
                                goto DobbelSteenOptie01;
                            }
                            else if (dobbeloptie02 == "C")
                            {
                                Console.Clear();
                                goto Optie;
                            }
                }
            }
            else if (spelOptie == "R")
            {
                Reken:
                Console.WriteLine("Wil je 1. + - / * 2.PI");
                string eenTwee = Console.ReadLine();
                if (eenTwee == "1")
                {
                    goto een;
                }
                else if (eenTwee == "2")
                {
                    goto Twee;
                }
                een:
                double num01;
                double num02;
                Console.WriteLine("Voer een nummer in");

                num01 = Convert.ToDouble( Console.ReadLine() );
                Console.WriteLine("Voer een tweede nummer in");
                num02 = Convert.ToDouble( Console.ReadLine() );
                Console.WriteLine("\nWil Je * - + / ");
                string rekenOptie = Console.ReadLine();
                if (rekenOptie == "*")
                {
                    double result = num01 * num02;
                    Console.WriteLine("Het resultaat is " + result);
                    RekenEindeOptie:
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
                    else if (rekenEinde == "help")
                    {
                        Console.WriteLine("O: opnieuw\nA: andere opteis\nW: weg gaan");
                        goto RekenEindeOptie;
                    }
                    else if (rekenEinde == "C")
                    {
                        Console.Clear();
                        goto Optie;
                    }
                }
                else if (rekenOptie == "-")
                {
                    double result01 = num01 - num02;
                    Console.WriteLine("Het resultaat is " + result01);
                    RekenEindeOptie01:
                    string rekenEinde01 = Console.ReadLine();
                    if (rekenEinde01 == "O")
                    {
                        goto Reken;
                    }
                    else if (rekenEinde01 == "A")
                    {
                        goto Optie;
                    }
                    else if (rekenEinde01 == "W")
                    {
                        goto Einde;
                    }
                    else if (rekenEinde01 == "help")
                    {
                        Console.WriteLine("O: opnieuw\nA: andere opties\nW: weg gaan");
                        goto RekenEindeOptie01;
                    }
                    else if (rekenEinde01 == "C")
                    {
                        Console.Clear();
                        goto Optie;
                    }
                }
                else if (rekenOptie == "+")
                {
                    double result02 = num01 + num02;
                    Console.WriteLine("Het resultaat is "+ result02);
                    RekenEindeOptie02:
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
                    else if (rekenEinde02 == "help")
                    {
                        Console.WriteLine("O: opnieuw\nA: andere opties\nW: weg gaan");
                        goto RekenEindeOptie02;
                    }
                    else if (rekenEinde02 == "C")
                    {
                        Console.Clear();
                        goto Optie;
                    }
                }
                else if (rekenOptie == "/")
                {
                    double result03 = num01 / num02;
                    Console.WriteLine("Het resultaat is " + result03);
                    Console.WriteLine("\n");
                    RekenEindeOptie03:
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
                    else if (rekenEinde03 == "help")
                    {
                        Console.WriteLine("O: opnieuw\nA: andere opties\nW: weg gaan");
                        goto RekenEindeOptie03;
                    }
                    else if (rekenEinde03 == "C")
                    {
                        Console.Clear();
                        goto Optie;
                    }
                }
                Twee:
                double pi;
                Console.WriteLine("\nVul de diameter in");
                pi = Convert.ToDouble( Console.ReadLine() );

                double result04 = pi / 2;
                double result05 = result04 * result04 * 3.14159265359;

                Console.WriteLine("\nHet resultaat is " + result05);
                RekenEinde04:
                string rekenEinde04 = Console.ReadLine();
                if (rekenEinde04 == "O")
                {
                    goto Reken;
                }
                else if (rekenEinde04 == "A")
                {
                    goto Optie;
                }
                else if (rekenEinde04 == "W")
                {
                    goto Einde;
                }
                else if (rekenEinde04 == "help")
                {
                    Console.WriteLine("O: opnieuw\nA: andere opties\nW: weg gaan");
                    goto RekenEinde04;
                }
                else if (rekenEinde04 == "C")
                {
                    Console.Clear();
                    goto Optie;
                }
            }
            else if (spelOptie == "W")
            {
                goto Einde;
            }
            else if (spelOptie == "KL")
            {
                Console.WriteLine("Wil je de achtergrond veranderen?\n\n    Y/N");
                string AchtergrondOptie = Console.ReadLine();
                if (AchtergrondOptie == "Y")
                {
                    Kleur:
                    Console.WriteLine("Er zijn deze kleuren beschikbaar:\nWit , Zwart , Blauw , Rood , Cyaan , DonkerBlauw");
                    string KleurOptie = Console.ReadLine();
                    if (KleurOptie == "W")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        goto TesktKL01;
                    }
                    else if (KleurOptie == "Z")
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        goto TesktKL01;
                    }
                    else if (KleurOptie == "B")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        goto TesktKL01;
                    }
                    else if (KleurOptie == "R")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        goto TesktKL01;
                    }
                    else if (KleurOptie == "C")
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                       goto TesktKL01;
                    }
                    else if (KleurOptie == "DB")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        goto TesktKL01;
                    }
                    else if (KleurOptie == "help")
                    {
                        Console.WriteLine("\nW: wit\nZ: zwart\nB: blauw\nR: rood\nC: cyaan\nDB: donker blauw\n");
                        goto Kleur;
                    }
                }
                else if (AchtergrondOptie == "N")
                {
                    goto TesktKL01;
                }
                    TesktKL01:
                    Console.WriteLine("Wil je tekst kleur veranderen Y/N");
                    string TekstKL02 = Console.ReadLine();
                    if (TekstKL02 == "Y")
                    {
                        Console.WriteLine("Er zijn deze kleuren beschikbaar:\nWit , Zwart , Blauw , Rood , Cyaan");
                        string TEkstKleurOpties = Console.ReadLine();
                        if (TEkstKleurOpties == "W")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Optie;
                        }
                        else if (TEkstKleurOpties == "Z")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            goto Optie;
                        }
                        else if (TEkstKleurOpties == "B")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            goto Optie;
                        }
                        else if (TEkstKleurOpties == "R")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            goto Optie;
                        }
                        else if (TEkstKleurOpties == "C")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            goto Optie;
                        }
                    }
                    else if (TekstKL02 == "N")
                    {
                        goto Optie;
                    }
                
            }
            else if (spelOptie == "C")
            {
                Console.Clear();
                goto Optie;
            }
            else if (spelOptie == "help")
            {
                Console.WriteLine("\n Programma's");
                Console.WriteLine("------------------");
                Console.WriteLine("K: KaalQuiz\nN: Na-apen\nD: Dobbelsteen\nR: Rekenmachine\n");
                Console.WriteLine("\n Basic Optie's");
                Console.WriteLine("------------------");
                Console.WriteLine("O: opnieuw\nA: andere optie's\nC: scherm leegmaken\nW: weg gaan\nKL: kleur opties");
                goto Optie;
            }
            
            Einde:
            Console.WriteLine("Typ kaal om weg te gaan");
            EindeOptie01:
            string EindeOptie = Console.ReadLine();
            if (EindeOptie == "kaal")
            {

            }
            else if (EindeOptie == "help")
            {
                Console.WriteLine("\nA: andere opties\nW: weg gaan");
                goto EindeOptie01;
            }
            else if (EindeOptie == "A")
            {
                goto Optie;
            }
            else if (EindeOptie == "W")
            {
                goto Einde;
            }
            else if (EindeOptie != "kaal")
            {
                Console.WriteLine("Je moet kaal schrijven");
                goto EindeOptie01;
            }
        }
    }
}