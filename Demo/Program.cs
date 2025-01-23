﻿namespace Demo
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
            //Func<string,string,bool> ComberFunc= SortingTypes.SortDes;
            //SortingAlgorithms<string>.BubbleSort(Names, ComberFunc);
            //foreach (var item in Names)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4- Delegate EX3 (withOut Genarics)
            //List<int> Numbers = Enumerable.Range(0, 100).ToList();
            //Predicate<int> conFunDelOdd = ConditionFunctions.CheckOdd;
            //Predicate<int> conFunDelEven = ConditionFunctions.CheckEven;

            //List<int> OddNumbers = Helper.FindNumbers(Numbers, conFunDelOdd);
            //List<int> EvenNumbers = Helper.FindNumbers(Numbers,conFunDelEven);

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
            #region 5- Delegate EX3 (with Genarics)
            //List<string> Names = new List<string>() { "khaled", "Wagdy", "Mostafa", "Ali" };
            //Predicate<string> prd = ConditionFunctions.CheckString;
            //List<string> StrResult = Helper.FindNumbers(Names, prd);
            //foreach (var item in StrResult)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 6- Built IN Delegate [Func,Predicate,Action]
            // 1- Predicate
            // Can refer To fun That Take One Parameter And Return bool

            // 2- Func 
            //Can refer To fun That Take [0-16] Parameter And Return Value

            //3-Action
            //Can refer To fun That Take [0-16] Parameter And Be Void
            #endregion
            #region 7- Built IN Delegate Coutinue
            //Predicate<int> predicate = SomeFunction.Test;
            //predicate.Invoke(10);
            ////-----------------
            //Func<int, string> func = SomeFunction.Case;
            //    func(10);
            ////--------------
            //Action<string> action = SomeFunction.Print;
            //action("khaled");
           
            #endregion
        }
    }
}
