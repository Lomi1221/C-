using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack

{
    class Program
    {
        static void Main(string[] args)
        {
            var karty = new List<Tuple<Kolor, Znak, Figura>>();






            /*
            string karta1 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta2 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta3 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta4 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta5 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta6 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta7 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta8 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta9 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta10 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta11 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta12 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta13 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta14 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta15 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta16 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta17 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta18 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta19 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta20 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta21 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta22 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta23 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta24 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta25 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta26 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta27 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta28 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta29 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta30 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta31 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta32 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta33 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta34 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta35 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta36 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta37 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta38 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta39 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta40 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta41 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta42 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta43 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta44 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta45 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta46 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta47 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta48 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta49 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta50 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta51 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            string karta52 = Kolor.Czarny.ToString() + " " + Znak.Trefl.ToString() + " " + Figura.As.ToString();
            */
            string karta1 = null;
            string karta2 = null;
            string karta3 = null;
            string karta4 = null;
            string karta5 = null;
            string karta6 = null;
            string karta7 = null;
            string karta8 = null;
            string karta9 = null;
            string karta10 = null;
            string karta11 = null;
            string karta12 = null;
            string karta13 = null;
            string karta14 = null;
            string karta15 = null;
            string karta16 = null;
            string karta17 = null;
            string karta18 = null;
            string karta19 = null;
            string karta20 = null;
            string karta21 = null;
            string karta22 = null;
            string karta23 = null;
            string karta24 = null;
            string karta25 = null;
            string karta26 = null;
            string karta27 = null;
            string karta28 = null;
            string karta29 = null;
            string karta30 = null;
            string karta31 = null;
            string karta32 = null;
            string karta33 = null;
            string karta34 = null;
            string karta35 = null;
            string karta36 = null;
            string karta37 = null;
            string karta38 = null;
            string karta39 = null;
            string karta40 = null;
            string karta41 = null;
            string karta42 = null;
            string karta43 = null;
            string karta44 = null;
            string karta45 = null;
            string karta46 = null;
            string karta47 = null;
            string karta48 = null;
            string karta49 = null;
            string karta50 = null;
            string karta51 = null;
            string karta52 = null;

            string[] kolejnokarty = { karta1, karta2, karta3, karta4, karta5, karta6, karta7,
            karta8, karta9, karta10, karta11, karta12, karta13, karta14, karta15, karta16, karta17,
            karta18, karta19, karta20, karta21, karta22, karta23, karta24, karta25, karta26, karta27,
            karta28, karta29, karta30, karta31, karta32, karta33, karta34, karta35, karta36, karta37,
            karta38, karta39, karta40, karta41, karta42, karta43, karta44, karta45, karta46, karta47,
            karta48, karta49, karta50, karta51, karta52};



            Random jakaśkarta = new Random();
            int numer = jakaśkarta.Next(0, kolejnokarty.Length - 1);
            int i = numer;
            string właściwakarta = "karta" + numer;

            if (numer == 0 - 3)
            {
                właściwakarta = Figura.As.ToString();
            }
            else if (numer == 4 - 7)
            {
                właściwakarta = Figura.Dwójka.ToString();
            }
            else if (numer == 8 - 11)
            {
                właściwakarta = Figura.Trójka.ToString();
            }

            else if (numer == 12 - 15)
            {
                właściwakarta = Figura.Czwórka.ToString();
            }

            else if (numer == 16-19)
            {
                właściwakarta = Figura.Piątka.ToString();
            }

            else if (numer == 20-23)
            {
                właściwakarta = Figura.Szóstka.ToString();
            }

            else if (numer == 24-27)
            {
                właściwakarta = Figura.Siódemka.ToString();
            }

            else if (numer == 28-31)
            {
                właściwakarta = Figura.Ósemka.ToString();
            }

            else if (numer == 32-35)
            {
                właściwakarta = Figura.Dziewiątka.ToString();
            }

            else if (numer == 36-39)
            {
                właściwakarta = Figura.Dziesiątka.ToString();
            }

            else if (numer == 40-43)
            {
                właściwakarta = Figura.Walet.ToString();
            }

            else if (numer == 44-47)
            {
                właściwakarta = Figura.Dama.ToString();
            }

            else if (numer == 48-51)
            {
                właściwakarta = Figura.Król.ToString();
            }
            if (numer % 2 == 0)
            {
                właściwakarta = właściwakarta + " " + $"{Kolor.Czarny}";
            }
            else
            {
                właściwakarta = właściwakarta + " " + $"{Kolor.Czerwony}";
            }
            if ((i + 1) % 4 == 0)
                {
                właściwakarta = właściwakarta + " " + Znak.Kier.ToString();
                }
                else if ((i + 1) % 3 == 0)
                {
                właściwakarta = właściwakarta + " " + Znak.Pik.ToString();
                }
                else if ((i + 1) % 2 == 0)
                {
                właściwakarta = właściwakarta + " " + Znak.Karo.ToString();

                }
                else
                {
                właściwakarta = właściwakarta + " " + Znak.Trefl.ToString();
                }
            Console.WriteLine(właściwakarta);
            /*
            for (i = 0; i < kolejnokarty.Length; i++)
            {
                if (i % 2 == 0)
                {
                    
                    kolejnokarty[i] = Kolor.Czarny.ToString();

                    
                }
                else
                {
                    kolejnokarty[i] = Kolor.Czerwony.ToString();
                }
                if (i + 1 % 4 == 0)
                {
                    kolejnokarty[i] = Znak.Kier.ToString();
                }
                else if (i + 1 % 3 == 0)
                {
                    kolejnokarty[i] = Znak.Pik.ToString();
                }
                else if (i + 1 % 2 == 0)
                {
                    kolejnokarty[i] = Znak.Karo.ToString();

                }
                else
                {
                    kolejnokarty[i] = Znak.Trefl.ToString();
                }
                Console.WriteLine(kolejnokarty[0]);
              
                // Console.WriteLine(kolejnokarty[numer]);
            */
                
            
        }
    }
}
