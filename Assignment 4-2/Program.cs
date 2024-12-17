using System.Reflection.Metadata;   
namespace Assignment_4_2
{
    internal class Program
    {
        #region Q1
        #region Swap by value 
        public static void Swap_value( int x,int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
        #endregion
        #region swap by referance
        public static void Swap_ref(ref int x, ref  int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
        #endregion
        #endregion
        #region Q2
        #region SumArray 
        public static int SumArr(int[] Arr)
        {
            int Sum = 0;
            Arr[0] = 100;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        #endregion  
        #region SumArray By VALUE 2
        public static int SumArr1(int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        #endregion
        #region SumArrayREF
        public static int SumArrRef(ref int[] Arr)
        {
            int Sum = 0;
            Arr[0] = 100;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        #endregion
        #region Sum Array by ref 2
        public static int SumArr2(ref int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        #endregion
        #endregion
        #region Q3
        static void SumMul(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;

        }
        #endregion
        #region Q4
           public  static int individualdigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10; 
                num /= 10;       
            }
            return sum;
        }
        #endregion
        #region Q5
        public static bool Isprime(int n)
        {
            bool is_prime = true;
            if (n == 0 || n == 1)
            {
                is_prime = false;
            }
            for (int i = 2; i <= n / 2; ++i)
            {
                if (n % i == 0)
                {
                    is_prime = false;
                    break;
                }
            }
            return is_prime;
        }
        #endregion
        #region Q6
        static void MinMaxArray(int[] array, out int min, out int max)
        {
            min = array[0];
            max = array[0];
            foreach (int number in array)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }
        }

        #endregion
        #region Q7
        public static int Factorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;

        }
        #endregion
        #region Q8
        public static string ChangeChar(string character, int position, char newChar)
        {
            if (position < 0 || position >= character.Length)
            {
                Console.WriteLine("Invalid position.");
                return character;
            }
            else
            {
                char[] charArray = character.ToCharArray();
                charArray[position] = newChar;
                string charachter = new string(charArray);
                return charachter;
            }
        }

            #endregion
            static void Main(string[] args)
        {
            #region Q1
            #region Passing by value

            //int a = 3, b = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap_value(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            // Modifying the parameter inside the method does not affect the original variable.

            #endregion
            #region passing by referance
            //int a = 3, b = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap_ref(ref a,ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            // Modifications made to the parameter inside the method directly affect the original variable.

            #endregion


            #endregion
            #region  Q2
            #region Pasiing by Value
            //You can modify the object that the reference points to, but reassigning the reference itself will not affect the original reference.
            #region EX01 
            //int[] numbers = { 1, 2, 3 };
            //int Result = SumArr(numbers); // passing by value
            //Console.WriteLine( Result);
            //Console.WriteLine(numbers[0]);
            #endregion
            #region Ex02
            //int[] numbers = { 1, 2, 3 };
            //int Result = SumArr1(numbers); // passing by value
            //Console.WriteLine(Result);
            //Console.WriteLine(numbers[0]);
            #endregion
            #endregion
            #region Passing By ref
            // Changes to the object or the reference will affect the original data.
            #region Ex01
            //int[] numbers = { 1, 2, 3 };
            //int Result = SumArrRef(ref numbers); // passing by ref 
            //Console.WriteLine(Result);
            //Console.WriteLine(numbers[0]);

            #endregion
            #region Ex02
            //int[] numbers = { 1, 2, 3 };
            //int Result = SumArrRef(ref numbers); // passing by ref 
            //Console.WriteLine(Result);
            //Console.WriteLine(numbers[0]);
            #endregion
            #endregion

            #endregion
            #region Q3
            //int c = 10, n = 5, sumresult, mulresult;

            //SumMul(c, n, out sumresult, out mulresult);
            //Console.WriteLine($"sum= {sumresult}");
            //Console.WriteLine($"Mul = {mulresult}");
            #endregion
            #region Q4
            //Console.WriteLine(" Enter a number ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The sum of the digits of the number {num} is : {individualdigits(num)}");
            #endregion
            #region Q5
            //Console.Write("Enter Number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (Isprime(num))
            //{
            //    Console.WriteLine($"{num} is a prime number");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is not a prime number");
            //}


            #endregion
            #region Q6
            //int[] numbers;
            //int min, max, size;
            //Console.Write("Enter size  array :");
            //size = int.Parse(Console.ReadLine());
            //numbers = new int[size];
            //Console.WriteLine("Enter Array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //MinMaxArray(numbers , out min, out max);
            //Console.WriteLine($"Minimum: {min}, Maximum: {max}");


            #endregion
            #region Q7
            // Console.Write("Enter Number: ");
            // int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Factorial of {num} Is {Factorial(num)} ");

            #endregion
            #region Q8
            string character = "Omar";
            int position = 0;
            char newCharacter = 'M';
            Console.WriteLine($"Original String: {character}");
            Console.WriteLine($"modify  string: {ChangeChar(character, position, newCharacter)}"); 

            #endregion
        }
    }
}
