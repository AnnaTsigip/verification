

string[] myArray;
int count;
Console.Write("count = ");
count = Int32.Parse(Console.ReadLine());
myArray = new string[count];
Console.WriteLine("Введите массив:");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write("myArray[{0}] = ", i);
    myArray[i] = Console.ReadLine();
}

string[] newArray = new string[myArray.Length];
int j = 0;
Console.Write("Новый массив: ");
for (int i = 0; i < myArray.Length; i++)
 {
    if (myArray[i].Length < 4 && myArray[i].Length > 0)
    {
        newArray[i] = myArray[i];
        j++;

         Console.Write($"{newArray[i]} ");
    }
}