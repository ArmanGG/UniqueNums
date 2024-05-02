using System;
using System.Linq;

Random rnd = new Random();
List<List<int>> nums = new List<List<int>>();

for (int i = 0; i < 1000000; i++)
{
    List<int> num = new List<int>();

    for (int j = 0; j < 9; j++)
    {
        int randomNumber;
        do
        {
            randomNumber = rnd.Next(1, 10); 
        } while (num.Contains(randomNumber)); 

       num.Add(randomNumber);
    }

    nums.Add(num);
}
foreach (var num in nums)
{
    int[] numbers =new int[num.Count];
    int a = num[0];
    int b = num[1];
    int c = num[2];
    int d = num[3];
    int e = num[4];
    int f = num[5];
    int g = num[6];
    int h = num[7];
    int k = num[8];
    int a1 = a * 10 + b;
    numbers[0] = a;
    numbers[1] = b;
    numbers[2] = c;
    int res1 = a1 * c;
    numbers[3] = res1 / 10 ;
    numbers[4] = res1 % 10;
    numbers[5] = f;
    numbers[6] = g;
    int a2=f* 10 + g;
    int res2 = res1 + a2;
    numbers[7] = res2 / 10;
    numbers[8]=res2 % 10;

    if (res1 == d * 10 + e && res2 == h * 10 + k)
    {
        if (Check(numbers))
        {
            foreach (int c1 in numbers) Console.WriteLine(c1);
            Console.WriteLine();break;
        }
        
    }
    
}
static bool Check(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[i] == numbers[j])
            {
                return false; 
            }
        }
    }

    return true; 
}