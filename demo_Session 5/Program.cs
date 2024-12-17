namespace demo_Session_5 
{
    internal class Program
    {
        #region Swap
        public static void Swap(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
        #endregion
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
            Arr = new int[]  { 4, 5, 6 };
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
        #region passing By out
        static void SumMul(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;

        }

        #endregion
        #region params
        static int SumArray(int[] arr)
        {
            int Sum = 0;
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Sum += arr[i];
                }
                
            }
            return Sum;
        }



        #endregion

        #region Do some Code 
        static void dosomecode()
        {
            try
            {
                int x, y, z;
                bool flag;
                do {
                    Console.WriteLine("Please enter num01");
                    flag= int.TryParse(Console.ReadLine(),out x);
        
                }while (!flag);
                do
                {
                    Console.WriteLine("Please enter num02");

                    flag = int.TryParse(Console.ReadLine(), out y);

                }while (!flag || y==0);  
                z = x / y;

                int[] numbers = { 1, 2, 3 };
                if (numbers?.Length > 10)
                {
                    numbers[10] = 100;
                }
            }
            catch(Exception ex) { 
                Console.WriteLine(ex);
            }

        }
        #endregion
        static void Main(string[] args)
            {
            #region Judged Array
            //Judged  Array => One D  Array of arrays with differnt size
            //int[][] Numbers = new int[3][];
            //Numbers[0]=new int[] {1,2,3};
            //Numbers[1] = new int[] { 4,5 };
            //Numbers[2] = new int[] { 5 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    for (int j = 0; j < Numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(Numbers[i][j]);
            //    }
            //}

            #endregion

            #region passing value
            //int a = 3, b = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            #region Passing Refernce type 
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
            //---
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
            #region passing by out 
            //int c = 10, n = 5, sumresult, mulresult;

            //SumMul(c, n, out sumresult, out mulresult);
            //Console.WriteLine($"sum= {sumresult}");
            //Console.WriteLine($"Mul = {mulresult}");
            #endregion
            #region Params
            //int[] Number= { 1,2,3}; 
            //int total = SumArray(Number);
            //Console.WriteLine(total);
            #endregion
            #region Boxing vs unboxing 
            //Boxing => Casting from Value Type to reference type 
            // UnBoxing => Casting from Reference Type to Value Type 
            #region Boxing 
            //object O1;
            //O1 = " Ahmed ";  //Cassting 
            //O1 = 1; // Casting [Value -> reference type] Boxing 
            //O1 = 'A';
            //-----------------------------------------------
            // int x = 10; // value Type 
            //object Obj = x; // Boxing [safe casting ] 
            // parent -> child
            // Animal = > Dog ( Dog is an animal)
            //--------------------------------------------------------------

            #endregion
            #region unboxing 
            //object obj02 = 10;
            //int y = (int)obj02;  // Casting [unboxing ]
            //Console.WriteLine(y);
            //object obj02 = "Rana";
            //int y = (int)obj02;  // Casting [unboxing ] //System.InvalidCastException: Unable to cast object of type 'System.String' to type 'System.Int32'
            //Console.WriteLine(y) ;
            // Dog = Animal is an dog        
            #endregion
            #endregion
            #region Nullable type 
            // null as a value is valid only with reference type
            #region  vale type 
            //int x = null; // invalid 
            // int x->  x allow only int numbers dosnot allow null
            #region ex01
            // int? Y = null; // valid (allow values + nul)
            //int? y = null;
            //int x = 10;
            //int? z = x;
            #endregion
            #region ex02
            //int x = 10;
            //int? y = x;
            //int ? Number01= null                                  

            #endregion
            #endregion
            #region referance type
            //String Message = "Hi";
            //Console.WriteLine(Message);
            //Message =null!;
            //string? name = null;
            #endregion
            #endregion
            #region Null propgation operator   
            // NULL coleasing Operator ?? 
            //int[] numbers = default;   //null
            //for(int i = 0; i < numbers?.Length??0 ; i++)
            //{
            //    Console.WriteLine(numbers[i]); 
            //}
            #endregion
            #region Exception Handling and protective code 
            try
            {
                dosomecode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            #endregion
        }
    }           
    }


    

