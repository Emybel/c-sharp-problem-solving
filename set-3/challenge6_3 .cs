class Challenge6_3 {
    public static void Compare2Strings()
    {
        // Prompt user to give a string
        Console.WriteLine("Enter 2 strings: ");
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();

        // Check if string is not empty
        if (str1.Length == 0 || str2.Length == 0)
        {
            Console.WriteLine("Missing String(s)");
            return;
        }

        // Check if the lengths are equal
        if (str1.Length != str2.Length)
        {
            Console.WriteLine("The lengths of the strings are not equal.");
            return;
        }

        // Compare the strings character by character
        bool areEqual = true;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                areEqual = false;
                break;
            }
        }

        // Print the result
        if (areEqual)
        {
            Console.WriteLine("The length of both strings are equal and also, both strings are equal.");
        }
        else
        {
            Console.WriteLine("The strings are not equal.");
        }
    }

}