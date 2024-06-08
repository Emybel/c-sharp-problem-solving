class Challenge3_3 {
    public static void PrintSeperateChar()
    {
        // Prompt user to give a string
        Console.WriteLine("Enter a string: ");
        String str = Console.ReadLine();

        for (int i=0; i <= str.Length-1; i++ ){
            
            //Print each char of str
            Console.Write("{0} ",str[i]);
        }
    }
}