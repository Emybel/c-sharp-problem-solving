
class Challenge8{
public static String RepeatStr(){

    // Prompt user to give a string
    Console.WriteLine("Enter a string: ");
    String str = Console.ReadLine();

    // Check if the input string is null or empty
    if (!string.IsNullOrEmpty(str)){
        if(str.Length >= 2){
                return string.Concat(Enumerable.Repeat(str.Remove(2), 4));
            }
            
            else{
                return str;
            }
    }
    else{
        // Handle the case when the input string is null or empty
        return "Empty string !";
    }
}
}
