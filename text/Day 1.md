# C# Day 1 Notes

## 1. Arithmetic Operator
It performs mathematical operations.

Examples:
- `+` -> addition
- `-` -> subtraction
- `*` -> multiplication
- `/` -> division
- `%` -> modulus

```csharp
int a = 10;
int b = 5;
int c = a + b;
```

## 2. Assignment Operator
It assigns a value to a variable.

```csharp
int x = 10;
x = 20;
x += 1;   // x = x + 1;
```

## 3. Relational Operator
It compares two values.

```csharp
int a = 5;
int b = 6;

Console.WriteLine(a == b);  // false
Console.WriteLine(a != b);  // true
Console.WriteLine(a >= b);  // false
```

> Note: In C#, there is no `===` operator. The operator `==` is used for comparison.

## 4. Logical Operator
It is used to combine conditions.

Examples:
- `||` -> OR  (any one condition true)
- `&&` -> AND (both conditions true)
- `!` -> NOT

## 5. Bitwise Operator
It works on binary numbers.

```csharp
int a = 5;   // 0101
int b = 3;   // 0011
int c = a & b;   // 0001
int d = a | b;   // 0111
int e = a ^ b;   // 0110
```

# Flow Control
Flow control is used to make decisions in a program.

## 1. if statement
It executes a block of code when the condition is true.

```csharp
int n = 10;
if (n > 5)
{
    Console.WriteLine("n is greater than 5");
}
```

## 2. if else statement
It executes one block if the condition is true, otherwise another block.

```csharp
int age = 18;
if (age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Minor");
}
```

## 3. if else if else statement
It checks multiple conditions one by one.

```csharp
int marks = 75;
if (marks >= 90)
{
    Console.WriteLine("Grade A");
}
else if (marks >= 70)
{
    Console.WriteLine("Grade B");
}
else
{
    Console.WriteLine("Grade C");
}
```

## 4. Nested if
An if statement inside another if statement.

```csharp
int x = 10;
int y = 5;

if (x > 5)
{
    if (y > 3)
    {
        Console.WriteLine("Both conditions are true");
    }
}
```

## 5. switch statement
It is used when you want to check many possible values.

```csharp
int day = 2;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    default:
        Console.WriteLine("Other day");
        break;
}
```
