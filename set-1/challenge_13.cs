
class Challenge13{
    public static Boolean Temperature(){
        
        // Prompt the user to enter tow tempreratures
        Console.WriteLine("Enter temperatures : ");
        int temp1 = Convert.ToInt32(Console.ReadLine());
        int temp2 = Convert.ToInt32(Console.ReadLine());

        // Check if Tempretures +/-
        if(temp1 < 0 || temp1 > 100 && temp2 < 0 || temp2 > 100){
            return true;
        }
        else{
            return false;
        }
    }
}
