string st = "I am a string!";

Console.WriteLine(st + "\n");

Console.WriteLine(st.ToLower());
Console.WriteLine(st.ToUpper());

string string1 = "Imran";
string string2 = "ImRan";
int n = string.Compare(string1, string2);  // return 0 if equals,return 1 if string1 is greater,return -1 if string2 is greater

Console.WriteLine(n + "\n");

string name = "Md Imran Khan";
bool b1 = name.Contains("Khan");
bool b2 = name.Contains("sheikh");

Console.WriteLine(b1);
Console.WriteLine(b2 + "\n");

char[] characterArray = st.ToArray();
foreach (char c in characterArray)
{
    Console.WriteLine(c);
}