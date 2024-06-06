
class Challenge5{
public static String StartWithIf(){

    // Prompt user to give a string
    Console.WriteLine("Enter a string: ");
    String str = Console.ReadLine();

    if(!string.IsNullOrEmpty(str) && str.StartsWith("if")){
        return str;
    }
    
    else{
        return "if" + " " + str;
    }
}
}
