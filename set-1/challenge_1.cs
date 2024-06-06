
class Challenge1{
public static void SumAndTriple(){
// Prompt user to enter two numbers
Console.WriteLine("Enter two numbers: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

// Calculate the sum
int sum = x + y;

// Check if they're equal then sum*3
if(x == y){
    Console.WriteLine(sum*3);
    }
    else{
        Console.WriteLine(sum);

    }
}
}
