
class Challenge19{
    public static int CloseTo100(){
        
        // Prompt user to give 2 nums
        Console.WriteLine("Enter 2 numbers : ");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        
        // Check for the closest num to 100
        if(100 - x < 100 - y){
            return x;
        }
        else{
            return y;
        }

    }
}
