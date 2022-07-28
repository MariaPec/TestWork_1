
string Prompt(string message)
{
System.Console.WriteLine(message);
string param = Console.ReadLine();
return param;
}

int firstLenght = 5; // Задача решена для массива длиной 5

string [] firstArray = new string [firstLenght]; 

for (int i = 0; i < firstLenght; i++)
{
firstArray [i] = Prompt("Введите элемент массива => ");
}

void PrintArray(string[] PArray)
{
    for (int j = 0; j < PArray.Length; j++)
    {
        Console.Write($"{PArray[j]}, ");
    }
}

Console.Write("Первоначальный массив =>  ");
PrintArray(firstArray);

int count = 0;
int max = 3; // Переменная задает максимальное количество знаков в проверяемом элементе массива

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= max)
    {
        count++;
    }
}

string [] secondArray = new string [count];
int j = 0;

if (count > 0)
{
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= max)
    {
        secondArray[j] = firstArray[i];
        j++;
    }
}
}

Console.Write("\r\nСформированный массив =>  ");
PrintArray(secondArray);





