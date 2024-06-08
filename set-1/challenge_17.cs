
class Challenge17{
    public static String CheckForYt(){
        
        //Prompt user to give a string
        Console.WriteLine("Enter a string: ");
        String str = Console.ReadLine();

        // Check if string is not empty
        if(!string.IsNullOrEmpty(str)){

            if(str.Substring(1,2) == "yt"){
                return str.Remove(1,2);
            }
            else{
                return str;
            }
        } 
        else{
            // Handle the case when empty string
            return "Empty string !";
        }  
    }
}
