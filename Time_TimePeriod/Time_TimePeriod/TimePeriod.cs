using System;
using System.Collections.Generic;
using System.Text;

namespace Time_TimePeriod
{
    public struct TimePeriod : IEquatable<TimePeriod>, IComparable<TimePeriod>
    {
        private readonly long sekundy;
        private readonly byte minuty;
        private readonly byte godziny;
        private long sumaCzasu;

        /// <summary>
        /// Zmienna przetrzymująca wartość sumaryczną w sekundach naszego czasu
        /// </summary>
        public long SumaCzasu
        {
            get
            {
                return sumaCzasu;
            }
            set
            {
                sumaCzasu = value;
                if (sumaCzasu < 0)
                {
                    throw new ArgumentException(nameof(sumaCzasu), "suma czasu jest mniejsza od zera");
                }
            }
        }



        /// <summary>
        /// Sekundy
        /// </summary>
        /// <value>
        /// Wartość wyraża ilość sekund
        /// </value>      
        public long Sekundy
        {
            get
            {
                return sekundy;
            }
        }

        /// <summary>
        /// Minuty
        /// </summary>
        /// <value>
        /// Wartość wyraża ilość minut
        /// </value>  
        public byte Minuty
        {
            get
            {
                return minuty;
            }
        }

        /// <summary>
        /// Godziny
        /// </summary>
        /// <value>
        /// Wartość wyraża ilość godzin
        /// </value>  
        public byte Godziny
        {
            get
            {
                return godziny;
            }
        }



        /// <summary>
        /// Konstruktor z podanymi godziną minutą i sekundą
        /// </summary>
        /// <param name="godziny">bedzie przypisywał obiekotwi wartość godzin</param>
        /// <param name="minuty">bedzie przypisywał obiekotwi wartość minut</param>
        /// <param name="sekundy">bedzie przypisywał obiekotwi wartość sekund</param>
        public TimePeriod(byte godziny, byte minuty, long sekundy)
        {
            this.godziny = godziny;
            this.minuty = minuty;
            this.sekundy = sekundy;
            this.sumaCzasu = sekundy + minuty * 60 + godziny * 3600;
            if (Godziny < 0)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest ujemna");
            }
            if (Minuty < 0)
            {
                throw new ArgumentException(nameof(Minuty), "wartości Minuty jest ujemna");
            }
            if (Sekundy < 0)
            {
                throw new ArgumentException(nameof(Sekundy), "wartości Sekundy jest ujemna");
            }
        }

