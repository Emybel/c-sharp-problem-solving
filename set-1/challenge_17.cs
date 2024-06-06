
class Challenge17{
public static String CheckForYt(String str){
    
    if(str.Substring(1,2) == "yt"){
        return str.Remove(1,2);
    }
    else{
        return str;
    }
}
}
