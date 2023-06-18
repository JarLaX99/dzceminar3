Console.Write("Введите число:");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= numberN)
{
    Console.Write(Math.Pow(count, 3) + " ");
    count++;
}
