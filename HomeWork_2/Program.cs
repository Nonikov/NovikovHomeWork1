using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    static class Wallpapers
    {
        static double widthOfRoom, lengthOfRoom, heightOfRoom, lengthOfWallpaper, widthOfWallpaper, stepOfPicture,
                      amountPictureInStrip, stripWithStepping, perimeter, areaOfWalls, trimmingLength;
        static int amountOfStipsOfRool, totalAmountOfRools;

        static void ParameterInput() // Ввод параметров.
        {
            Console.WriteLine("Enter width of the room:");
            widthOfRoom = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter length of the room:");
            lengthOfRoom = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height of the room:");
            heightOfRoom = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter length of the wallpapers:");
            lengthOfWallpaper = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width of the wallpapers:");
            widthOfWallpaper = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter step of pattern of the wallpapers:");
            stepOfPicture = Convert.ToDouble(Console.ReadLine());
        }

        static void Initialization()
        {
            perimeter = (widthOfRoom + lengthOfRoom) * 2;
            areaOfWalls = perimeter * heightOfRoom;
        }
        static void Step()
        {
            // Неокругленное количество рисунков в одной полосе
            amountPictureInStrip = heightOfRoom / stepOfPicture;

            // Длина одной отрезной полосы (грязной), без вычитания поправки на шаг 
            stripWithStepping = Math.Ceiling(amountPictureInStrip) * stepOfPicture;
        }
        static void AmountOfRools() // Требуемое количество рулонов на комнату
        {
            // Нужное количество полос на комнату.
            int totalAmountOfStrips = (int)Math.Ceiling(perimeter / widthOfWallpaper);

            // Количество полос в одном рулоне.
            amountOfStipsOfRool = (int)(lengthOfWallpaper / stripWithStepping);

            // Нужное колечество рулонов на комнату.
            totalAmountOfRools = (int)Math.Ceiling((double)totalAmountOfStrips / amountOfStipsOfRool);
        }

        static void TrimmingLength() // Суммарная площадь обрезков.
        {
            double areaOfNeededWallpapers = widthOfWallpaper * lengthOfWallpaper * totalAmountOfRools;

            trimmingLength = areaOfNeededWallpapers - areaOfWalls;
        }

        static double TrimingsPersent() // % потерь.
        {
            return areaOfWalls / 100 * trimmingLength;
        }

        static void Show()
        {
            Console.WriteLine($"Параметры комнаты:\nШирина:{widthOfRoom}м, Длина: {lengthOfRoom}м, Высота: {heightOfRoom}м. \n");

            Console.WriteLine($"Параметры рулона обоев:\nШирина:{widthOfWallpaper}м., Длина: {lengthOfWallpaper}м. \n");

            Console.WriteLine($"Требуемое количество рулонов: {totalAmountOfRools}шт.");

            Console.WriteLine($"Общая площадь обрезков: {trimmingLength:F2}м. \nПроцент потерь: {TrimingsPersent():F2}%");
        }

        static public void Start()
        {
            ParameterInput();
            Initialization();
            Step();
            AmountOfRools();
            TrimmingLength();
            Show();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Wallpapers.Start();

            Console.ReadKey();
        }
    }
}
