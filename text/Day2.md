# C vs C# Differences

Here are some common differences between C and C#:

## 1. Printing output

### C
```c
#include <stdio.h>

int main() {
    printf("Hello\n");
    return 0;
}
```

### C#
```csharp
using System;

class Program {
    static void Main() {
        Console.WriteLine("Hello");
    }
}
```

- C uses `printf()`
- C# uses `Console.WriteLine()` or `Console.Write()`

## 2. Taking input

### C
```c
#include <stdio.h>

int main() {
    int age;
    scanf("%d", &age);
    printf("Age = %d\n", age);
    return 0;
}
```

### C#
```csharp
using System;

class Program {
    static void Main() {
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Age = " + age);
    }
}
```

- C uses `scanf()`
- C# uses `Console.ReadLine()` and converts input with `int.Parse()`

## 3. Switch case

### C
```c
#include <stdio.h>

int main() {
    int x = 2;

    switch (x) {
        case 1:
            printf("One\n");
            break;
        case 2:
            printf("Two\n");
            break;
    }

    return 0;
}
```

### C#
```csharp
using System;

class Program {
    static void Main() {
        int x = 2;

        switch (x) {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
        }
    }
}
```

- The syntax is very similar
- In C#, `switch` is also used in the same way, but the output method is different

## 4. Variable declaration

### C
```c
int age = 20;
```

### C#
```csharp
int age = 20;
```

- Both use similar variable declaration syntax
- C# also supports features like `var` for type inference

## 5. Memory management

### C
- You must manually allocate and free memory using `malloc()` and `free()`

### C#
- Memory is managed automatically by the garbage collector

## 6. Programming style

### C
- Procedural programming language

### C#
- Modern language mainly used for object-oriented programming

## 7. Main function

### C
```c
int main() {
    return 0;
}
```

### C#
```csharp
class Program {
    static void Main() {
    }
}
```

- C uses `main()` as the starting point
- C# uses `Main()` inside a class

## Quick summary

- C is a low-level and procedural language
- C# is a modern, high-level language designed for .NET
- C uses `printf()` and `scanf()`
- C# uses `Console.WriteLine()` and `Console.ReadLine()`
