
class Problem9_2{
    public static String XYcoordinate(){
    Console.Write("Input the value for X coordinate: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the value for Y coordinate: ");
    int y = Convert.ToInt32(Console.ReadLine());


    if(x > 0 && y > 0){
        return "The coordinate point ("+x +"," + y+") lies in the First quadrant";
    }
    else if (x < 0 && y > 0){
        return "The coordinate point ("+x +"," + y+") lies in the Second quadrant";
    }
    else if (x < 0 && y < 0){
        return "The coordinate point ("+x +"," + y+") lies in the Third quadrant";
    }
    else{
        return "The coordinate point ("+x +"," + y+") lies in the Fourth quadrant";
    }

}
}

