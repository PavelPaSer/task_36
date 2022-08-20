Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int i = 1; i < numbers.Length; i+=2)
    
    sum = sum + numbers[i];

    Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-99, 100);
        }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
}