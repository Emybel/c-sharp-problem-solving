
class Problem8_2{
    public static String LargestInputNumber(){
    Console.Write("Input the 1st number: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the 2ed number: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the 3ed number: ");
    int z = Convert.ToInt32(Console.ReadLine());

    if(x>y && x>z){
        return "The 1st Number is the greatest among three";
    }
    else if (y > x && y > z){
        return "The 2ed Number is the greatest among three";
    }
    else{
        return "The 3ed Number is the greatest among three";
    }

}
}

