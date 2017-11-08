public static class OneAway
{
    public static bool IsStringOneAway(string a, string b){
        var frqa = Common.GetStringFrequency(a);
        var frqb = Common.GetStringFrequency(b);
        var oneDiff = false;
        for(int i = 0; i < 128; i++){
            var diff = System.Math.Abs(frqa[i] - frqb[i]);
            if(diff == 1){
                if(oneDiff)
                    return false;
                else
                    oneDiff = true;

            } 
        }
        return true;
    }
}