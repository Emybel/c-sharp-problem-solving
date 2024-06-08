class Challenge24_3 {
    public static void AlphaOrderLastName()
    {
        // prompt user to give 2 full names
        Console.WriteLine("Enter 2 full names: ");
        String name1 = Console.ReadLine();
        String name2 = Console.ReadLine();

        // Initialize 2 empty strings for the last names
        string lastName1 = "";
        string lastName2 = "";

        // Loop through name1 to find the last name
        for (int i = 0; i < name1.Length ; i++)
        {
            if ( name1[i] == ' ' ){
            
            lastName1= name1.Substring(i+1);
            break;
            }
        }

        // Loop through name2 to find the last name
        for (int i = 0; i < name2.Length ; i++)
        {
            if ( name2[i] == ' '){
            
            lastName2= name2.Substring(i+1);
            break;
            }
        }

        // Compare the last names
        int result = string.Compare(lastName1, lastName2, StringComparison.OrdinalIgnoreCase);

        // Print the names in alphabetical order of the last names
        if (result < 0)
        {
            Console.WriteLine(name1);
            Console.WriteLine(name2);
        }
        else
        {
            Console.WriteLine(name2);
            Console.WriteLine(name1);
        }
    }
}