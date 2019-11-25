using System;


namespace Time_TimePeriod
{
    public struct Time : IEquatable<Time>, IComparable<Time>
    {
        private readonly byte sekundy;
        private readonly byte minuty;
        private readonly byte godziny;

        /// <summary>
        /// Sekundy
        /// </summary>
        /// <value>
        /// Wartość wyraża ilość sekund
        /// </value>      
        public byte Sekundy
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
        public Time(byte godziny, byte minuty, byte sekundy)
        {

            this.godziny = godziny;
            this.minuty = minuty;
            this.sekundy = sekundy;
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

            if (Godziny > 23)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest zbyt duża");
            }
            if (Minuty > 59)
            {
                throw new ArgumentException(nameof(Minuty), "wartości Minuty jest zbyt duża");
            }
            if (Sekundy > 59)
            {
                throw new ArgumentException(nameof(Sekundy), "wartości Sekundy jest zbyt duża");
            }
        }

        /// <summary>
        /// Konstruktor z podanymi godziną minutą i domyślnymi sekundami
        /// </summary>
        /// <param name="godziny">bedzie przypisywał obiekotwi wartość godzin</param>
        /// <param name="minuty">bedzie przypisywał obiekotwi wartość minut</param>
        public Time(byte godziny, byte minuty)
        {
            this.godziny = godziny;
            this.minuty = minuty;
            this.sekundy = 00;
            if (Godziny < 0)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest ujemna");
            }
            if (Minuty < 0)
            {
                throw new ArgumentException(nameof(Minuty), "wartości Minuty jest ujemna");
            }
            if (Godziny > 23)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest zbyt duża");
            }
            if (Minuty > 59)
            {
                throw new ArgumentException(nameof(Minuty), "wartości Minuty jest zbyt duża");
            }
        }

        /// <summary>
        /// Konstruktor z podanymi godziną i domyślnymi sekundami i minutami
        /// </summary>
        /// <param name="godziny">bedzie przypisywał obiekotwi wartość godzin</param>
        public Time(byte godziny)
        {
            this.godziny = godziny;
            this.minuty = 00;
            this.sekundy = 00;
            if (Godziny < 0)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest ujemna");
            }
            if (Godziny > 23)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest zbyt duża");
            }
        }

        /// <summary>
        /// Konstruktor z podanymi godziną, minutami i sekundami w postaci stringu
        /// </summary>
        /// <param name="time">data która zostanie następnie zamieniona na tablice bytów i przypisana do odpowiednich wartości obiektu</param>
        public Time(string time)
        {
            string[] timeInString = time.Split(':');
            byte[] timeInByteInArray = Array.ConvertAll(timeInString, byte.Parse);
            this.godziny = timeInByteInArray[0];
            this.minuty = timeInByteInArray[1];
            this.sekundy = timeInByteInArray[2];
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

            if (Godziny > 23)
            {
                throw new ArgumentException(nameof(Godziny), "wartości Godziny jest zbyt duża");
            }
            if (Minuty > 59)
            {
                throw new ArgumentException(nameof(Minuty), "wartości Minuty jest zbyt duża");
            }
            if (Sekundy > 59)
            {
                throw new ArgumentException(nameof(Sekundy), "wartości Sekundy jest zbyt duża");
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
        /// <param name="other">Obiekt typu Time który chcemy porównywać</param>
        /// <returns>Zwracamy prawdę gdy obiekty są równe lub fals gdy tak nie jest</returns>
        public bool Equals(Time other)
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
        /// <returns>fałsz jeżeli obiekt jest nullem lub nie jest typu Time lub zwraca metodę Equals z rzutowaniem obiektu na typ Time</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Time))
            {
                return false;
            }
            return Equals((Time)obj);
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
        /// <param name="t1">Pierwszy Obiekt typu Time</param>
        /// <param name="t2">Drugi obiekt typu Time</param>
        /// <returns>Jeżeli obiekty są równe zwraca true inaczej zwraca false</returns>
        public static bool operator ==(Time t1, Time t2)
        {
            return t1.Equals(t2);
        }

        /// <summary>
        /// Przeciążenie operatora !=
        /// </summary>
        /// <param name="t1">Pierwszy Obiekt typu Time</param>
        /// <param name="t2">Drugi obiekt typu Time</param>
        /// <returns>Jeżeli obiekty nie są równe zwraca true inaczej zwraca false</returns>
        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }


        /// <summary>
        /// Implementacja interfejsu IComparable
        /// </summary>
        /// <param name="other">Obiekt typu Time do którego chcemy być przyrównani</param>
        /// <returns>zwraca -1 gdy nasz obiekt jest mniejszy, 0 gdy obiekty są równe lub 1 gdy nasz obiekt jest większy</returns>
        public int CompareTo(Time other)
        {
            if (this.Godziny > other.Godziny) return -1;
            if (this.Godziny == other.Godziny) return 0;
            return 1;

        }

        /// <summary>
        /// Przeciążenie operatora <
        /// </summary>
        /// <param name="t1">Pierwszy Obiekt typu Time</param>
        /// <param name="t2">Drugi obiekt typu Time</param>
        /// <returns>Zwraca true gdy obiekt pierwszy jest mniejszy niż drugi inaczej zwraca false</returns>
        public static bool operator <(Time t1, Time t2)
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
        /// <param name="t1">Pierwszy Obiekt typu Time</param>
        /// <param name="t2">Drugi obiekt typu Time</param>
        /// <returns>Zwraca true gdy obiekt pierwszy jest większy niż drugi inaczej zwraca false</returns>
        public static bool operator >(Time t1, Time t2)
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
        /// <param name="t1">Pierwszy Obiekt typu Time</param>
        /// <param name="t2">Drugi obiekt typu Time</param>
        /// <returns>Zwraca true gdy obiekt pierwszy jest większy niż drugi lub są one równe, inaczej zwraca false</returns>
        public static bool operator >=(Time t1, Time t2)
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
        /// <param name="t1">Pierwszy Obiekt typu Time</param>
        /// <param name="t2">Drugi obiekt typu Time</param>
        /// <returns>Zwraca true gdy obiekt pierwszy jest mniejszy niż drugi lub są one równe, inaczej zwraca false</returns>
        public static bool operator <=(Time t1, Time t2)
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
        /// Metoda zwielokratniająca godzinę o wpisaną liczbę
        /// </summary>
        /// <param name="liczba">Parametr który określa o ile ma być pomnożona nasza godzina</param>
        /// <returns>Zwracany jest nowy obiekt Time który pokazuje punkt na lini czasu po przemnożeniu </returns>
        public Time Zwielokrotnienie(int liczba)
        {
            long sumaCzasu = (Godziny * 3600 + Minuty * 60 + Sekundy) * liczba;
            return new Time((byte)((sumaCzasu / 3600) % 24), (byte)((sumaCzasu / 60) % 60), (byte)(sumaCzasu % 60));
        }

        /// <summary>
        /// Metoda zwracająca punkt po dodaniu do naszego punktu odległości w czasie
        /// </summary>
        /// <param name="t1">Obiekt typu TimePeriod określający ile czasu ma upłynąć</param>
        /// <returns>Zwracany jest nowy obiekt Time który pokazuje punkt na lini czasu po dodaniu</returns>
        public Time Plus(TimePeriod t1)
        {
            long sumaCzasu = Godziny * 3600 + Minuty * 60 + Sekundy + t1.SumaCzasu;
            return new Time((byte)((sumaCzasu / 3600) % 24), (byte)((sumaCzasu / 60) % 60), (byte)(sumaCzasu % 60));
        }

        /// <summary>
        /// Metoda zwracająca punkt po dodaniu do naszego punktu odległości w czasie
        /// </summary>
        /// <param name="t1">Obiekt typu Time określający punkt do którego chcemy dodawać</param>
        /// <param name="t2">Obiekt typu TimePeriod określający jaki okres czasu chcemy dodać</param>
        /// <returns>Zwracamy nowy obiekt typu Time który wskazuje nam godzine po dodaniu odległości w czasie</returns>
        public static Time Plus(Time t1, TimePeriod t2)
        {
            long sumaCzasu = t1.Godziny * 3600 + t1.Minuty * 60 + t1.Sekundy + t2.SumaCzasu;
            return new Time((byte)((sumaCzasu / 3600) % 24), (byte)((sumaCzasu / 60) % 60), (byte)(sumaCzasu % 60));
        }

        /// <summary>
        /// Przeciążenie operatora +
        /// </summary>
        /// <param name="t1">Obiekt typu Time określający punkt do którego chcemy dodawać</param>
        /// <param name="t2">Obiekt typu TimePeriod określający jaki okres czasu chcemy dodać</param>
        /// <returns>Zwracamy nowy obiekt typu Time który wskazuje nam godzine po dodaniu odległości w czasie</returns>
        public static Time operator +(Time t1, TimePeriod t2)
        {
            long sumaCzasu = t1.Godziny * 3600 + t1.Minuty * 60 + t1.Sekundy + t2.SumaCzasu;
            return new Time((byte)((sumaCzasu / 3600) % 24), (byte)((sumaCzasu / 60) % 60), (byte)(sumaCzasu % 60));
        }

        /// <summary>
        /// Metoda zwracająca punkt po odjęciu od naszego punktu odległości w czasie    
        /// </summary>
        /// <param name="t1">Obiekt typu TimePeriod określający ile czasu mamy odjąć</param>
        /// <returns>Zwracany jest nowy obiekt Time który pokazuje punkt na lini czasu po odjęciu</returns>

        public Time Minus(TimePeriod t1)
        {
            long sumaCzasu = Godziny * 3600 + Minuty * 60 + Sekundy - t1.SumaCzasu;

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
            return new Time((byte)((sumaCzasu / 3600) % 24), (byte)((sumaCzasu / 60) % 60), (byte)(sumaCzasu % 60));
        }

        /// <summary>
        ///  Metoda zwracająca punkt po odjęciu od podanego punktu odległości w czasie  
        /// </summary>
        /// <param name="t1">Obiekt typu Time określający punkt w przestrzeni czasu</param>
        /// <param name="t2">Obiekt typu TimePeriod określający ile czasu mamy odjąć</param>
        /// <returns>Zwracany jest nowy obiekt Time który pokazuje punkt na lini czasu po odjęciu</returns>
        public static Time Minus(Time t1, TimePeriod t2)
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
            return new Time((byte)((sumaCzasu / 3600) % 24), (byte)((sumaCzasu / 60) % 60), (byte)(sumaCzasu % 60));
        }

        /// <summary>
        /// Przeciążenie operatora -
        /// </summary>
        /// <param name="t1">Obiekt typu Time określający punkt w przestrzeni czasu</param>
        /// <param name="t2">Obiekt typu TimePeriod określający ile czasu mamy odjąć</param>
        /// <returns>Zwracany jest nowy obiekt Time który pokazuje punkt na lini czasu po odjęciu</returns>
        public static Time operator -(Time t1, TimePeriod t2)
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
            return new Time((byte)((sumaCzasu / 3600) % 24), (byte)((sumaCzasu / 60) % 60), (byte)(sumaCzasu % 60));
        }
    }
}
