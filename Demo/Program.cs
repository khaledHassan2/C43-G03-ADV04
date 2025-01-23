namespace Demo
{   
    // Step 0: Delegate Declaration
    public delegate int StringFuncDelegate(string str);
    #region Notes Aboute Delegate
    //1- New Delegate the Refrence From This Delegate Can Refer To A Function Or More Than Function
    // (Point To This Function)
    // 2- These FunctionMay Be Class Member Function or Obj Member Fun
    // 3- But these fun Must Have The Same Signature Of The Delegate 
    // 4- Regardless Fu Access Modifier Name (Fun Parametrs, Return Type) 
    #endregion
    public delegate bool SptrtingTypesFunDelegate<T>(T arg1,T arg2);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 -Intero To Delegate & EX
            #region Intero To Delegate
            // Delegate Is C# Language Feature
            // Has  Usage
            // 1 -Functional Programing
            // 2 -Event -Driven Programing 
            #endregion
            // // int x = StringFunction.GetCountOfUpperCaseChars; //Error

            // // Step 1: Declare Referance From The Delegate
            // StringFuncDelegate reFerance;

            // //Step 2: Intialize the Delegate Referance (Point To Function)
            //// reFerance= new StringFuncDelegate(StringFunction.GetCountOfUpperCaseChars);
            // reFerance = StringFunction.GetCountOfUpperCaseChars; // Syntax Sugar
            // reFerance -= StringFunction.GetCountOfLowerCaseChars;

            // //Step 3: Use The Delegate Referance 
            // //int Result = reFerance.Invoke("Khaled");
            // int Result = reFerance("Khaled"); // Syntax SUgar

            // Console.WriteLine(Result);
            #endregion
            #region 2- Delegate EX2 (withOut Genarics)

            //int[] Num= { 4,8,5, 6, 3,1,7 ,2 };

            //SptrtingTypesFunDelegate stFunc = SortingTypes.ComperGrt;
            //SortingAlgorithms.BubbleSort(Num,stFunc);

            //foreach (var item in Num)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3- Delegate EX2 (with Genarics)
            //string[] Names = { "khaled", "Ali", "Mostafa" };
            //SptrtingTypesFunDelegate<string> stFunc = SortingTypes.SortDes;

            //SortingAlgorithms<string>.BubbleSort(Names, stFunc);
            //foreach (var item in Names)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4- Delegate EX3 (withOut Genarics)
            //List<int> Numbers = Enumerable.Range(0, 100).ToList();
            //List<int> OddNumbers=Helper.FindOddNumbers(Numbers);
            //List<int> EvenNumbers = Helper.FindEvenNumbers(Numbers);

            //foreach (var item in EvenNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //-----------------------------------
            //List<int> Numbers = Enumerable.Range(0, 100).ToList();
            //List<int> OddNumbers = Helper.FindNumbers(Numbers,ConditionFunctions.CheckOdd);
            //List<int> EvenNumbers = Helper.FindNumbers(Numbers,ConditionFunctions.CheckEven);

            //foreach (var item in EvenNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region MyRegion

            #endregion
        }
    }
}
