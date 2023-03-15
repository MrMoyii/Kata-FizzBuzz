# Kata-FizzBuzz
 
 ### Instructions
Write a program that displays the numbers from 1 to 100, substituting the multiples of 3 for the word “fizz”, the multiples of 5 for “buzz”, and the multiples of both, that is, the multiples of 3 and 5 ( or 15), for the word “fizzbuzz”.

### Examples
```
FizzBuzz(3) ➞ "Fizz"
FizzBuzz(5) ➞ "Buzz"
FizzBuzz(15) ➞ "FizzBuzz"
FizzBuzz(4) ➞ "4"
```
### Solution Code  
```cs
public static string[] Kata_FizzBuzz()
{
    string[] result = new string[100];

    for (int i = 0; i < 100; i++)
    {
        int n = i + 1;
        if (n % 3 == 0 && n % 5 == 0) result[i] = "FizzBuzz";
        else if (n % 3 == 0) result[i] = "Fizz";
        else if (n % 5 == 0) result[i] = "Buzz";
        else result[i] = n.ToString();

        Console.WriteLine(result[i]);
    }
    return result;
}
```
### Test
```cs
[TestMethod]
public void TestMethod1()
{
    string[] testList = Program.Kata_FizzBuzz();
    Assert.AreEqual("Fizz", testList[2]);
    Assert.AreEqual("Buzz", testList[4]);
    Assert.AreEqual("FizzBuzz", testList[14]);
}
```