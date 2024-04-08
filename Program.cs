namespace ClassOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            var ennemy = new Character();

            character.Name = "Hero";
            ennemy.Name = "Ennemy";


            Console.WriteLine($"[{character.Name}] : Nombre de pv = {character.Health}");
            Console.WriteLine($"[{ennemy.Name}] : Nombre de pv = {ennemy.Health}");

            character.Attack(ennemy);

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine($"[{character.Name}] : Nombre de pv = {character.Health}");
            Console.WriteLine($"[{ennemy.Name}] : Nombre de pv = {ennemy.Health}");

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            ennemy.Attack(character);


            Console.WriteLine($"[{character.Name}] : Nombre de pv = {character.Health}");
            Console.WriteLine($"[{ennemy.Name}] : Nombre de pv = {ennemy.Health}");
        }
    }
}
