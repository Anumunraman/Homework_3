Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
double count = 0;
while (count<=N-1)
{
    count +=1;
    Console.WriteLine(count*count*count);
}