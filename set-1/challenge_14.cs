
class Challenge14{
    public static Boolean InRange(){
        
        //  Prompt user to give two nums
        Console.WriteLine("Enter two numbers: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        // Check if x is in range of 100 to 200 and y is in range of 100 to 200
        if(x >= 100 && x <= 200 && y >= 100 && y <= 200){
            return true;
        }
        else{
            return false;
        }
    }
}
