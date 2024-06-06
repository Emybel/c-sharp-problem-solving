
class Challenge18{
public static int LargestNumber(){
    
    int x = 1;
    int y = 2;
    int z = 3;

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
