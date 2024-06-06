class Challenge23{
public static Boolean LastDigit(){

    int x = 123;
    int y = 456;
    
    //Convert the integrs into Strings
    String strX = x.ToString();
    String strY = y.ToString();

    //Compare the last digit of X and the last Digit of Y 
   if(strX[strX.Length-1] == strY[strY.Length-1]){
    return true;
   } 
   else{
    return false;
   }
}
}
