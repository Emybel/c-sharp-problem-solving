class Challenge25{
    public static String NumberOfCopies(){

        // Prompt user to give a string and a number
        Console.WriteLine("Enter number of copies: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        // Prompt user to enter a string
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        
        //Repeat the string to the number of n
        
        // This is the short solution by using (Concat and Repeat methods)
        // String result = string.Concat(Enumerable.Repeat(str, n));
        
        // This is the longer solution by using (for loop)
        String result = "";

        for (int i = 0; i < n; i++)
        {
            result = result + str + ". ";
        }

        return result;
    }
}
