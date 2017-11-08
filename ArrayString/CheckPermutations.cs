public static class CheckPermuatations{
    public static bool Check(string a, string b){
        var length = a.Length;
        if(a.Length != b.Length)
            return false;
        
        var frequencyCount = new int [128];

       for(int i = 0; i < length;  i++){
           frequencyCount[(int)a[i]]++;
           frequencyCount[(int)b[i]]--;
       }

       foreach(var item in frequencyCount){
           if(item != 0)
            return false;
       }

        return true;
    }
}