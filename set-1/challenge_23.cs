class Challenge23{
    public static Boolean LastDigit(){

        // Prompt user to give 2 nums
        Console.WriteLine("Enter two positive numbers: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        
        //Check if the last digit of X and Y are positive
        if(x> 0 && y> 0){
            //Convert the integrs into Strings
            String strX = x.ToString();
            String strY = y.ToString();
            //Compare the last digit of X and the last Digit of Y 
                if(strX[strX.Length-1] == strY[strY.Length-1]){
                    return true;
                } 
                else{
                    return false;
                }
        }
        else{
            return false;
        }
    }
}
