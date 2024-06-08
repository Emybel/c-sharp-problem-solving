class Challenge2_3 {
    public static void LengthInput()
    {
        // Prompt user to give a string
        Console.WriteLine("Enter a string: ");
        String str = Console.ReadLine();

        // Calculate the length of str
        Int32 len = str.Length;
        Console.WriteLine("Length of the string is : " + len);
    }
}