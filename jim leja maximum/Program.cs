using System;

namespace study
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string userGender;
            int userVeight;
            int maxVeight;
            int naPovtoreniy;
            int programmProcessed = 0;
            float jimEpley;
            float jimMatt;
            float jimLander;
            float jimConner;
            double jimWathan = 0;
            double jimWilks = 0;
            double jimWendler;
            double jimLombardi;
            double jimMayhew = 0;
            double jimMcGlothin;
            double aMale = -216.0475144;
            double bMale = 16.2606339;
            double cMale = -0.002388645;
            double dMale = -0.00113732;
            double eMale = 7.01863E-06;
            double fMale = -1.291E-08;
            double aFemale = 594.31747775582;
            double bFemale = -27.23842536447;
            double cFemale = 0.82112226871;
            double dFemale = -0.00930733913;
            double eFemale = 0.00004731582;
            double fFemale = -0.00000009054;
            bool isOpen = true;
            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Калькулятор жима");
                Console.WriteLine("\n\n1 - считать жим,\n\n2 - выйти из программы.");
                Console.Write("\n\nВведите номер команды - ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("Ващ пол?(Мужчина, Женщина) - ");
                        userGender = Convert.ToString(Console.ReadLine());
                        if (userGender != "Мужчина" && userGender != "Женщина")
                        {
                            Console.WriteLine("Неверный пол.");
                            break;
                        }
                        Console.Write("Ваш вес - ");
                        userVeight = Convert.ToInt32(Console.ReadLine());
                        double uVX2 = Math.Pow(userVeight, 2);
                        double uVX3 = Math.Pow(userVeight, 3);
                        double uVX4 = Math.Pow(userVeight, 4);
                        double uVX5 = Math.Pow(userVeight, 5);
                        Console.Write("\n\nВес штанги - ");
                        maxVeight = Convert.ToInt32(Console.ReadLine());                       
                        Console.Write("\n\nНа столько повторений - ");
                        naPovtoreniy = Convert.ToInt32(Console.ReadLine());
                        double nPX01 = Math.Pow(naPovtoreniy, 0.1);
                        double eMayhew = Math.Pow(eFemale, -0.055 * naPovtoreniy);
                        if (maxVeight < 0 || naPovtoreniy < 0)
                        {
                            Console.WriteLine("Неверный вес/кол-во повторений.");
                            break;
                        }
                        jimEpley = (maxVeight * naPovtoreniy) / 30 + maxVeight;
                        jimMatt = maxVeight * (36 / (37 - naPovtoreniy));
                        jimLander = (100 * maxVeight) / (Convert.ToSingle(101.3) - Convert.ToSingle(2.67123) * naPovtoreniy);
                        jimConner = maxVeight * (1 + Convert.ToSingle(0.025) * naPovtoreniy);
                        jimWendler = maxVeight * naPovtoreniy * 0.0333 + maxVeight;
                        jimLombardi = maxVeight * nPX01;
                        jimMcGlothin = (100 * maxVeight) / (101.3 - 2.67123 * naPovtoreniy);
                        jimMayhew = (100 * maxVeight) / (52.2 + 41.9 * eMayhew);
                        if (userGender == "Мужчина")
                        {
                            jimWathan = (100 * maxVeight) / (48.8 + 53.8 * eMale);
                            jimWilks = (500 * maxVeight) / (aMale + bMale * userVeight + cMale * uVX2 + dMale * uVX3 + eMale * uVX4 + fMale * uVX5);
                        }
                        else if(userGender == "Женщина")
                        {
                            jimWathan = (100 * maxVeight) / (48.8 + 53.8 * eFemale);
                            jimWilks = (500 * maxVeight) / (aFemale + bFemale * userVeight + cFemale * uVX2 + dFemale * uVX3 + eFemale * uVX4 + fFemale * uVX5);
                        }
                        Console.WriteLine("\n\nФормула Эпли - " + jimEpley + "\n\nФормула Бжицки - " + jimMatt + "\n\nФормула Лэндера - " + jimLander + 
                            " \n\nФормула О'Коннор - " + jimConner + "\n\nФормула Ваттана - " + jimWathan + "\n\nФормула Уилкса - " + jimWilks + "\n\nФормула Вендлера - " + jimWendler + 
                            "\n\nФормула Ломбарди - " + jimLombardi + "\n\nФормуна Мэйхью - " + jimMayhew + "\n\nФормула МакГлотина - " + jimMcGlothin +  "\n\nМаксимальный жим - " + 
                            ((jimMatt + jimEpley + jimConner + jimLander + jimWathan + jimWilks + jimWendler + jimLombardi + jimMayhew) / 9));
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
