namespace ConsoleApp1
{
    internal class Program
    {
        #region Delegate Example 3

        //public static List<int> FindOddNumbers(List<int> numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (numbers is not null)
        //    {        
        //        foreach (var number in numbers)
        //        if (number % 2 == 1)
        //            Result.Add(number);
        //    }
        //    return Result;
        //}

        public static List<int> FindNumbers(List<int> numbers , ConditionDelegate condition)
        {
            List<int> Result = new List<int>();
            if (numbers is not null)
            {
                foreach (var number in numbers)
                    if (condition.Invoke(number))
                        Result.Add(number);
            }
            return Result;
        }

        #endregion

        static void Main(string[] args)
        {
            #region Delegate

            /*
             * Delegarte:-
             *      - C# language Feature
             *      - Implement Functional Programming paradigm
             *      - Implement Event driven programming
             *      - Enforce type safety
             *      - Reference of merthod
             *          object of delegate can store Reference of method or More one method
             *      - Delegate is multicast
             *          can refer to multiple methods
             */



            #endregion

            #region Example 1

            // Step 1 : Declare reference from delegate
            //StringFuncDelegate stringCase;

            // Step 2
            //stringCase = new StringFuncDelegate(StringFunc.CountOfUpperCase);
            // stringUpperCase = StringFunc.CountOfUpperCase; => This is also valid

            // Add new method
            //stringCase += StringFunc.CountOfLowerCase;

            // Remove method
            //stringCase -= StringFunc.CountOfLowerCase;


            //Console.WriteLine(stringCase("Hello")); => Output : 1 Upper Case

            //int result = stringCase.Invoke("Hello WorlD"); // Output : 3 Upper Case
            //Console.WriteLine(result);
            // Note : Invoke always return the result of the last method

            #endregion

            #region Example 2

            // Bubble Sort Alogorithm

            //int [] arr = { 5, 3, 8, 6, 2 };

            //Helper.BuubleSort(arr, SortingTypes.CompareLess);

            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            // Passing function as parameter

            #endregion

            #region Example 3 Generic

            // sort of string based on length

            //string[] names = { "John", "Alice", "Bob", "Eve", "Charlie" };

            //Helper<string>.BuubleSort(names, SortingTypes.CompareStringLess);

            //foreach (var item in names)
            //    Console.WriteLine(item);

            #endregion

            #region Example 3

            // function input List Number => Odd Number || Even Number
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ConditionDelegate OddFunction = CheckNumber.IsOdd;
            ConditionDelegate EvenFunction = CheckNumber.IsEven;

            List<int> OddNumbers = FindNumbers(numbers, OddFunction);

            foreach (var item in OddNumbers)
                Console.WriteLine(item);

            #endregion

        }
    }
}
