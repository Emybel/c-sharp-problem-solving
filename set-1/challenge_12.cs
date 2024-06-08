class Challenge12{
    public static Boolean StartWithCsharp(){

        // Prompt user to enter a string
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        
        if(str.StartsWith("C#")){
            return true;
            }
            
            else{
                return false;
            }
        
        }
}
