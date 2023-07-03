namespace LINQPart2{
    internal class Program{
        static void Main(string[] args){

            //Задание 15.1.4 Напишите метод для поиска общих букв в двух словах.

            string[] WO = { "Тебе" };
            string[] GO = { "Тебе" };

            var DO = WO.Intersect(GO);

            foreach(var x in DO) { Console.WriteLine(x); }
        }
    }
}