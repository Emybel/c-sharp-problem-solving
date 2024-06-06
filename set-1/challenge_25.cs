class Challenge25{
public static String NumberOfCopies(){

    int n = 4;
    String str = "JS";
    //Repeat the string to the number of n
    
    // This is the short solution by using (Concat and Repeat methods)
    // String result = string.Concat(Enumerable.Repeat(str, n));
    
    // This is the longer solution by using (for loop)
    String result = "";

    for (int i = 0; i < n; i++)
    {
        result = result + str;
    }

    return result;
}
}
