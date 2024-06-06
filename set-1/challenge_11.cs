class Challenge11{
    public static String AddThreeChars(){

        // Prompt user to give a string
        Console.WriteLine("Enter a string: ");
        String str = Console.ReadLine();

        // Check if str is not empty
        if(!string.IsNullOrEmpty(str)){
            if(str.Length >= 3){
            String firstThreeChs = str.Remove(3);
            return firstThreeChs + str + firstThreeChs;
            }
        
            else{
                return str + str + str;
            }
        
        }
        else{
            // Handle the case when the input string is null or empty
            return "Empty string !";

        }   
    }
}
