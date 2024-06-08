class Challenge4_3 {
    public static void PrintReversedChar()
    {
        // Prompt user to give a string
        Console.WriteLine("Enter a string: ");
        String str = Console.ReadLine();

        for (int i = str.Length-1; i >= 0 ; i-- ){
            
            //Print each char of str
            Console.Write("{0} ", str[i]);
        }
    }
}