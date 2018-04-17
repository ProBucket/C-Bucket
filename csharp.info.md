> Letter first then number sorting
```csharp
Func<string, bool> checkDigit = input =>
{
    bool isFirstCharDigit = char.IsDigit(input.First());
    return isFirstCharDigit;
};
List<string> list = new List<string> { "1A2.jpg", "A11B.jpg", "2.jpg", "B.jpg", "1.jpg", "A.jpg", "C.jpg" };
List<string> list1 = list.OrderBy(s => checkDigit(s)).ThenBy(s => s).ToList();
```
