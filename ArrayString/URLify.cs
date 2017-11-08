using System.Text;

public static class Urlify{

    public static string UrlifyString(string s){
        var newString = new StringBuilder();
        foreach(var c in s){
            if(char.IsWhiteSpace(c))
                newString.Append("%20");
            else
                newString.Append(c);

        }
        return newString.ToString();
    }
}