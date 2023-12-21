Console.WriteLine("Введите текст");
string str = Convert.ToString(Console.ReadLine());
string[] mass = str.Split(' ');
Console.WriteLine($"Колличество слов в данной строке - {mass.Length}");
