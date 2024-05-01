//1
//string[] mas = new string[10]
//{
//            "освоении", "по плечу", "сложный", "но если",
//            "программирования", "многие бросают", "остальное будет", "освоить их,",
//            "этап в", "Массивы -"
//};

//Console.WriteLine("Полная фраза: " + mas[9] +" "+ mas[2] + " " + mas[8] + " " + mas[0] + " " + mas[4] + ", " 
//    + mas[5] + " " + mas[3] + " " + mas[7] + " " + mas[6] + " " + mas[1]);
//2
int[] mas = new int[10];
Random random = new Random();
for(int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(100);
}
Console.WriteLine("Числа в массиве:");
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
int evenCount = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] % 2 == 0)
    {
        evenCount++;
    }
}
Console.WriteLine("Количество четных чисел в массиве: " + evenCount);