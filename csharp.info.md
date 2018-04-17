> Letter first then number sorting
```csharp
Func<string, bool> checkDigit = input =>
{
    bool isFirstCharDigit = char.IsDigit(input.First());
    return isFirstCharDigit;
};
List<string> list = new List<string> { "1A2.jpg", "A11B.jpg", "2.jpg", "B.jpg", "1.jpg", "A.jpg", "C.jpg" };
List<string> list1 = list.OrderBy(s => checkDigit(s)).ThenBy(s => s).ToList();
// Output : A, A11B, B, C, 1, 1A2, 2
```
> Date formatting
```csharp
DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
Console.WriteLine("Message: {0}", chat);
```
