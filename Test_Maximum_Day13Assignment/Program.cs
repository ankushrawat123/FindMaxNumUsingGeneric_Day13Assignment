// See https://aka.ms/new-console-template for more information
using FindMaxNumUsingGeneric_Day13Assignment;

Console.WriteLine("Enter \n1 For FIND_MAX_Int_NUMBER_WITHOUT_GENERIC PROGRAM \n2 For FIND_MAX_FLOAT_NUMBER_WITHOUT_GENERIC PROGRAM \n3 For FIND_MAX_STRING_NUMBER_WITHOUT_GENERIC PROGRAM\n4 For FIND MAX_OUT_OF_MORE_THAN_THREE_NUMBER_USING_GENERIC PROGRAM \n5 Welcome to REFACTOR PROGRAM TO FIND_MAX_INT_DOUBLE_STRING_NUMBER WITH GENERICS\n");
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
        Console.WriteLine("\nArray int Value Before Sorting");
        generic.display();
        generic.Sort();
        Console.WriteLine("\nArray int Value After Sorting");
        generic.display();
        generic.PrintMaxValue();

        double[] doubleArray = { 85.5, 71.9, 35.4, 45.2, 67.8 };
        GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
        Console.WriteLine("\nArray Double Value Before Sorting");
        genericDouble.display();
        genericDouble.Sort();
        Console.WriteLine("\nArray Double Value After Sorting");
        genericDouble.display();      
        genericDouble.PrintMaxValue();

        string[] stringArray = { "Ankush", "Lokesh", "Jeet", "Himanshu", "Kalauddin" };
        GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
        Console.WriteLine("\nArray String Value Before Sorting");
        genericString.display();
        genericString.Sort();
        Console.WriteLine("\nArray String Value After Sorting");
        genericString.display();
        genericString.PrintMaxValue();
        break;

    case 5:
        Console.WriteLine("\nWelcome to REFACTOR PROGRAM TO FIND_MAX_INT_DOUBLE_STRING_NUMBER WITH GENERICS\n");
        Refactor<int> intObj = new Refactor<int>(100, 531, 432);
        Console.WriteLine("Maximum Int Number: " + intObj.MaxValue(100, 531, 432));
        Refactor<double> doubleObj = new Refactor<double>(55.5, 43.2, 498.5);
        Console.WriteLine("Maximum Double Number: " + doubleObj.MaxValue(55.5, 43.2, 498.5));      
        Refactor<string> stringObj = new Refactor<string>("Ankush", "Jeet", "Kalauddin");
        Console.WriteLine("Maximum String Number: " + stringObj.MaxValue("Ankush", "Jeet", "Kalauddin"));
        break;
}   