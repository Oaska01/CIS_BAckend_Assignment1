using System;

class Program
{
    static void luckyNumber(int number){
        // int[] number = new int[28];
        int sum1 = 0;
        int sum2 = 0;
        int firstNum = number / 1000;
        int secondNum = number % 1000;

        while(firstNum > 0){
            int i = firstNum % 10;
            sum1 += i;
            firstNum /= 10;
        }

        while (secondNum > 0){
            int j = secondNum %10;
            sum2 += j;
            secondNum /= 10;
        }

        // Console.Write(firstnum + " " + secondnum);

        if(sum1 == sum2){
            Console.WriteLine("Lucky Number");
        }else{
            Console.WriteLine("Not Lucky Number");
        }
    }


    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(100000, 1000000);
        
        Console.WriteLine(number);

        luckyNumber(number);
    }
} 