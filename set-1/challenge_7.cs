
class Challenge7{
public static String ReplaceFirtWithLast(){

    // Prompt user to give a string
    Console.WriteLine("Enter a string: ");
    String str = Console.ReadLine();
    
    // Check if the input string is null or empty
        if (!string.IsNullOrEmpty(str))
        {
            // Store first char in temp
            char temp = str[0];

            // Replace First char by last char
            string result = str.Replace(str[0], str[str.Length - 1]);
            result = result.Remove(result.Length - 1);

            return result + temp;
        }
        else
        {
            // Handle the case when the input string is null or empty
            return string.Empty;
        }
}
}
