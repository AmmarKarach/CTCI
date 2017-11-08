public static class Common{
    public static int[] GetStringFrequency(string s){
        var frq = new int[128];
        foreach(var c in s){
            frq[(int)c]++;
        }
        return frq;
    }
}