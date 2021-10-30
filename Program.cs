using System;

namespace ExercisesOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozwiązania drugich ćwiczeń.");
            Console.WriteLine("Aby sprawdzić poszczególne zadanie wybierz z poniższych opcji.");
            Console.WriteLine("1. Sprawdzenie równości,");
            Console.WriteLine("2. Sprawdzanie parzystości,");
            Console.WriteLine("3. Sprawdzanie dodatności,");
            Console.WriteLine("4. Sprawdzanie przestępności roku,");
            Console.WriteLine("5. Sprawdzanie dostateczności wieku na różne stanowiska,");
            Console.WriteLine("6. Kategoryzacja za pomocą zwrostu,");
            Console.WriteLine("7. Wytypowywanie największej liczby,");
            Console.WriteLine("8. Sprawdzanie dosstatecznej ilości punktów na studia,");
            Console.WriteLine("9. Kategoryzacja temeperatury,");
            Console.WriteLine("10. Sprawdzanie możliwwości stworzenia trójkąta,");
            Console.WriteLine("11. Podmiana oceny na jej opis,");
            Console.WriteLine("12. Nazywanie dni tygodnia,");
            Console.WriteLine("13. Kalkulator");
            while (true)
            {
                    byte givenChoice = byte.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    byte choice = givenChoice;
                    switch (choice)
                    {
                        case 1:
                            //1.  Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są 
                            //one równe czy nie. Dane testowe: a:5 b:5 Rezultat w terminalu: 5 i 5 są równe
                            int a = 5;
                            int b = 5;
                            if (a == b)
                            {
                                Console.WriteLine("a(5) i b(5) są równe.");
                            }
                            else
                            {
                                Console.WriteLine("a(5) i b(5) nie są równe.");
                            }
                            Console.WriteLine("");
                            break;

                        case 2:
                            //2.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba 
                            //jest parzysta czy nieparzysta. Dane testowe : 15 Rezultat w terminalu:
                            //15 jest liczbą nieparzystą
                            float c;
                            //float wynik2;
                            Console.WriteLine("Program sprawdza parzystość.");
                            Console.WriteLine("Podaj dowolną liczbę całkowitą.");
                            c = float.Parse(Console.ReadLine());
                            if (c % 2 == 0)
                            {
                                Console.WriteLine("Podana liczba {0} jest parzysta", c);
                            }
                            //else if (wynik2 != 0 && wynik2 != 5)
                            //{
                            //    Console.WriteLine("Podana liczba nie jest liczbą całkowitą!");
                            //}
                            else
                            {
                                Console.WriteLine("Podana liczba {0} nie jest parzysta", c);
                            }
                            Console.WriteLine("");
                            break;

                        case 3:
                            //3.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba 
                            //jest dodatnia czy ujemna. Dane testowe : 14 Rezultat w terminalu:
                            //14 jest liczbą dodatnią
                            float d;
                            Console.WriteLine("Program sprawdza dodatność.");
                            Console.WriteLine("Podaj dowolną liczbę.");
                            d = float.Parse(Console.ReadLine());
                            if (d > 0)
                            {
                                Console.Write("Podana liczba {0} jest dodatnia.", d);
                            }
                            else if (d < 0)
                            {
                                Console.Write("Podana liczba {0} nie jest dodatnia.", d);
                            }
                            Console.WriteLine("");
                            break;

                        case 4:
                            //  4.Napisz program w C#, który sprawdzi czy podany przez użytkownika rok 
                            //jest rokiem przestępnym. Dane testowe : 2016 Rezultat w terminalu:
                            //2016 jest rokiem przestępnym
                            //"Rok przestępny wypada średnio co 4 lata, jednak nie jest to regułą.
                            //Latami przestępnymi są te, których numeracja jest podzielna przez 4
                            //i niepodzielna przez 100 lub jest podzielna przez 400.Oznacza to, że m.in.
                            //lata 1600 i 2000 były przestępnymi, a lata 1700, 1800, 1900 nie."
                            short e;
                            Console.WriteLine("Program sprawdza pzestępność roku.");
                            Console.WriteLine("Podaj dowolny rok.");
                            e = short.Parse(Console.ReadLine());
                            if (0 == e % 4 && 0 != e % 100 || 0 == e % 400)
                            {
                                Console.WriteLine("{0} jest rokiem przestępnym.", e);
                            }
                            else
                            {
                                Console.WriteLine("{0} nie jest rokiem przestępnym.", e);
                            }
                            Console.WriteLine("");
                            break;

                        case 5:
                            //5.Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek 
                            //uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
                            //prezydenta. Dane testowe : 21 Rezultat w terminalu: Możesz zostać posłem.
                            //poseł-21, senator-30, prezydent-35
                            byte f;
                            string f1, f2, f3;
                            f1 = "posła";
                            f2 = "senatora";
                            f3 = "prezydenta";
                            Console.WriteLine("Program stwierdza czy jest dostateczny wiek do pełnienia poszczególnych funkcji państwowych");
                            f = byte.Parse(Console.ReadLine());
                            if (f >= 35)
                            {
                                Console.WriteLine("Jest to dostateczny wiek na pełnienie funkcji:");
                                Console.WriteLine("-{0},", f1);
                                Console.WriteLine("-{0},", f2);
                                Console.WriteLine("-{0}", f3);
                            }
                            else if (f >= 30)
                            {
                                Console.WriteLine("Jest to dostateczny wiek na pełnienie funkcji:");
                                Console.WriteLine("-{0},", f1);
                                Console.WriteLine("-{0}", f2);
                            }
                            else if (f >= 21)
                            {
                                Console.WriteLine("Jest to dostateczny wiek na pełnienie funkcji:");
                                Console.WriteLine("-{0}", f1);
                            }
                            else
                            {
                                Console.WriteLine("Chyba nie da rady - młodość też ma swoje zalety ;)");
                            }
                            Console.WriteLine("");
                            break;

                        case 6:
                            //6.Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu 
                            //wymyśloną kategorię wzrostu. Dane testowe : 140 Rezultat w terminalu: Jesteś krasnoludem
                            short g, g1, g2;
                            g1 = 1;
                            g2 = 2;
                            Console.WriteLine("Kim ty tak naprawdę jesteś!?");
                            Console.WriteLine("");
                            Console.WriteLine("Wybierz, czy chcesz podać zwrost w milimetrach ({0}), czy centymetrach ({1})", g1, g2);
                            g = short.Parse(Console.ReadLine());
                            if (g == 2)
                            {
                                Console.WriteLine("Teraz podaj zwrost w cm.");
                                g = short.Parse(Console.ReadLine());
                                if (g < 90)
                                {
                                    Console.WriteLine("Jeteś małym, a podstępnym cwaniaczkiem!");
                                }
                                else if (g < 120)
                                {
                                    Console.WriteLine("Jeteś krasnoludkim.");
                                }
                                else if (g < 160)
                                {
                                    Console.WriteLine("Jesteś dużym łobuzem.");
                                }
                                else if (g < 180)
                                {
                                    Console.WriteLine("Jesteś starym kuniem...");
                                }
                                else if (g < 200)
                                {
                                    Console.WriteLine("O ty kulasie jeden...");
                                }
                                else if (g < 300)
                                {
                                    Console.WriteLine("Za małe progi na te w huj duże nogi.");
                                }
                            }
                            else if (g == 1)
                            {
                                g = short.Parse(Console.ReadLine());
                                Console.WriteLine("Teraz podaj zwrost w mm.");
                                if (g < 900)
                                {
                                    Console.WriteLine("Jeteś małym, a podstępnym cwaniaczkiem!");
                                }
                                else if (g < 1200)
                                {
                                    Console.WriteLine("Jeteś krasnoludkim.");
                                }
                                else if (g < 1600)
                                {
                                    Console.WriteLine("Jesteś dużym łobuzem.");
                                }
                                else if (g < 1800)
                                {
                                    Console.WriteLine("Jessteś starym kuniem...");
                                }
                                else if (g < 2000)
                                {
                                    Console.WriteLine("O ty kulasie jeden...");
                                }
                                else if (g < 3000)
                                {
                                    Console.WriteLine("Za małe progi na te w huj duże nogi.");
                                }
                            }
                            Console.WriteLine("");
                            break;

                        case 7:
                            //7.Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, 
                            //która jest największa. Dane testowe: 25, 63, 79. Rezultat w terminalu: 79 jest największa z podanych
                            float h1, h2, h3;
                            Console.WriteLine("Program stwierdza, która z podanych liczb jest największa.");
                            Console.WriteLine("");
                            Console.WriteLine("Podaj dowolne 3 liczby.");
                            h1 = float.Parse(Console.ReadLine());
                            h2 = float.Parse(Console.ReadLine());
                            h3 = float.Parse(Console.ReadLine());
                            if (h1 > h2 && h1 > h3)
                            {
                                Console.WriteLine("Największa liczbą jest {0}", h1);
                            }
                            if (h2 > h1 && h2 > h3)
                            {
                                Console.WriteLine("Największa liczbą jest {0}", h2);
                            }
                            if (h3 > h1 && h3 > h2)
                            {
                                Console.WriteLine("Największa liczbą jest {0}", h3);
                            }
                            Console.WriteLine("");
                            break;

                        case 8:
                            //8.Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach 
                            //wg. Następujących kryteriów: Wynik z Matury z matematyki powyżej 70 Wynik z fizyki 
                            //powyżej 55 Wynik z chemii powyżej 45 Łączny wynik z 3 przedmiotów powyżej 180 Albo 
                            //Wynik z matematyki i jednego przedmiotu powyżej 150 Dane testowe: Matematyka 80 
                            //Fizyka 71 Chemia 0 Rezultat w terminalu: Kandydat dopuszczony do rekrutacji
                            byte i1, i2, i3;
                            int min1, min2;
                            min1 = 180;
                            min2 = 150;
                            Console.WriteLine("Już po maturze? Sprawdź swoją możność pójścia na studia!");
                            Console.WriteLine("");
                            Console.WriteLine("Podaj wynik z cz. matematycznej.");
                            i1 = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj wynik z cz fizycznej.");
                            i2 = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj wynik z cz chemicznej.");
                            i3 = byte.Parse(Console.ReadLine());
                            if (i1 > 70 && i2 > 55 && i3 > 45)
                            {
                                Console.WriteLine("Kandydant dopuszczony do rekrutacji.");
                            }
                            else if (min1 <= i1 + i2 + i3)
                            {
                                Console.WriteLine("Kandydant dopuszczony do rekrutacji.");
                            }
                            else if (min2 == i1 + i2 || min2 == i1 + i2)
                            {
                                Console.WriteLine("Kandydant dopuszczony do rekrutacji.");
                            }
                            else
                            {
                                Console.WriteLine("Zbyt mało punktów - kandydant niedopuszczony do rekrutacji.");
                            }
                            Console.WriteLine("");
                            break;

                        case 9:
                            //9.Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach Temp < 0 – cholernie piździ
                            //Temp 0 – 10 – zimno Temp 10 – 20 – chłodno Temp 20 – 30 – w sam raz Temp 30 – 40 – zaczyna być słabo, bo gorąco
                            //Temp >= 40 – a weź wyprowadzam się na Alaskę. Dane testowe : 41 Rezultat w terminalu: a weź wyprowadzam się na Alaskę.
                            sbyte j, j1;
                            Console.WriteLine("Jaka panuje temperatura? Czy wiesz co to znaczy, jak sie zachować???");
                            Console.WriteLine("");
                            Console.WriteLine("Tak (1), Nie (2).");
                            j = sbyte.Parse(Console.ReadLine());
                            if (j == 1)
                            {
                                Console.WriteLine("To spadaj na dzewo!");
                            }
                            else if (j == 2)
                            {
                                Console.WriteLine("Jak ją podasz w Cencjusach, to się dowiesz.");
                                j1 = sbyte.Parse(Console.ReadLine());
                                if (j1 <= -20)
                                {
                                    Console.WriteLine("Jak to jest być soplem lodu...?");
                                }
                                else if (j1 <= 0)
                                {
                                    Console.WriteLine("Cholernie piździ!");
                                }
                                else if (j1 <= 10)
                                {
                                    Console.WriteLine("Ziąmb.");
                                }
                                else if (j1 <= 20)
                                {
                                    Console.WriteLine("Zasadniczo jest rześko.");
                                }
                                else if (j1 <= 30)
                                {
                                    Console.WriteLine("Nie ma co narzekac.");
                                }
                                else if (j1 <= 40)
                                {
                                    Console.WriteLine("Albo jedziesz na plaże albo spi*r*a*aj!");
                                }
                                else if (j1 <= 45)
                                {
                                    Console.WriteLine("A może tak posmażyć słoneczku jajeczka?");
                                }
                                else
                                {
                                    Console.WriteLine("A mam wyj*bane... Pakuje się na Alske!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wać raczy uczyć się czytać?");
                            }
                            Console.WriteLine("");
                            break;

                        case 10:
                            //10.Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt 
                            //Dane testowe: 40 55 65 Rezultat w terminalu: Można zbudować trójkąt
                            float k1, k2, k3;
                            Console.WriteLine("Sprawdź czy z konkretnych trzech odcinków możesz stworzyć trójkat.");
                            Console.WriteLine("");
                            Console.WriteLine("Podaj te długości.");
                            k1 = float.Parse(Console.ReadLine());
                            k2 = float.Parse(Console.ReadLine());
                            k3 = float.Parse(Console.ReadLine());
                            if (k1 > 0 && k2 > 0 && k3 > 0)
                            {
                                if ((k1 < k2 + k3 && k1 > k2 && k1 > k3) || (k2 < k1 + k3 && k2 > k1 && k2 > k3) || (k3 < k1 + k2 && k3 > k1 && k3 > k2))
                                {
                                    Console.WriteLine("Z tych odcinków możesz stworzyć trójkąt.");
                                }
                                else
                                {
                                    Console.WriteLine("Z tych odcinków nie możesz stworzyć trójkątk. Najdłuższ odcinek powienien być krótszy ");
                                    Console.WriteLine("niż pozostałe dwa razem wzięte lub być równie długi co drugi i nawet trzeci.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Że z czego ty chcesz trójkąt??? Może w innym życiu...");
                            }
                            Console.WriteLine("");
                            break;

                        case 11:
                            //11.Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
                            //Ocena Opis 6 Celujący 5 Bardzo dobry 4 Dobry 3 Dostateczny 2 Dopuszczający 1
                            //Niedostateczny Dane testowe: 3 Rezultat w terminalu: Dostateczny
                            byte l;
                            Console.WriteLine("Zamień cyfrową ocenę ucznia na opisową.");
                            Console.WriteLine("");
                            Console.WriteLine("Podaj ocenę.");
                            l = byte.Parse(Console.ReadLine());
                            if (l == 1)
                            {
                                Console.WriteLine("Niedostateczny");
                            }
                            else if (l == 2)
                            {
                                Console.WriteLine("Dopuszczający");
                            }
                            else if (l == 3)
                            {
                                Console.WriteLine("Dostateczny");
                            }
                            else if (l == 4)
                            {
                                Console.WriteLine("Dobry");
                            }
                            else if (l == 5)
                            {
                                Console.WriteLine("Bardzo dobry");
                            }
                            else if (l == 6)
                            {
                                Console.WriteLine("Celujący");
                            }
                            else
                            {
                                Console.WriteLine("Człowieku, na jakim ty świecie żyjesz???");
                            }
                            Console.WriteLine("");
                            break;

                        case 12:
                            //12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę Dane testowe: 4
                            //Rezultat w terminalu: Czwartek
                            byte m;
                            Console.WriteLine("Który z kolei dzień tygodnia jak się nazywa?");
                            Console.WriteLine("");
                            Console.WriteLine("Podaj numer dnia tygodnia od 1 do 7");
                            m = byte.Parse(Console.ReadLine());
                            if (m == 1)
                            {
                                Console.WriteLine("Pierwszy z kolei to poniedziałek!");
                            }
                            else if (m == 2)
                            {
                                Console.WriteLine("Drugi z kolei to wtorek!");
                            }
                            else if (m == 3)
                            {
                                Console.WriteLine("Trzecia z kolei to środa!");
                            }
                            else if (m == 4)
                            {
                                Console.WriteLine("Czwarty z kolei to czwartek!");
                            }
                            else if (m == 5)
                            {
                                Console.WriteLine("Piąty z kolei to piątek!");
                            }
                            else if (m == 6)
                            {
                                Console.WriteLine("Szósta z kolei to sobota!");
                            }
                            else if (m == 7)
                            {
                                Console.WriteLine("Siódma z kolei to niedziela!");
                            }
                            else
                            {
                                Console.WriteLine("Wać raczy uczyć się czytać???");
                            }
                            Console.WriteLine("");
                            break;

                        case 13:
                            //13.Napisz program, który będzie posiadał proste menu i będzie prostym kalkulatorem
                            double n1, n2, wynik;
                            byte n;
                            Console.WriteLine("KALKULATOR");
                            Console.WriteLine("");
                            Console.WriteLine("Podaj pierwszą liczbę");
                            n1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj drugą liczbę");
                            n2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj numer operacji do wykonania.");
                            Console.WriteLine("     1. Dodawanie");
                            Console.WriteLine("     2. Odejmowanie");
                            Console.WriteLine("     3. Mnożenie");
                            Console.WriteLine("     4. Dzielenie");
                            Console.WriteLine("");
                            n = byte.Parse(Console.ReadLine());
                            if (n == 1)
                            {
                                wynik = n1 + n2;
                                Console.WriteLine("Otrzyłeś {0}", wynik);
                            }
                            else if (n == 2)
                            {
                                wynik = n1 - n2;
                                Console.WriteLine("Otrzymałeś {0}", wynik);
                            }
                            else if (n == 3)
                            {
                                wynik = n1 * n2;
                                Console.WriteLine("Otrzymałeś {0}", wynik);
                            }
                            else if (n == 4)
                            {
                                if (n2 != 0)
                                {
                                    wynik = n1 / n2;
                                    Console.WriteLine("Otrzymałeś {0}", wynik);
                                }
                                else
                                {
                                    Console.WriteLine("Amewo nie dziel przez ZERO!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wać raczy uczyć się czytać???");
                            }
                            Console.WriteLine("");
                            break;

                        default:
                            Console.WriteLine("ERROR! Wybrano inną liczbe!");
                            break;

                    }//switch
                    Console.WriteLine("Sprawdź kolejne ćwiczenie lub zakończ wpisując hasło!");
                string endOfWork;
                endOfWork = Console.ReadLine();
                if (endOfWork == "end")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Niepoprawne hasło kończące!");
                }

            }//while 
        }
    }
}
