using System;

 

/*

 

Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.

 

ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

 

ReverseCase("MANY THANKS") ➞ "many thanks"

 

ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"

 

*/

                                                                               

public class Program

{

                public static string ReverseCase(string input)

                {

                                string result = "";

                                for(int i = 0; i < input.Length; i++ )

                                {

                                                var ternary = Char.IsUpper(input[i]) ?

                                                                result += Char.ToLower(input[i])

                                                                                      :

                                                                result += Char.ToUpper(input[i]);

                                }

                                return result;

                }

                public static void Main()

                {

                                Console.WriteLine(ReverseCase("Happy Birthday"));

                                Console.WriteLine(ReverseCase("MANY THANKS"));

                                Console.WriteLine(ReverseCase("sPoNtAnEoUs"));

                }

}