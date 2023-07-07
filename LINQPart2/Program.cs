namespace LINQPart2
{
    internal class Program
    {
        //   статическая переменная для хранения данных в памяти
        public static List<long> Numbers = new List<long>();

        static void Main(string[] args)
        {
            while (true)
            {
                // Читаем введенный с консоли  текст
                var input = Console.ReadLine();

                // проверяем, число ли это
                var isInteger = long.TryParse(input, out long inputNum);

                // если не число - показываем ошибку
                if (!isInteger)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы ввели не число");
                }
                // если соответствует, запускаем обработчик
                else
                {
                    // добавляем в список
                    Numbers.Add(inputNum);

                    // выводим все критерии
                    Console.WriteLine("Число " + input + " добавлено в список.");
                    Console.WriteLine($"Всего в списке  { Numbers.Count} чисел");
                    Console.WriteLine($"Сумма:  {Numbers.Sum()}");
                    Console.WriteLine($"Наибольшее:  {Numbers.Max()}");
                    Console.WriteLine($"Наименьшее:  {Numbers.Min()}"); Console.WriteLine($"Среднее:  {Numbers.Average()}");
                    Console.WriteLine();
                }
            }
        }
    }
}