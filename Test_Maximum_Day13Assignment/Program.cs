// See https://aka.ms/new-console-template for more information
using FindMaxNumUsingGeneric_Day13Assignment;
Console.WriteLine("Welcome to FIND_MAX_NUMBER_USING_GENERICS PROGRAM \n");
int[] intArray = { 100, 531, 432 };
GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
generic.PrintMaxValue();