        /// <summary>
        /// Konstruktor z podanymi godziną minutą i domyślnymi sekundami
        /// </summary>
        /// <param name="godziny">bedzie przypisywał obiekotwi wartość godzin</param>
        /// <param name="minuty">bedzie przypisywał obiekotwi wartość minut</param>
        public TimePeriod(byte godziny, byte minuty)
        {
            this.godziny = godziny;
            this.minuty = minuty;
            this.sekundy = 00;
            this.sumaCzasu = sekundy + minuty * 60 + godziny * 3600;
            if (Godziny < 0)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest ujemna");
            }
            if (Minuty < 0)
            {
                throw new ArgumentException(nameof(Minuty), "wartości Minuty jest ujemna");
            }

        }

        /// <summary>
        /// Konstruktor z podanymi sekundami i domyślnymi godzinami i minutami
        /// </summary>
        /// <param name="sekundy">bedzie przypisywał obiekotwi wartość sekund</param>
        public TimePeriod(long sekundy)
        {
            this.godziny = (byte)(sekundy / 3600);
            this.minuty = (byte)((sekundy / 60) % 60);
            this.sekundy = sekundy % 60;
            this.sumaCzasu = sekundy + minuty * 60 + godziny * 3600;
            if (Godziny < 0)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest ujemna");
            }
            if (Minuty < 0)
            {
                throw new ArgumentException(nameof(Minuty), "wartości Minuty jest ujemna");
            }
            if (Sekundy < 0)
            {
                throw new ArgumentException(nameof(Sekundy), "wartości Sekundy jest ujemna");
            }
        }

        /// <summary>
        /// konstruktor z podanymi dwoma punktami na liniczasu z których wyliczana jest różnica i przypisywana do zmiennych
        /// </summary>
        /// <param name="t1">Obiekt typu Time pierwszy od którego bedziemy odejmować</param>
        /// <param name="t2">Obiekt typu Time drugi który będzie odejmowany</param>
        public TimePeriod(Time t1, Time t2)
        {
            this.sumaCzasu = t1.Sekundy - t2.Sekundy + t1.Minuty * 60 - t2.Minuty * 60 + t1.Godziny * 3600 - t2.Godziny * 3600;

            this.godziny = (byte)(sumaCzasu / 3600);
            this.minuty = (byte)((sumaCzasu / 60) % 60);
            this.sekundy = sumaCzasu % 60;
            if (Godziny < 0)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest ujemna");
            }
            if (Minuty < 0)
            {
                throw new ArgumentException(nameof(Minuty), "wartości Minuty jest ujemna");
            }
            if (Sekundy < 0)
            {
                throw new ArgumentException(nameof(Sekundy), "wartości Sekundy jest ujemna");
            }


        }


        /// <summary>
        /// Konstruktor z podanymi godziną, minutami i sekundami w postaci stringu
        /// </summary>
        /// <param name="time">data która zostanie następnie zamieniona na tablice bytów i przypisana do odpowiednich wartości obiektu</param>
        public TimePeriod(string time)
        {
            string[] timeInString = time.Split(':');
            long[] timeInByteInArray = Array.ConvertAll(timeInString, long.Parse);
            this.godziny = (byte)timeInByteInArray[0];
            this.minuty = (byte)timeInByteInArray[1];
            this.sekundy = timeInByteInArray[2];
            this.sumaCzasu = this.sekundy + this.minuty * 60 + this.godziny * 3600;
            if (Godziny < 0)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest ujemna");
            }
            if (Minuty < 0)
            {
                throw new ArgumentException(nameof(Minuty), "wartości Minuty jest ujemna");
            }
            if (Sekundy < 0)
            {
                throw new ArgumentException(nameof(Sekundy), "wartości Sekundy jest ujemna");
            }
        }

        /// <summary>
        /// Nadpisanie metody która będzie zwracała datę w formie stringa
        /// </summary>
        /// <returns>Zwraca datę w formie stringa w formacie"Godziny:Minuty:Sekundy"</returns>
        public override string ToString()
        {
            return Godziny + ":" + Minuty + ":" + Sekundy;
        }



        /// <summary>
        /// Implementacja Interfejsu IEquatable
        /// </summary>
        /// <param name="other">Obiekt typu TimePeriod który chcemy porównywać</param>
        /// <returns>Zwracamy prawdę gdy obiekty są równe lub fals gdy tak nie jest</returns>
        public bool Equals(TimePeriod other)
        {
            if (this.Godziny == other.Godziny && this.Minuty == other.Minuty && this.Sekundy == other.Sekundy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Implementacja Interfejsu IEquatable
        /// </summary>
        /// <param name="obj">Obiekt nieznanego typu który chcemy porównywać</param>
        /// <returns>fałsz jeżeli obiekt jest nullem lub nie jest typu TimePeriod lub zwraca metodę Equals z rzutowaniem obiektu na typ TimePeriod</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is TimePeriod))
            {
                return false;
            }
            return Equals((TimePeriod)obj);
        }
        /// <summary>
        /// Implementacja interfejsu IEquatable, nadpisanie metody GetHashCode
        /// </summary>
        /// <returns>zwraca unikalny numer podanego obiektu</returns>
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Godziny.GetHashCode();
            hash = (hash * 7) + Minuty.GetHashCode();
            hash = (hash * 7) + Sekundy.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Przeciążenie operatora ==
        /// </summary>
        /// <param name="t1">Pierwszy Obiekt typu TimePeriod</param>
        /// <param name="t2">Drugi obiekt typu TimePeriod</param>
        /// <returns>Jeżeli obiekty są równe zwraca true inaczej zwraca false</returns>
        public static bool operator ==(TimePeriod t1, TimePeriod t2)
        {
            return t1.Equals(t2);
        }

        /// <summary>
        /// Przeciążenie operatora !=
        /// </summary>
        /// <param name="t1">Pierwszy Obiekt typu TimePeriod</param>
        /// <param name="t2">Drugi obiekt typu TimePeriod</param>
        /// <returns>Jeżeli obiekty nie są równe zwraca true inaczej zwraca false</returns>
        public static bool operator !=(TimePeriod t1, TimePeriod t2)
        {
            return !(t1 == t2);
        }


        /// <summary>
        /// Implementacja interfejsu IComparable
        /// </summary>
        /// <param name="other">Obiekt typu TimePeriod do którego chcemy być przyrównani</param>
        /// <returns>zwraca -1 gdy nasz obiekt jest mniejszy, 0 gdy obiekty są równe lub 1 gdy nasz obiekt jest większy</returns>
        public int CompareTo(TimePeriod other)
        {
            if (this.Godziny > other.Godziny) return -1;
            if (this.Godziny == other.Godziny && this.Minuty == other.Minuty && this.Sekundy == other.Sekundy) return 0;
            return 1;
        }

        /// <summary>
        /// Przeciążenie operatora <
        /// </summary>
        /// <param name="t1">Pierwszy Obiekt typu TimePeriod</param>
        /// <param name="t2">Drugi obiekt typu TimePeriod</param>
        /// <returns>Zwraca true gdy obiekt pierwszy jest mniejszy niż drugi inaczej zwraca false</returns>
        public static bool operator <(TimePeriod t1, TimePeriod t2)
        {
            if (t1.Godziny < t2.Godziny)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Przeciążenie operatora >
        /// </summary>
        /// <param name="t1">Pierwszy Obiekt typu TimePeriod</param>
        /// <param name="t2">Drugi obiekt typu TimePeriod</param>
        /// <returns>Zwraca true gdy obiekt pierwszy jest większy niż drugi inaczej zwraca false</returns>
        public static bool operator >(TimePeriod t1, TimePeriod t2)
        {
            if (t1.Godziny > t2.Godziny)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Przeciążenie operatora >=
        /// </summary>
        /// <param name="t1">Pierwszy Obiekt typu TimePeriod</param>
        /// <param name="t2">Drugi obiekt typu TimePeriod</param>
        /// <returns>Zwraca true gdy obiekt pierwszy jest większy niż drugi lub są one równe, inaczej zwraca false</returns>
        public static bool operator >=(TimePeriod t1, TimePeriod t2)
        {
            if (t1.Godziny > t2.Godziny || t1.Equals(t2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Przeciążenie operatora <=
        /// </summary>
        /// <param name="t1">Pierwszy Obiekt typu TimePeriod</param>
        /// <param name="t2">Drugi obiekt typu TimePeriod</param>
        /// <returns>Zwraca true gdy obiekt pierwszy jest mniejszy niż drugi lub są one równe, inaczej zwraca false</returns>
        public static bool operator <=(TimePeriod t1, TimePeriod t2)
        {
            if (t1.Godziny < t2.Godziny || t1.Equals(t2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// Metoda która dodaje do naszego odcinka czasu drugi odcinek czasu
        /// </summary>
        /// <param name="timeToAdd">Parametr sumy czasu który dodajemy do naszj sumy czasu</param>
        /// <returns>Zwracamy nowy obiekt TimePeriod który będzie wartością wynosił tyle co suma dwóch podanych odcinków czasu</returns>
        public TimePeriod Plus(TimePeriod timeToAdd)
        {
            this.SumaCzasu += timeToAdd.SumaCzasu;
            return new TimePeriod(this.SumaCzasu);
        }

        /// <summary>
        /// Metoda która odejmuje od naszego odcinka czasu drugi odcinek czasu
        /// </summary>
        /// <param name="timeToSubstract"> Obiekt który będziemy odejmować od naszego przedziału czasowego</param>
        /// <returns>Zwracamy nowy obiekt TimePeriod który będzie wartością wynosił wynik odjęcia obiektów</returns>
        public TimePeriod Minus(TimePeriod timeToSubstract)
        {
            long sumaCzasu = Godziny * 3600 + Minuty * 60 + Sekundy - timeToSubstract.SumaCzasu;

            while ((sumaCzasu / 3600) % 24 < 0)
            {
                sumaCzasu += 24 * 3600;
            }
            while ((sumaCzasu / 60) % 60 < 0)
            {

                sumaCzasu += 86400;
            }
            while (sumaCzasu % 60 < 0)
            {
                sumaCzasu += 86400;
            }
            // this.SumaCzasu -= timeToSubstract.SumaCzasu;
            return new TimePeriod(sumaCzasu);
        }




        /// <summary>
        /// Dodawanie dwóch przedziałów czasowych do siebie
        /// </summary>
        /// <param name="timeToAdd1">Pierwszy parametr sumy czasu który będziemy dodawać</param>
        /// <param name="timeToAdd2">Drugi parametr sumy czasu który będziemy dodawać</param>
        /// <returns>Zwraca nowy obiekt typu TimePeriod który reprezentuje sumę składowych</returns>
        public static TimePeriod Plus(TimePeriod timeToAdd1, TimePeriod timeToAdd2)
        {
            long Suma = timeToAdd1.SumaCzasu + timeToAdd2.SumaCzasu;
            return new TimePeriod(Suma);
        }

        /// <summary>
        /// Odejmowanie dwóch przedziałów czasowych od siebie
        /// </summary>
        /// <param name="timeToSubstract1">Pierwszy parametr sumy czasu który będziemy odejmować</param>
        /// <param name="timeToSubstract2">Drugi parametr sumy czasu który będziemy odejmować</param>
        /// <returns>Zwraca nowy obiekt typu TimePeriod który reprezentuje wynik odejmowania</returns>
        public static TimePeriod Minus(TimePeriod timeToSubstract1, TimePeriod timeToSubstract2)
        {
            long sumaCzasu = timeToSubstract1.Godziny * 3600 + timeToSubstract1.Minuty * 60 + timeToSubstract1.Sekundy - timeToSubstract2.SumaCzasu;

            while ((sumaCzasu / 3600) % 24 < 0)
            {
                sumaCzasu += 24 * 3600;
            }
            while ((sumaCzasu / 60) % 60 < 0)
            {

                sumaCzasu += 86400;
            }
            while (sumaCzasu % 60 < 0)
            {

                sumaCzasu += 86400;

            }
            // long Suma = timeToSubstract1.SumaCzasu - timeToSubstract2.SumaCzasu;
            return new TimePeriod(sumaCzasu);
        }

        /// <summary>
        /// Przeciążenie operatora +
        /// </summary>
        /// <param name="t1">Pierwszy obiekt TimePeriod który będziemy dodawać</param>
        /// <param name="t2">Drugi obiekt TimePeriod który będziemy dodawać</param>
        /// <returns>Zwraca nowy obiekt TimePeriod który będzie sumą dwóch podanych odcinków</returns>
        public static TimePeriod operator +(TimePeriod t1, TimePeriod t2)
        {
            return new TimePeriod(t1.SumaCzasu + t2.SumaCzasu);
        }


        /// <summary>
        /// PRzeciążenie operatora -
        /// </summary>
        /// <param name="t1">Pierwszy obiekt TimePeriod który będziemy odejmować</param>
        /// <param name="t2">Drugi obiekt TimePeriod który będziemy odejmować</param>
        /// <returns>Zwraca nowy obiekt TimePeriod który będzie różnicą dwóch podanych odcinków</returns>
        public static TimePeriod operator -(TimePeriod t1, TimePeriod t2)
        {
            long sumaCzasu = t1.Godziny * 3600 + t1.Minuty * 60 + t1.Sekundy - t2.SumaCzasu;
            while ((sumaCzasu / 3600) % 24 < 0)
            {
                sumaCzasu += 24 * 3600;
            }
            while ((sumaCzasu / 60) % 60 < 0)
            {

                sumaCzasu += 86400;
            }
            while (sumaCzasu % 60 < 0)
            {

                sumaCzasu += 86400;

            }
            return new TimePeriod(sumaCzasu);
        }
    }
}
