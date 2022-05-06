// See https://aka.ms/new-console-template for more information
using FindMaxNumUsingGeneric_Day13Assignment;

Console.WriteLine("Enter \n1 For FIND_MAX_Int_NUMBER_WITHOUT_GENERIC PROGRAM \n2 For FIND_MAX_FLOAT_NUMBER_WITHOUT_GENERIC PROGRAM \n3 For FIND_MAX_STRING_NUMBER_WITHOUT_GENERIC PROGRAM\n4 For FIND MAX_OUT_OF_MORE_THAN_THREE_NUMBER_USING_GENERIC PROGRAM \n");
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
    case 3:
        Console.WriteLine("\nWelcome to FIND_MAX_STRING_WITHOUT_GENERIC PROGRAM \n");
        Console.WriteLine("Maximum String : " + StringMaxWithoutGenerics.MaximumStringNumber("Ankush","Lokesh","Jeet"));
        break;
    case 4:
        Console.WriteLine("\nWelcome to FIND MAX_OUT_OF_MORE_THAN_THREE_NUMBER_USING_GENERIC PROGRAM \n");

        int[] intArray = { 100, 531, 432, 89, 34 };
        GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
        generic.PrintMaxValue();
        double[] doubleArray = { 85.5, 71.9, 35.4, 45.2, 67.8 };
        GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
        genericDouble.PrintMaxValue();
        string[] stringArray = { "Ankush", "Lokesh", "Jeet", "Himanshu", "Kalauddin" };
        GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
        genericString.PrintMaxValue();
        break;
}