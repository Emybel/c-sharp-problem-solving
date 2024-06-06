
class Challenge9{
public static String AddOneChar(){

    // Prompt user to enter a string
    Console.WriteLine("Enter a string: ");
    String str = Console.ReadLine();
    
    // Check if str is not empty
    if (!string.IsNullOrEmpty(str)){
        // Add one char to the end of the string
        return  str[str.Length - 1] + str;
    }
    else{
        // Handle the case when the input string is null or empty
        return "Empty string !";

    }
}
}
