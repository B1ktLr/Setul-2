using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Set_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
            bool e = true;
            Console.WriteLine("Lista exerciti:");
            Console.WriteLine("0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17");
            while (e)
            { 
                Console.Write("Introduceti exercitiul:");
                opt = int.Parse(Console.ReadLine());
                switch (opt) 
                {
                    case 0:
                        Console.WriteLine("Iesire");
                        e = false;
                        break;
                        case 1:
                        {
                            E1(); break;
                        }
                        case 2:
                        {
                            E2(); break;
                        }
                        case 3:
                        {
                            E3(); break;
                        }
                        case 4: 
                        {
                            E4(); break;
                        }
                        case 5:
                        { 
                            E5(); break;
                        }
                        case 6:
                        {
                            E6(); break;
                        }
                        case 7:
                        {
                            E7(); break;
                        }
                        case 8:
                        {
                            E8(); break;
                        }
                        case 9:
                        {
                            E9(); break;
                        }
                        case 10:
                        {
                            E10(); break;
                        }
                        case 11:
                        {
                            E11(); break;
                        }
                        case 12:
                        {
                            E12(); break;
                        }
                        case 13:
                        {
                            E13(); break;
                        }
                        case 14:
                        {
                            E14(); break;
                        }
                        case 15:
                        {
                            E15(); break;
                        }
                        case 16:
                        {
                            E16(); break;
                        }
                        case 17:
                        {
                            E17(); break;
                        }
                }
            }


        }

        private static void E17()
        {
            int n, x, eroare = 0, a, max;
            bool ok = true;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numerele:");

            x = int.Parse(Console.ReadLine());
            if (x == 0)
                eroare++;
            else
                eroare--;

            if (eroare < 0)
            {
                ok = false;
            }
            a = x; max = 0;

            for (int c = 0; c < n-1; c++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                    eroare++;
                else
                    eroare--;

                if (eroare < 0)
                {
                    ok = false;
                }
                if (x == a)
                    max++;
                else
                    a = x;
            }
            if (ok == false)
                Console.WriteLine("Incorect");
            else
            {
                Console.WriteLine("Corect");
                Console.WriteLine("Nivelul maxim de incuibare este " + max);
            }
            Console.ReadKey();
        }

        private static void E16()
        {
            int n, x, a, eroare=0, cres=0, desc=0;
            bool d=false,c=false;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            x = int.Parse(Console.ReadLine());
            a = x;
            for(int i = 1; i < n; i++)
            {
                x= int.Parse(Console.ReadLine());

                if (x > a)
                {
                    c = true;
                    eroare++;
                }

                if (x < a)
                {
                    d = true;
                    eroare--;
                }

                if (d && c)
                {
                    d = false;
                    c = false;
                }

                if (eroare < 0)
                    desc = 1;

                if (eroare > 0)
                    cres = 1;

                a = x;
                eroare = 0;
            }
            if ((cres == 1 && desc == 2) || (cres == 2 && desc == 1) || (cres == 1 && desc == 1))
                Console.WriteLine("Sirul este bitonic rotit");
            else
                Console.WriteLine("Sirul NU este bitonic rotit");

            Console.ReadKey();
        }

        private static void E15()
        {
            int n, x, a;
            bool d = false, bit=false, c=false;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            x = int.Parse(Console.ReadLine());
            a = x;
            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= a && d == false)
                    c=true;

                if (x < a)
                    d = true;

                if (d == true && (x <= a))
                    bit = true;

                if(c==false)
                    bit = false;

                if(c == false)
                    bit = false;

                if (d == true && (x > a))
                    bit = false;

                a = x;
            }
            if (bit==true)
                Console.WriteLine("Sirul este bitonic");
            else 
                Console.WriteLine("Sirul NU e bitonic");

            Console.ReadKey();
        }

        private static void E14()
        {
            int n, x, a, b,eroare=0;
            bool d = false, c = false;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            x = int.Parse(Console.ReadLine());
            a = x;
            b = x;
            x = int.Parse(Console.ReadLine());
            if (a >= x)
            {
                d = true;
            }
            if (a <= x)
            {
                c = true;
            }
            a = x;
            for (int i = 2; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (d == true)
                {
                    if (a <= x && x <= b)
                    {
                        //desc
                        eroare++;
                    }
                    else
                    {
                        if (a <= x && x >= b)
                        {
                            eroare = 2;
                        }
                    }
                    
                }

                if (c == true)
                {
                    if (a >= x && x >= b)
                    {
                        //cresc
                        eroare++;
                    }
                    else
                    {
                        if (a >= x && x <= b)
                        {
                            eroare = 2;
                        }
                    }
                    
                }

                  a = x;
            }
            if (eroare > 1)
            {
                if( c == true)
                    Console.WriteLine("Sirul NU e monoton crescator rotit");      
                if(d == true)
                    Console.WriteLine("Sirul NU e monoton descrescator rotit");
            }
            if(eroare <= 1)
            {
                if(c==true)
                Console.WriteLine("Sirul e monoton crescator rotit");
                if(d==true)
                Console.WriteLine("Sirul e monoton descrescator rotit");
            }
            Console.ReadKey();
            
        }

        private static void E13()
        {
            int n, x, a, b, eroare=0;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            x = int.Parse(Console.ReadLine());
            a = x;
            b = x;
            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (a > x && x > b)
                {
                    eroare++;
                }
                else
                    if(a > x && x < b)
                    eroare = 2;

                a = x;
            }
            if (eroare > 1)
                Console.WriteLine("Sirul NU e crescator rotit");
            else
                Console.WriteLine("Sirul e crescator rotit");
            Console.ReadKey();
        }

        private static void E12()
        {
            int n, x, g=0;
            bool ag=false;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x != 0)
                {
                    if(ag == false)
                    {
                        ag = true;
                        g++;
                    }
                }
                else 
                { 
                    ag = false;
                }
            }
            Console.WriteLine("Sunt " + g + " grupuri de numere consecutive diferite de zero");
            Console.ReadKey();
        }

        private static void E11()
        {
            int n, x, inv, s=0;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                inv = 0;
                while (x != 0)
                {
                    inv = inv*10+x%10;
                    x=x/10;
                }
                s=s+inv;
            }
            Console.WriteLine("Suma inverselor numerelor este " + s);
            Console.ReadKey();
        }
        private static void E10()
        {
            int n, x, a, e=1, max=-1;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            x = int.Parse(Console.ReadLine());
            a = x;
            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (a == x)
                {
                    e++;
                }
                if(max<e)
                {
                    max = e;
                }
                if(a != x)
                {
                    e = 1;
                }
                a = x;
            }
            Console.WriteLine("Numarul maxim de numere consecutive egale din secventa este " + max);
            Console.ReadKey();
        }

        private static void E9()
        {
            int n, x, a;
            bool d=false,c=false;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            x = int.Parse(Console.ReadLine());
            a = x;
            x=int.Parse(Console.ReadLine());
            if (a >= x)
            {
                d = true;
            }
            if (a <= x)
            {
                c = true;
            }
            a = x;
            for (int i = 2; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (d == true && a >= x)
                {
                    //desc
                    a = x;
                }
                else
                d= false;
                if(c == true && a <= x)
                {
                    //cresc
                    a = x;
                }
                else
                c = false;
            }
            if (c == true)
            {
                Console.WriteLine("Sirul e monoton crescator");
            }
            if (d == true)
            {
                Console.WriteLine("Sirul e monoton descrescator");
            }
            if (c == false && d == false)
            {
                Console.WriteLine("Sirul nu e monoton");
            }
            Console.ReadKey();
        }

        private static void E8()
        {
            int n, f1=0, f2=1, f3=1;
            Console.Write("Dati al catelea numar din sirul lui fibonaci doriti sa il vedeti:");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n/3; i++)
            {
                f3 = f2 + f1;
                f1= f3 + f2;
                f2= f3 + f1;
            }
            if (n%3 == 0)
                Console.WriteLine(f3);
            if (n%3 == 1)
                Console.WriteLine(f1);
            if ((n%3) == 2)
                Console.WriteLine(f2);
            Console.ReadKey();
        }

        private static void E7()
        {
            int n, x, max, min;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            x = int.Parse(Console.ReadLine());
            min = x;
            max = x;
            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (min>x)
                { min = x; }
                if(max<x)
                { max = x; }
            }
            Console.WriteLine("Valoarea maxima din sir este " + max + " si valoarea minima din sir este " + min);
            Console.ReadKey();
        }

        private static void E6()
        {
            int n, x, a;
            bool e = true;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            x= int.Parse(Console.ReadLine());
            a = x;
            for (int i = 1;i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (a>x)
                {
                    e= false;
                }
                a = x;
            }
            if (e == true)
                Console.WriteLine("Sirul e crescator");
            else
                Console.WriteLine("Sirul NU e crescator");

            Console.ReadKey();
        }
        private static void E5()
        {
            int n, x, a, p = 0;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == i)
                {
                    p++;
                }
            }
            Console.WriteLine(p + " numere se afla pe pozitia cu valoare egala cu a lor");
            Console.ReadKey();
        }
        private static void E4()
        {
            int n, x, a, p=-1;
            Console.WriteLine("Dati un numarul de numere din sir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati un numar a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == a)
                {
                    p = i;
                }
            }
            if (p > 0)
                Console.WriteLine("Numarul 'a' se afla pe pozitia " + p);
            else Console.WriteLine(p);
            Console.ReadKey();
        }
        private static void E3()
        {
            int n, s = 0, p = 1;
            Console.WriteLine("Dati un numar n");
            n= int.Parse(Console.ReadLine());
            for(int i = 1; i <= n;i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.WriteLine("Suma numerelor de al 1 la n este " +  s + " si produsul " + p);
        }

        private static void E2()
        {
            int n, x, p = 0, c = 0, k = 0;
            Console.WriteLine("Dati numarul de numere:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            for (int i = 0; i < n; i++)
            {
                x= int.Parse(Console.ReadLine());
                if (x == 0)
                    k++;
                if (x < 0)
                    c++;
                if (x > 0)
                    p++;
            }
            Console.WriteLine(k + " numere egale cu zero");
            Console.WriteLine(p + " numere pozitive");
            Console.WriteLine(c + " numere negative");
            Console.ReadKey();
        }

        private static void E1()
        {
            int n, x, c=0;
            Console.WriteLine("Dati numarul de numere:");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numere:");
            for(int i = 0; i < n; i++) 
            {
            x=int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    c++;
            }
            Console.WriteLine(c + " numere sunt pare");
            Console.ReadKey();
        }
    }
}
