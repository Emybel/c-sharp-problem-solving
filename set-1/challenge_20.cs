
class Challenge20{ 
    public static Boolean Compare2Numbers(){
        
        // Prompt user to give 2 nums
        Console.WriteLine("Enter two numbers: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        // Check if they're both in range [40,50] || they're both in range [50,60]
        if( x>=40 && x<=60 && y>=40 && y<=60) {
            return true;
        }
        else {
            return false;
        }
    }
}
