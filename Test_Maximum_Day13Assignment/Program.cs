// See https://aka.ms/new-console-template for more information
using FindMaxNumUsingGeneric_Day13Assignment;

Console.WriteLine("Enter \n1 For FIND_MAX_Int_NUMBER_WITHOUT_GENERIC PROGRAM \n2 For FIND_MAX_FLOAT_NUMBER_WITHOUT_GENERIC PROGRAM");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("\nWelcome to FIND_MAX_Int_NUMBER_WITHOUT_GENERIC PROGRAM \n");
        Console.WriteLine("Maximum Int Number : " + IntegerMaxNumber.MaximumIntegerNumber(100, 531, 432));
        break;
    case 2:
        Console.WriteLine("\nWelcome to FIND_MAX_FLOAT_NUMBER_WITHOUT_GENERIC PROGRAM \n");
        Console.WriteLine("Maximum Float Number : " + FloatMaxNumWithoutGenerics.MaximumFloatNumber(85.5, 71.9, 35.4));
        break;
}