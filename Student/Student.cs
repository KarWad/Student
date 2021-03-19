using System;

namespace Student
{

    public delegate bool Przetworz_studenta(double Student);
    

    class Student
    {
        string imie { get; set; }
        String Nazwisko { get; set; }
        double SredniaOcen { get; set; }

        private readonly string ImieNazwisko;

        public bool StypendiumRektora(Przetworz_studenta student)
        {
            if (SredniaOcen >= 4.5)
            {
                return true;
                Console.WriteLine("Gratulacje! Dostałeś Stypendium Rektora!!");
            }
            else
            {
                return false;
            }

        }
        public bool StypendiumDziekana(Przetworz_studenta student)
        {
            if (SredniaOcen / 2 == 0)
            {
                return true;
                Console.WriteLine("Gratulacje! Dostałeś Stypendium Dziekana!!");
            }
            else
            {
                return false;
            }

        }

        public Student(string imie, String Nazwisko, double SredniaOcen)
        {
            imie = imie;
            Nazwisko = Nazwisko;
            SredniaOcen = SredniaOcen;
        }

        Object tablica(double[] a, Przetworz_studenta f)
        {
            var rezultat = new bool[a.Length];
            for (int i = 0; i < a.Length; i++)
                rezultat[i] = f(a[i]);
            int dlugosc_imienia = imie.Length;
            int dlugosc_nazwiska = Nazwisko.Length;
            if (dlugosc_imienia > dlugosc_nazwiska)
            {
                StypendiumRektora(a);
            }
            else 
            {
                StypendiumDziekana(a);
            }
            return rezultat;
          
        }

        private bool StypendiumDziekana(double[] a)
        {
            if (SredniaOcen >= 4.5)
            {
                return true;
                Console.WriteLine("Gratulacje! Dostałeś Stypendium Dziekana!!");
            }
            else
            {
                return false;
            }

        }

        private bool StypendiumRektora(double[] a)
        {
            if (SredniaOcen >= 4.5)
            {
                return true;
                Console.WriteLine("Gratulacje! Dostałeś Stypendium Rektora!!");
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        { 
       
            {
               
                Console.WriteLine("Podaj długość tablicy od 1 do 10.");
                string liczba = Console.ReadLine();
                int rozmiar = int.Parse(liczba);
                int[] tab = new int[rozmiar];
    

                for (int i = 0; i < rozmiar; i++)
                {
                    Student student1 = new Student("imie", "nazwisko", 5.0);
                    student1.imie = "Karolina";
                    student1.Nazwisko = "Wadecka";
                    student1.SredniaOcen = 5.0;

                    Console.WriteLine("student1 imie = {0} Nazwisko = {1} Srednia Ocen = {2}", student1.imie, student1.Nazwisko, student1.SredniaOcen);
                    Student student2 = student1;
                    student2.imie = "Molly";
                    student2.Nazwisko = "Nowak";
                    student2.SredniaOcen = 3.0;
                    Console.WriteLine("student2 imie = {0} Nazwisko = {1} Srednia Ocen = {2}", student2.imie, student2.Nazwisko, student2.SredniaOcen);

                    Student student3 = student2;
                    student3.imie = "Anna";
                    student3.Nazwisko = "Kowalska";
                    student3.SredniaOcen = 4.25;
                    Console.WriteLine("student3 imie = {0} Nazwisko = {1} Srednia Ocen = {2}", student3.imie, student3.Nazwisko, student3.SredniaOcen);


                    Student student4 = student3;
                    student4.imie = "Dorota";
                    student4.Nazwisko = "Godleś";
                    student4.SredniaOcen = 3.0;
                    Console.WriteLine("student4 imie = {0} Nazwisko = {1} Srednia Ocen = {2}", student4.imie, student4.Nazwisko, student4.SredniaOcen);

                    Student student5 = student4;
                    student5.imie = "Honorata";
                    student5.Nazwisko = "Skarbek";
                    student5.SredniaOcen = 6.0;
                    Console.WriteLine("student5 imie = {0} Nazwisko = {1} Srednia Ocen = {2}", student5.imie, student5.Nazwisko, student5.SredniaOcen);

                    Student student6 = student5;
                    student6.imie = "Honorata";
                    student6.Nazwisko = "Skarbek";
                    student6.SredniaOcen = 2.83;
                    Console.WriteLine("student6 imie = {0} Nazwisko = {1} Srednia Ocen = {2}", student6.imie, student6.Nazwisko, student6.SredniaOcen);

                    Student student7 = student6;
                    student7.imie = "Aneta";
                    student7.Nazwisko = "Bogusz";
                    student7.SredniaOcen = 2.0;
                    Console.WriteLine("student7 imie = {0} Nazwisko = {1} Srednia Ocen = {2}", student7.imie, student7.Nazwisko, student7.SredniaOcen);
                   
                    Student student8 = student7;
                    student8.imie = "Grzegorz";
                    student8.Nazwisko = "Sobieski";
                    student8.SredniaOcen = 3.75;
                    Console.WriteLine("student8 imie = {0} Nazwisko = {1} Srednia Ocen = {2}", student5.imie, student5.Nazwisko, student5.SredniaOcen);

                    Student student9 = student8;
                    student9.imie = "Piotr";
                    student9.Nazwisko = "Cera";
                    student9.SredniaOcen = 4.72;
                    Console.WriteLine("student9 imie = {0} Nazwisko = {1} Srednia Ocen = {2}", student9.imie, student9.Nazwisko, student9.SredniaOcen);

                    Student student10 = student9;
                    student10.imie = "Daniel";
                    student10.Nazwisko = "Kordus";
                    student10.SredniaOcen = 2.72;
                    Console.WriteLine("student10 imie = {0} Nazwisko = {1} Srednia Ocen = {2}", student10.imie, student10.Nazwisko, student10.SredniaOcen);
                }
                

            }
        }
        
    }
}

   
