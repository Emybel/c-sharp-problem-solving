
class Challenge18{
    public static int LargestNumber(){
        
        // Prompt user to give 3 nums
        Console.WriteLine("Enter three numbers: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        // Check for the largest num
        if(x>y && x>z){
            return x;
        }
        else if (y > x && y > z){
            return y;
        }
        else{
            return z;
        }

    }
}
