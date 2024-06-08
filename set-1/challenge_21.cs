
class Challenge21{ 
    public static int ReturnBiggerNum(){
        
        // Prompt user to give 2 nums
        Console.WriteLine("Enter two numbers: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        // Check for the largest num if they're both in the range [20,30]
        if( x>=20 && x<=30 && y>=20 && y<=30) {
            if(x<y) {
                return y;
            }
            else {
                return x;
            }

        }
        return 0;
    }
}