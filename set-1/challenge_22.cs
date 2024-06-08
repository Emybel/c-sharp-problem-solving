class Challenge22{ 
    public static Boolean CheckForZ(){
        
        // Prompt user to give a string
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        int Zcount = 0; 

        // Check if the string contains between 2-4 'z' char
        for(int i =0; i<str.Length; i++){
            if(str[i] == 'z'){
                Zcount++;
            }
            
        }
        if(Zcount>=2 && Zcount<4){
            return true;
        }
        else{
            return false;
        }
    }
}