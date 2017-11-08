public static class UniqueString{
    public static bool StringWithUniqueCharacters(string s){
        var length = s.Length;
        for(int i = 0; i < length; i ++){
            for(int j = i + 1; j < length; j++ ){
                if(s[i] == s[j])
                    return false;
            }
        }
        return true;
    }
}