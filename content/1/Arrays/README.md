# Arrays

---

Arrays in C# are very similar to arrays in C. They are defined using the brackets operator `[]`, and they are initialized using a list defined with curly braces. For example:

```csharp
int[] nums = { 1, 2, 3, 4, 5 };
```

We can also define an empty array like this:

```csharp
int[] nums = new int[10];
```

To get the size of the array, use the `Length` method.

```csharp
int[] nums = new int[10];
Console.WriteLine(nums.Length);
```

To access a specific item in the array, we use the brackets operator:

```csharp
int[] nums = new int[10];
int firstNumber = nums[0];
int secondNumber = nums[1];
nums[2] = 10;
```

Notice that C# uses zero based indices.

### Multidimensional arrays

C# supports multidimensional arrays, defined in the following manner:

```csharp
int[,] matrix = new int[2,2];

matrix[0,0] = 1;
matrix[0,1] = 2;
matrix[1,0] = 3;
matrix[1,1] = 4;

int[,] predefinedMatrix = new int[2,2] { { 1, 2 }, { 3, 4 } };
```

### Jagged arrays

These are multidimensional arrays where each subarray is an independent array - Can have subarrays of different lengths. Use a separate set of square brackets for each dimension of the array.

##### jagArray1`[2][7][4]`

Unlike other types of arrays, you cannot fully instantiate a jagged array in a single step. Since a jagged array is an array of independent arrays, each array must be created separately.

For example, the following code shows the declaration, instantiation, and initialization of a twodimensional jagged array. 

Notice in the code that the reference to each subarray is assigned to an element in the top-level array. 

```csharp
int[][] Arr = new int[3][]; 
Arr[0] = new int[] {10, 20, 30}; 
Arr[1] = new int[] {40, 50, 60, 70}; 
Arr[2] = new int[] {80, 90, 100, 110, 120};
```
## Exercise

Define an array called `fruits` that holds the following strings: "apple", "banana", and "orange".

### Given

```csharp
using System;

public class Tutorial
{
   public static void Main()
   {
      // write your code here

      // test code
      Console.WriteLine(fruits[0]);
      Console.WriteLine(fruits[1]);
      Console.WriteLine(fruits[2]);
   }
}
```

### Solution

```csharp
using System;

public class Tutorial
{
   public static void Main()
   {
      string[] fruits = { "apple", "banana", "orange" };

      // test code
      Console.WriteLine(fruits[0]);
      Console.WriteLine(fruits[1]);
      Console.WriteLine(fruits[2]);
   }
}
```