
class Challenge15{
    public static Boolean InRange3Values(){
        
        // Prompt user to give 3 nums
        Console.WriteLine("Enter three numbers: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        // Check if 1 of the nums or more is/are in range [20,50]
        if(x >= 20 && x <= 50 || y >= 20 && y <= 50 || z >= 20 && z <= 50){
            return true;
        }
        else{
            return false;
        }
    }
}
