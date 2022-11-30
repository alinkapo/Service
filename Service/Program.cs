namespace Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем вас!");

            Console.WriteLine("Введите выбор команды:");
            Console.WriteLine("можно выбрать: добавить, список, сохранить, открыть");

            while (true)
            {
                string[] instruction = Console.ReadLine().ToLower().Split(' ');
                Controller z = new Controller();
                switch (instruction[0])
                {
                    case "добавить":
                        z.AddGood(instruction[1], float.Parse(instruction[2]), float.Parse(instruction[3]), instruction[4]);
                        break;
                    case "список":
                        Console.WriteLine(z.GetGoods());
                        break;
                    case "сохранить":
                        z.SaveList();
                        break;
                    case "открыть":
                        z.OpenList();
                        break;
                    default:
                        Console.WriteLine("Ошибка в команде");
                        break;

                }
            }
        }
    }
}
