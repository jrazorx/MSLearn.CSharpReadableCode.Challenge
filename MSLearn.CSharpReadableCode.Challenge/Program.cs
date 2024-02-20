/*
The high-level purpose of this code is to : 
1. reverse a string
2. count the number of times the character 'o' appears
*/

string str = "The quick brown fox jumps over the lazy dog.";

// String reverse part
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);
string new_message = new String(charMessage);
Console.WriteLine(new_message);

// Characters count part
int x = 0;
foreach (char i in charMessage) {
    if (i == 'o') {
        x++;
    }
}
Console.WriteLine($"'o' appears {x} times.");