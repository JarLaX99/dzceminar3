int[] numberA = new int[3];
int[] numberB = new int[3];
System.Console.Write("Введите X координаты A: ");
numberA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y координаты A: ");
numberA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Z координаты A: ");
numberA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите X координаты B: ");
numberB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y координаты B: ");
numberB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Z координаты B: ");
numberB[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Round((Math.Sqrt(Math.Pow(numberA[0] - numberB[0], 2) + Math.Pow(numberA[1] - numberB[1], 2) + Math.Pow(numberA[2] - numberB[2], 2))), 2));

