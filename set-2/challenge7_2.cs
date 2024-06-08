
class Problem7_2{
public static String CatigorizeHeights(){
    
    Console.Write("Enter Height in cm: ");
    int x = Convert.ToInt32(Console.ReadLine());

    if(x < 150){
        return "This Person is dwarf";
    }   
    else if(x > 150 && x< 180){
        return "This Person is average height";
    }
    else{
        return "This Person is tall";
    }

}
}
