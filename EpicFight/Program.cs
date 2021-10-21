using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villan = PickVillan();
            Console.WriteLine($"{hero} will fight {villan}.");

            string heroWeapon = PickWeapon();
            string villansWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villan} picked {villansWeapon}");
        }

        private static string PickWeapon()
        {
            string[] weapon = { "Tupsu Torn", "Tuvi", "Viagra", "Tammsaare park", "Vabaduse Väljak", "Tupsu Torn", "Praak Maskking" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, weapon.Length);

            return weapon[randomIndex];

        }
        private static string PickHero()
        {
            string[] superHeros = { "Stalin", "Lennin", "Travis Scott Batman Edition", "Kanye East", "Toomas Kasenurm", "Harry Kask" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeros.Length);

            return superHeros[randomIndex];
        }
        private static string PickVillan()
        {
            string[] Villans = { "Osama", "Kanye West", "Helen Bork", "Ingvar Derešivski", "Raivo sibens", "Snet" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Villans.Length);

            return Villans[randomIndex];
        }
    }
}
