// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1.1.  нарушают порядок возрастания
// 1.2.  больше среднего арифметического элементов A
// 1.3.  чётные

Console.WriteLine();
void FillArrayA(int[] A) // Метод, заполняющий массив A случайными двузначными целыми числами от 10 до 100
{
    int length = A.Length;
    int index = 0;
    int summ = 0;
    int average = 0;

    while (index < length)
    {
        A[index] = new Random().Next(10, 100);
        Console.Write(A[index] + " ");
        summ = summ + A[index];
        index++;

    }
    average = summ / length;

}
int[] A = new int[30];
Console.WriteLine("Случайный массив:");
FillArrayA(A);

void PrintArray(int[] A)
{
    int index = 0;
    while (index < A.Length)
    {
        Console.Write(A[index] + " ");
        index++;
    }
}

int averageArray(int[] A) //Метод, определяющий ср. арифметическое элементов массива
{
    int length = A.Length;
    int index = 0;
    int summ = 0;
    int average = 0;

    while (index < length)
    {
        summ = summ + A[index];
        index++;

    }
    average = summ / length;
    return average;
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое массива A: " + averageArray(A));

//Определяем длину массива B по подзадаче 1.1.:
int index = 0;
int countLengthB = 0;
int max = 0;
while (index < A.Length)
{
    if (A[index] > max)
    {
        max = A[index];
        countLengthB++;
    }
    index++;
}

int[] B = new int[countLengthB]; //Заполняем массив B для подзадачи 1.1.
max = 0;
int indexB = 0;
index = 0;

while (index < A.Length)
{
    if (A[index] > max)
    {
        max = A[index];
        B[indexB] = A[index];
        indexB++;
    }
    index++;
}
// Печатаем массив B для подзадачи 1.1.
index = 0;
Console.WriteLine();
Console.WriteLine("Массив B, созданный на основе массива A путем отбрасывания элементов, нарушающих порядок возрастания:");
PrintArray(B);

//Определяем длину массива B по подзадаче 1.2.:
index = 0;
int countLengthC = 0;
max = 0;
while (index < A.Length)
{
    if (A[index] <= averageArray(A))
    {
        countLengthC++;
    }
    index++;
}

int[] C = new int[countLengthC]; //Заполняем массив B для подзадачи 1.2.
max = 0;
int indexC = 0;
index = 0;

while (index < A.Length)
{
    if (A[index] <= averageArray(A))
    {
        C[indexC] = A[index];
        indexC++;
    }
    index++;
}
// Печатаем массив B для подзадачи 1.2.
index = 0;
Console.WriteLine();
Console.WriteLine($"Массив B, созданный на основе массива A путем отбрасывания элементов, которые больше среднего арифметического элементов A ({averageArray(A)}):");

PrintArray(C);

//Определяем длину массива B по подзадаче 1.3.:
index = 0;
int countLengthD = 0;
max = 0;
while (index < A.Length)
{
    if (A[index] % 2 != 0)
    {
        countLengthD++;
    }
    index++;
}

int[] D = new int[countLengthD]; //Заполняем массив B для подзадачи 1.3.
max = 0;
int indexD = 0;
index = 0;

while (index < A.Length)
{
    if (A[index] % 2 != 0)
    {
        D[indexD] = A[index];
        indexD++;
    }
    index++;
}
// Печатаем массив B для подзадачи 1.3.
index = 0;
Console.WriteLine();
Console.WriteLine("Массив B, созданный на основе массива A путем отбрасывания элементов, которые являются четными:");

PrintArray(D);

