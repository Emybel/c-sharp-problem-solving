class Challenge5_3 {
    public static void TotalWords()
    {
        // Prompt user to give a string
        Console.WriteLine("Enter a string: ");
        String str = Console.ReadLine();

        // Check if string is not empty
        if (str.Length == 0){
            Console.WriteLine("String is empty");
            return;
        }
        // Initialize a counter
        int count = 1;

        // Loop through the str 
        for (int i = 0; i <= str.Length-1 ; i++ ){
            
            // Check for existing char after blank spaces
            if (str[i] == ' ' && str[i+1]!=' '){
                // Increment the counter
                count++;
            }
        }
        Console.Write("Number of words in the string is : " + count);
    }
}