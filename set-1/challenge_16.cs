
class Challenge16{
    public static Boolean InRange2Values(){
        
        // Prompt user to give two values
        Console.WriteLine("Enter two numbers: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        // Check if one of the values is in range [20,50]
        if(x >= 20 && x <= 50 || y >= 20 && y <= 50){
            return true;
        }
        else{
            return false;
        }
    }
}
