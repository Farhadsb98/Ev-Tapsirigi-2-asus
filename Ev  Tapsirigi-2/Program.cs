using System.Diagnostics.CodeAnalysis;

namespace Ev__Tapsirigi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region taks 1
        //l1:
        //    Console.WriteLine("4 reqemli ededi daxil edin");
        //    string strvalue = Console.ReadLine();
        //    bool tru = int.TryParse(strvalue, out int value);
        //    int say = (int)Math.Log10((int)value) + 1;
        //    if (!tru)
        //    {
        //        goto l1;
        //    }
        //    if (say != 4)
        //    {
        //        goto l1;
        //    }
        //    int sum = 0;
        //    while (value>0)
        //    {
        //        int resudie = value % 10;
        //        value /= 10;
        //        sum += resudie;
        //    }
        //    Console.WriteLine(sum);
        #endregion
        #region Task2
        //l1:
        //    Console.Write("6 reqemli ededi daxil edin:");
        //    string streded=Console.ReadLine();
        //    bool yoxla = int.TryParse(streded, out int eded);


        //    if (!yoxla) 
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(eded) + 1 != 6)
        //    {
        //        goto l1;
        //    }
        //    eded /= 1000;
        //    int sum=0;
        //    while (eded>0)
        //    {
        //        int qaliq = eded % 10;
        //        eded=eded / 10;
        //        sum+=qaliq;

        //    }
        //    Console.WriteLine(sum);
        #endregion

        #region task3
        //l1:
        //    Console.Write("9 reqemli ededi daxil edin:");
        //    string streded = Console.ReadLine();
        //    bool yoxla = int.TryParse(streded, out int eded);


        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(eded) + 1 != 9)
        //    {
        //        goto l1;
        //    }
        //    eded /= 1000;
        //    int sum = 0;
        //    while (eded>999)
        //    {
        //        int qaliq = eded % 10;
        //        eded = eded / 10;
        //        sum += qaliq;

        //    }
        //    Console.WriteLine(sum);

        #endregion

        #region task4 

        //l1:
        //    Console.Write("5 reqemli ededi daxil edin:");
        //    string streded = Console.ReadLine();
        //    bool yoxla = int.TryParse(streded, out int eded);


        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(eded) + 1 != 5)
        //    {
        //        goto l1;
        //    }
        //   int  qaliq1 = eded % 10;
        //    eded /= 10000;
        //   int sum= qaliq1 + eded;

        //    Console.WriteLine(sum);
        #endregion

        #region taks 5
        //l1:
        //    Console.WriteLine("6 reqemli ededi daxil edin");
        //    string strvalue = Console.ReadLine();
        //    bool tru = int.TryParse(strvalue, out int value);
        //    int say = (int)Math.Log10((int)value) + 1;
        //    if (!tru)
        //    {
        //        goto l1;
        //    }
        //    if (say != 6)
        //    {
        //        goto l1;
        //    }

        //   int valueilk= value / 100000;
        //    int resudie = value % 100000;
        //    int final = resudie * 10 + valueilk;
        //    Console.WriteLine(final);
        #endregion

        #region task6
        //l1:
        //Console.Write("8 reqemli ededi daxil edin:");
        //string streded = Console.ReadLine();
        //bool yoxla = int.TryParse(streded, out int eded);


        //if (!yoxla)
        //{
        //    goto l1;
        //}
        //if ((int)Math.Log10(eded) + 1 != 8)
        //{
        //    goto l1;
        //}
        //int qaliq1 = eded % 10;
        //int qaliq2 = eded / 10000000;
        //int sum=(eded - qaliq2 * 10000000 - qaliq1) / 10;
        //Console.WriteLine(sum);

        #endregion


        #region taks 7 verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
        //l1:
        //Console.WriteLine("4 reqemli eded daxil edin");
        //string streded=Console.ReadLine();
        //bool say= int.TryParse(streded, out int eded);
        //if (!say)
        //{
        //    goto l1;
        //}

        //int sum= 0;
        //while (eded>0)
        //{
        //    int qaliq = eded % 10;
        //    eded=eded/10;
        //    sum = sum * 10 + qaliq;

        //}
        //decimal add = (8 * 10000 + sum)*10+8;
        //Console.WriteLine(add);

        #endregion

        #region task 8  Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  

        //Console.WriteLine("4 reqemli eded daxil edin");
        //string streded = Console.ReadLine();
        //bool say = int.TryParse(streded, out int eded);
        //if (!say)
        //{
        //    goto l1;
        //}

        //int qaliq = eded % 10;
        //int qaliq3 = eded % 1000;
        //int eded3=qaliq3/ 100;
        //int cem = qaliq + eded3;
        //Console.WriteLine(cem);

        #endregion

        #region taks9
        //l1:
        //Console.WriteLine("Eded daxil edin:");


        //int eded, sum ,newnumber;

        //if (!int.TryParse(Console.ReadLine(), out eded))

        //{
        //    goto l1;
        //}
        //sum = 0;
        //newnumber= 0;

        //while (eded > 0)
        //{
        //    int qaliq = eded % 10;
        //    eded /= 10;
        //    sum++;
        //    if (sum%2==0)
        //    {
        //        newnumber += qaliq * (int)Math.Pow(10, sum / 2 - 1);
        //    }

        //}
        //Console.WriteLine(newnumber);



        #endregion

        #region taks10
        //l1:
        //    Console.WriteLine("9 reqemli ededi daxil edin");

        //    int eded, sum, sum2,sum3,sum4;

        //    if (!int.TryParse(Console.ReadLine(), out eded))

        //    {
        //        goto l1;
        //    }
        //    if (eded < 100000000 && eded > 9999999)
        //    {
        //        Console.WriteLine("eded 9 reqemli deyil");
        //        goto l1;
        //    }
        //    sum = 0;

        //    sum3 = 0;
        //    sum4 = 0;
        //    while (eded>0)
        //    {
        //        int qaliq = eded % 10;
        //        eded /= 10;
        //        sum = sum * 10 + qaliq;


        //    }
        //   sum2=sum;

        //    while (sum2 > 0)
        //    {


        //        int qaliq3 = sum2 % 10;
        //        sum2 /= 100;
        //        sum4 = sum4 * 10 + qaliq3;


        //    }

        //    sum /= 10;
        //    while (sum> 0)
        //    {

        //        int qaliq2 = sum % 10;
        //        sum /= 100;
        //        sum3 = sum3 * 10 + qaliq2;


        //    }




        //    int final = sum2 + sum3;
        //    Console.WriteLine(sum4);
        //    Console.WriteLine(sum3);


        #endregion

        #region task11
        //l1:
        //    Console.WriteLine("8 reqemli eded daxil edin:");
        //    string strvalue=Console.ReadLine();
        //    bool tru=int.TryParse(strvalue, out int value);
        //    int say = (int)Math.Log10(value)+1;
        //    if (!tru)
        //    {
        //        goto l1;

        //    }
        //    if (say!=8)
        //    {
        //        goto l1;
        //    }
        //   int sum = 0;
        //    while (value>0)
        //    {
        //        int residue = value % 100;
        //        value/= 100;
        //        sum += residue; 
        //    }
        //    int newsum=sum*100+99;
        //    double faiz = (double)newsum * 18 / 100;
        //    double final=(double)newsum-faiz;
        //    Console.WriteLine(final);
        #endregion

        #region task12
        //l1:
        //    Console.WriteLine("1-ci 5 reqemli ededi daxil edin");
        //    string strvalue=Console.ReadLine();
        //    bool tru = int.TryParse(strvalue, out int value);
        //    int say = (int)Math.Log10(value) + 1;
        //    if (!tru)
        //    {
        //        goto l1;

        //    }
        //    if (say != 5)
        //    {
        //        goto l1;
        //    }
        //    int sum = 0;
        //    int resudie2 = value % 10;
        //    while (value>0)
        //    {
        //        int resudie = value % 10;
        //        value /= 10;
        //        sum += resudie;

        //    }


        //l2:
        //    Console.WriteLine("2-ci 5 reqemli ededi daxil edin");
        //    string strvalue2 = Console.ReadLine();
        //    bool tru2 = int.TryParse(strvalue2, out int value2);
        //    int say2 = (int)Math.Log10(value2) + 1;
        //    if (!tru2)
        //    {
        //        goto l2;

        //    }
        //    if (say != 5)
        //    {
        //        goto l2;
        //    }
        //    int sum2 = 1;
        //    while (value2 > 0)
        //    {
        //        int resudie = value2 % 10;
        //        value2 /= 10;
        //        sum2 = sum2 * resudie;

        //    }


        //    int final = (sum + sum2) * 10 + resudie2;
        //    Console.WriteLine(final); ;
        #endregion

        #region taks 13

        //l1:
        //    Console.WriteLine("1-ci 5 reqemli ededi daxil edin");
        //    string strvalue = Console.ReadLine();
        //    bool tru = int.TryParse(strvalue, out int value);
        //    int say = (int)Math.Log10(value) + 1;
        //    if (!tru)
        //    {
        //        goto l1;

        //    }
        //    if (say != 5)
        //    {
        //        goto l1;
        //    }
        //    int sum=0;
        //    int sum2 = 0;

        //    while (value>0)
        //    {
        //        int resudie1 = value % 10;
        //        value = value / 10000;
        //        sum = sum*10+ resudie1;


        //    }
        //    while (sum > 0)
        //    {
        //        int resudie2=sum % 10;
        //        sum /= 10;
        //        sum2 = sum2 * 10 + resudie2;

        //    }

        //    Console.WriteLine(sum2); 
        //l2:

        //    Console.WriteLine("2-ci 5 reqemli ededi daxil edin");
        //    string strvalue2 = Console.ReadLine();
        //    bool tru2 = int.TryParse(strvalue2, out int value2);
        //    int say2 = (int)Math.Log10(value2) + 1;
        //    if (!tru2)
        //    {
        //        goto l2;

        //    }
        //    if (say2 != 5)
        //    {
        //        goto l2;
        //    }
        //    int sum3 = 0;
        //    int sum4 = 0;

        //    while (value2 > 0)
        //    {
        //        int resudie3 = value2 % 10;
        //        value2 = value2 / 10000;
        //        sum3 = sum3 * 10 + resudie3;


        //    }
        //    while (sum3 > 0)
        //    {
        //        int resudie4 = sum3 % 10;
        //        sum3/= 10;
        //        sum4 = sum4 * 10 + resudie4;

        //    }

        //    Console.WriteLine(sum4);
        //l3:
        //    Console.WriteLine("3-cu 5 reqemli ededi daxil edin");
        //    string strvalue3 = Console.ReadLine();
        //    bool tru3 = int.TryParse(strvalue3, out int value3);
        //    int say3 = (int)Math.Log10(value3) + 1;
        //    if (!tru3)
        //    {
        //        goto l3;

        //    }
        //    if (say3 != 5)
        //    {
        //        goto l3;
        //    }
        //    int sum5 = 0;
        //    int sum6 = 0;

        //    while (value3 > 0)
        //    {
        //        int resudie4 = value3 % 10;
        //        value3 = value3 / 10000;
        //        sum5 = sum5 * 10 + resudie4;


        //    }
        //    while (sum5 > 0)
        //    {
        //        int resudie5 = sum5 % 10;
        //        sum5 /= 10;
        //        sum6 = sum6 * 10 + resudie5;

        //    }

        //    Console.WriteLine(sum6);
        //    int cem = sum6 + sum4 + sum2;
        //    double faiz = (double)cem / 2;
        //    double final = faiz + cem;
        //    Console.WriteLine(final);
        #endregion

        #region taks14
        //l1:
        //    Console.WriteLine("1-ci 6 reqemli ededi daxil edin");
        //    string strvalue=Console.ReadLine();
        //    bool tru=int.TryParse(strvalue, out int value);
        //    int say=(int)Math.Log10((int)value)+1;
        //    if (!tru)
        //    {
        //        goto l1;
        //    }
        //    if (say!=6)
        //    {
        //        goto l1;
        //    }

        //    int azvalue = value / 1000;

        //    Console.WriteLine(azvalue);


        //l2:
        //    Console.WriteLine("2-ci 6 reqemli ededi daxil edin");
        //    string strvalue2 = Console.ReadLine();
        //    bool tru2 = int.TryParse(strvalue2, out int value2);
        //    int say2 = (int)Math.Log10((int)value2) + 1;
        //    if (!tru2)
        //    {
        //        goto l2;
        //    }
        //    if (say2 != 6)
        //    {
        //        goto l2;
        //    }
        //    int azvalue2 = value2 / 1000;
        //    Console.WriteLine(azvalue2);
        //l3:
        //    Console.WriteLine("3-cu 6 reqemli ededi daxil edin");
        //    string strvalue3 = Console.ReadLine();
        //    bool tru3 = int.TryParse(strvalue3, out int value3);
        //    int say3 = (int)Math.Log10((int)value3) + 1;
        //    if (!tru3)
        //    {
        //        goto l3;
        //    }
        //    if (say != 6)
        //    {
        //        goto l3;
        //    }
        //    int azvalue3 = value3 / 1000;
        //    int azvaule4 = azvalue + azvalue2 + azvalue3;
        //    Console.WriteLine(azvalue3);
        //l4:
        //    Console.WriteLine("4-cu 7 reqemli ededi daxil edin");
        //    string strvalue4 = Console.ReadLine();
        //    bool tru4 = int.TryParse(strvalue4, out int value4);
        //    int say4 = (int)Math.Log10((int)value4)+1;
        //    if (!tru4)
        //    {
        //        goto l4;
        //    }
        //    if (say4 != 7)
        //    {
        //        goto l4;
        //    }
        //    int sonvalue = value4 % 10000;
        //    int valuecem = azvaule4 + sonvalue;

        //    int ilkvalue4 = value4 / 10000;
        //    int sum = 1;
        //    while (ilkvalue4>0)
        //    {
        //        int resudie = ilkvalue4 % 10;
        //        ilkvalue4/=10;
        //        sum = sum * resudie;
        //    }
        //    int son = valuecem - sum;
        //    int resudie60 = son * 60 /100;
        //    int artir60 = resudie60 * 100 + 60;
        //    int faiz18 = artir60 * 18 / 100;
        //    int final = artir60 - faiz18;
        //    Console.WriteLine(final);

        #endregion

        #region task 15
        l1:
            Console.WriteLine("1-ci 3 reqemli ededi daxil edin");
            string strvalue = Console.ReadLine();
            bool tru = int.TryParse(strvalue, out int value);
            int say = (int)Math.Log10((int)value) + 1;
            if (!tru)
            {
                goto l1;
            }
            if (say != 3)
            {
                goto l1;
            }




        l2:
            Console.WriteLine("2-ci 3 reqemli ededi daxil edin");
            string strvalue2 = Console.ReadLine();
            bool tru2 = int.TryParse(strvalue2, out int value2);
            int say2 = (int)Math.Log10((int)value2) + 1;
            if (!tru2)
            {
                goto l2;
            }
            if (say2 != 3)
            {
                goto l2;
            }

        l3:
            Console.WriteLine("3-cu 6 reqemli ededi daxil edin");
            string strvalue3 = Console.ReadLine();
            bool tru3 = int.TryParse(strvalue3, out int value3);
            int say3 = (int)Math.Log10((int)value3) + 1;
            if (!tru3)
            {
                goto l3;
            }
            if (say != 6)
            {
                goto l3;
            }

        l4:
            Console.WriteLine("4-cu 6 reqemli ededi daxil edin");
            string strvalue4 = Console.ReadLine();
            bool tru4 = int.TryParse(strvalue4, out int value4);
            int say4 = (int)Math.Log10((int)value4) + 1;
            if (!tru4)
            {
                goto l4;
            }
            if (say4 != 6)
            {
                goto l4;
            }
        l5:
            Console.WriteLine("5-ci 7 reqemli ededi daxil edin");
            string strvalue5 = Console.ReadLine();
            bool tru5 = int.TryParse(strvalue5, out int value5);
            int say5 = (int)Math.Log10((int)value5) + 1;
            if (!tru5)
            {
                goto l5;
            }
            if (say4 != 7)
            {
                goto l5;
            }




            #endregion

        }



    }
}