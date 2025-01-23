namespace Demo
{   
    // Step 0: Delegate Declaration
    public delegate int StringFuncDelegate(string str);
    //1- New Delegate the Refrence From This Delegate Can Refer To A Function Or More Than Function
    // (Point To This Function)
    // 2- These FunctionMay Be Class Member Function or Obj Member Fun
    // 3- But these fun Must Have The Same Signature Of The Delegate 
    // 4- Regardless Fu Access Modifier Name (Fun Parametrs, Return Type)
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
        }
    }
}
