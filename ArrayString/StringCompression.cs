using System;
using System.Collections.Generic;
using System.Text;
public static class StringCompression{
    public static string Compress(string s){
        var length = s.Length;
        var previous = s[0];
        var count = 1;
        var list = new List<Tuple<char, int>>();
        for(int i = 1; i < length; i ++){
            if(previous != s[i]){
                list.Add(new Tuple<char, int>(previous, count));
                previous = s[i];
                count  = 1;
            }else{
                previous = s[i];
                count ++;
            }

        }
        list.Add(new Tuple<char, int>(previous, count));
        var stringBuilder = new StringBuilder();
        foreach(var item in list){
            stringBuilder.Append(item.Item1.ToString() + item.Item2);
        }

        var compressedString = stringBuilder.ToString();
        
        return compressedString.Length > length ? s : compressedString;
    }
}