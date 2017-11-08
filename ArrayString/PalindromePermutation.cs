public static class PalindromePermuation{
    public static bool Check(string s){
        var frq = new int[128];
        var stringCheck = s.ToLower();
        var length = 0;
        foreach(var c in stringCheck){
            if(char.IsLetter(c)){
                frq[(int)c]++;
                length ++;                
            }
        }
        var checkForOne = length % 2 != 0;
        
        foreach(var item in frq){
            if(checkForOne && item % 2 != 0){
                checkForOne = false;
                continue;                
            }
            if(!checkForOne && item % 2 != 0)
                return false;
        }

        return true;
    }
}