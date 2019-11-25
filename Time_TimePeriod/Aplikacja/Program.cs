using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_TimePeriod;

namespace Aplikacja
{
    class Program
    {
        static Time punktCzasu;
        static void Main(string[] args)
        {
            WriteYourNumber();
        }

        /// <summary>
        /// Metoda w której wpisujemy naszą startową godzine
        /// </summary>
        public static void WriteYourNumber()
        {
            bool canMakeOperation = false;
            while (canMakeOperation != true)
            {
                Console.WriteLine("Podaj godzinę w formacie h:m:s");
                try
                {
                    punktCzasu = new Time(Console.ReadLine());
                    canMakeOperation = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono złe dane, spróbuj podobnie wpisując tylko liczby");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzono zbyt dużą lub ujemną liczbę, spróbuj ponownie wpisując poprawne wielkości");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Wprowadzono niedokładne dane, muszą być wszystkie liczby i każda z nich musi być rozdzielone dwukropkiem");
                }

                catch (Exception)
                {

                    Console.WriteLine("Wprowadzono błedne dane, spróbuj jeszcze raz wpisując liczby oddzielone dwukropkiem");

                }
            }
            Console.Clear();
            Console.WriteLine("wybrałeś punkt na osi czasu = " + punktCzasu.ToString());
            AdOrSubstract(punktCzasu);
        }

        /// <summary>
        /// Metoda w której wybieramy czy chcemy dodawać czy odejmować
        /// </summary>
        /// <param name="punktczasu"> przekazywanym parametrem jest nasz bieżący punkt czasu na którym operujemy</param>
        public static void AdOrSubstract(Time punktczasu)
        {
            Console.WriteLine();
            Console.WriteLine("Wpisz + jeżeli chcesz dodać lub - jeżeli chcesz odjąć lub * jeżeli chcesz pomnożyć");
            string znak;
            try
            {
                znak = Console.ReadLine();
            }
            catch (Exception)
            {

                throw new ArgumentException(nameof(znak), "błąd przy wprowadzaniu znaku");
            }


            if (znak == "+")
            {

                AddTimePeriod(punktczasu);
            }
            else if (znak == "-")
            {

                SubstractTimePeriod(punktczasu);
            }
            else if (znak == "*")
            {

                Multiply(punktczasu);
            }
            else
            {

                Console.WriteLine("wprowadzono błędne dane");
                AdOrSubstract(punktczasu);
            }
        }

        /// <summary>
        /// Metoda mnożenia punktu czasu przez mnożnik
        /// </summary>
        /// <param name="nowypunktczasu">Ten obiekt jest wynikiem przemnażania punktu na osi czasu</param>
        public static void Multiply(Time nowypunktczasu)
        {
            bool canMakeOperation = false;

            int liczba = 1;
            Console.WriteLine("wpisz liczbe ile razy chcesz pomnożyć swoją godzinę");
            while (canMakeOperation == false)
            {
                try
                {
                    liczba = int.Parse(Console.ReadLine());
                    canMakeOperation = true;
                }
                catch (FormatException)
                {

                    Console.WriteLine("Błędne dane, należy wprwadzić cyfrę a nie inne znaki");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzono zbyt dużą liczbę, proszę wprowadzić mniejszą liczbę");
                }
                catch (Exception)
                {

                    Console.WriteLine("Wprowadzono błedne dane, spróbuj jeszcze raz wpisując cyfre");
                    throw new ArgumentException(nameof(liczba), "wprowadzono błędne dane");
                }

            }
            Time nowyPunktCzasu = nowypunktczasu.Zwielokrotnienie(liczba);
            Console.WriteLine("Twój nowy punkt na osi czasu = " + nowyPunktCzasu.ToString());
            AdOrSubstract(nowyPunktCzasu);
        }

        /// <summary>
        /// Metoda odejmowania odcinka czasu do punktu czasu
        /// </summary>
        /// <param name="nowypunktczasu">Ten obiekt jest wynikiem odjęcia od punktu czasu naszego odcinka czasu</param>
        public static void SubstractTimePeriod(Time nowypunktczasu)
        {
            bool canMakeOperation = false;
            TimePeriod odcinekCzasu = new TimePeriod();
            while (canMakeOperation != true)
            {

                Console.WriteLine("Podaj ile czasu chcesz odjąć w formacie h:m:s");
                try
                {
                    odcinekCzasu = new TimePeriod(Console.ReadLine());
                    canMakeOperation = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono złe dane, spróbuj podobnie wpisując tylko liczby");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzono zbyt dużą liczbę, spróbuj ponownie wpisując poprawne wielkości");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Wprowadzono niedokładne dane, muszą być wszystkie liczby i każda z nich musi być rozdzielone dwukropkiem");
                }
                catch (Exception)
                {

                    Console.WriteLine("Wprowadzono błedne dane, spróbuj jeszcze raz wpisując liczby oddzielone dwukropkiem");
                    throw new ArgumentException(nameof(odcinekCzasu), "wprowadzono błędne dane");
                }
            }
            Time nowyPunktCzasu = nowypunktczasu.Minus(odcinekCzasu);
            Console.WriteLine("Twój nowy punkt na osi czasu = " + nowyPunktCzasu.ToString());
            AdOrSubstract(nowyPunktCzasu);

        }

        /// <summary>
        /// Metoda dodawania odcinka czasu do punktu czasu
        /// </summary>
        /// <param name="nowypunktczasu">Ten obiekt jest wynikiem dodania do punktu czasu naszego odcinka czasu</param>
        public static void AddTimePeriod(Time nowypunktczasu)
        {
            TimePeriod odcinekCzasu = new TimePeriod();
            bool canMakeOperation = false;
            while (canMakeOperation != true)
            {
                Console.WriteLine("Podaj ile czasu chcesz dodać w formacie h:m:s");

                try
                {
                    odcinekCzasu = new TimePeriod(Console.ReadLine());
                    canMakeOperation = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono złe dane, spróbuj podobnie wpisując tylko liczby");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzono zbyt dużą liczbę, spróbuj ponownie wpisując poprawne wielkości");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Wprowadzono niedokładne dane, muszą być wszystkie liczby i każda z nich musi być rozdzielone dwukropkiem");
                }
                catch (Exception)
                {

                    Console.WriteLine("Wprowadzono błedne dane, spróbuj jeszcze raz wpisując liczby oddzielone dwukropkiem");
                    throw new ArgumentException(nameof(odcinekCzasu), "wprowadzono błędne dane");
                }
            }

            Time nowyOdcinekCzasu = nowypunktczasu.Plus(odcinekCzasu);
            Console.WriteLine("Twój nowy punkt na osi czasu = " + nowyOdcinekCzasu.ToString());
            AdOrSubstract(nowyOdcinekCzasu);
        }
    }
}
