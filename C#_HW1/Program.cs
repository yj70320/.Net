/*
 * C# Homework 1 
 * 
 * Short-Answer Questions
 * 
 * 1 Introduction to C# and Data Types
 * 1.1 What type would you choose for the following “numbers”?
 *     A person’s telephone number: string
 *     A person’s height: double
 *     A person’s age: int
 *     A person’s gender (Male, Female, Prefer Not To Answer): enum
 *     A person’s salary: decimal
 *     A book’s ISBN: string
 *     A book’s price: decimal
 *     A book’s shipping weight: double
 *     A country’s population: ulong
 *     The number of stars in the universe: ulong
 *     The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business): int
 * 
 * 1.2.1 What are the differences between value type and reference type variables?
 *       Value type stored the variable name and data together on stack. 
 *       When copy a value, the modifying of the copy won't changed the original variable.
 *     
 *       Reference type stored the variable name on the stack, and stored the data on heap. The name is an reference pointing to the data. 
 *       When copy a value, only the reference will be copied, two references (the original one and the copied one) point to the same address with the same data. 
 *       Modify the data will affect all references.
 *     
 * 1.2.2 What is boxing and unboxing?
 *       Boxing is to transfer a value type variable into an object type variable. The CLR will allocates memory on the heap and copy the value to the heap.
 *       Unboxing is to transfer an object type variable into a value type variable like int or float.
 *     
 * 1.3 What is meant by the terms managed resource and unmanaged resource in .NET?
 *    Managed resource is the resource that can be managed automatically by CLR, such as objects created by new keyword.
 *    
 *    Unmanaged resource is the resource that cannot be managed automatically by CLR.
 *    Such as file handle, after using, we have to close the resource manually by close() or dispose. 
 *    
 * 1.4 What is the purpose of the Garbage Collector in .NET?
 *     The purpose of the Garbage Collection is to automatically manage memory, so that developers don't have to allocate and free memory manually.
 *     It can also reduce memory leaks and improve application stability.
 *     
 *     
 * 2 Controlling Flow and Converting Types
 * 2.1 What happens when you divide an int variable by 0?
 *     CLR will throw an DivideByZeroException.
 *     
 * 2.2 What happens when you divide a double variable by 0?
 *     The result will be Infinity or NaN (0.0/0.0), no exception will be thrown.
 *     
 * 2.3 What happens when you overflow an int variable (assign a value beyond its range)?
 *     If checked, CLR will throw an OverflowException.
 *     If unchecked, there will a wrap around, the MaxValue will changed to MinValue, or the MinValue will changed to MaxValue.
 *     
 * 2.4 What is the difference between x = y++; and x = ++y;?
 *     x = y++ means the CLR will operate the assignment x = y first and then add 1 to the y, y is 1 larger than x.
 *     x = ++y means the CLR will add 1 to the y first and then operate the assignment x = y, y is equal to x.
 * 
 * 2.5 What is the difference between break, continue, and return when used inside a loop statement?
 *     Break will end the current loop statement.
 *     Continue will skip the rest code in the current loop statement, and start the next round of the loop.
 *     Return will end the whole function and return a value if it's not a void function.
 *     
 * 2.6 What are the three parts of a for statement and which of them are required?
 *     For statement include (initializer; condition; iterator).
 *     All three parts can be skipped but the two simicolon ; are required.
 *     
 * 2.7 What is the difference between the = and == operators?
 *     = is assignment operation, copy the value of one variable to another variable.
 *     == is compare operation, compare whether the two variables are the same and return a boolean result.
 *     For value type variable, == compares the value. For reference type variable, == compares the reference. It can be overriden. 
 *     
 * 2.8 Does the following statement compile? for ( ; true; ) ;
 *     Yes, for ( ; true; ) ; is the same as for ( ; ; );.
 *     Semicolon ; means the for statement includes nothing, it is a infinite empty for loop that will run forever. 
 *     
 * 2.9 What interface must an object implement to be enumerated by the foreach statement?
 *     IEnumerable / IEnumerable<T> interface must be implemented to use foreach statement.
 */

/* Coding question 1
 * How can we find the minimum and maximum values, as well as the number of bytes, for the following data types: 
 * sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal?
 * 
 * We can find all the minimum and maximum values by .MinValue and .MaxValue.
 */

Console.WriteLine("Coding question 1");
Console.WriteLine($"sbyte: {sizeof(sbyte)} bytes, {sbyte.MinValue} ~ {sbyte.MaxValue}");
Console.WriteLine($"byte: {sizeof(byte)} bytes, {byte.MinValue} ~ {byte.MaxValue}");
Console.WriteLine($"short: {sizeof(short)} bytes, {short.MinValue} ~ {short.MaxValue}");
Console.WriteLine($"ushort: {sizeof(ushort)} bytes, {ushort.MinValue} ~ {ushort.MaxValue}");
Console.WriteLine($"int: {sizeof(int)} bytes, {int.MinValue} ~ {int.MaxValue}");
Console.WriteLine($"uint: {sizeof(uint)} bytes, {uint.MinValue} ~ {uint.MaxValue}");
Console.WriteLine($"long: {sizeof(long)} bytes, {long.MinValue} ~ {long.MaxValue}");
Console.WriteLine($"ulong: {sizeof(ulong)} bytes, {ulong.MinValue} ~ {ulong.MaxValue}");
Console.WriteLine($"float: {sizeof(float)} bytes, {float.MinValue} ~ {float.MaxValue}");
Console.WriteLine($"double: {sizeof(double)} bytes, {double.MinValue} ~ {double.MaxValue}");
Console.WriteLine($"decimal: {sizeof(decimal)} bytes, {decimal.MinValue} ~ {decimal.MaxValue}");
Console.WriteLine();

/* Coding question 2
 * Write a method in C# called FizzBuzz that takes an integer num and prints numbers from 1 up to num, but:
 * Print Fizz if the number is divisible by 3.
 * Print Buzz if the number is divisible by 5.
 * Print FizzBuzz if the number is divisible by both 3 and 5.
 * Otherwise, print the number itself.
 */

void FizzBuzz(int n)
{
    if (n % 3 == 0 && n % 5 == 0) Console.WriteLine("FizzBuzz");
    else if (n % 3 == 0) Console.WriteLine("Fizz");
    else if (n % 5 == 0) Console.WriteLine("Buzz");
    else Console.WriteLine(n);
}

Console.WriteLine("Coding question 2");
Console.Write("test case: n = 1   result: "); FizzBuzz(1);
Console.Write("test case: n = 3   result: "); FizzBuzz(3);
Console.Write("test case: n = 5   result: "); FizzBuzz(5);
Console.Write("test case: n = 7   result: "); FizzBuzz(7);
Console.Write("test case: n = 30  result: "); FizzBuzz(30);
Console.WriteLine();

/* Coding question 3
 * What will happen if this code executes?
 * int max = 500;
 * for (byte i = 0; i < max; i++)
 * {
 *     Console.WriteLine(i);
 * }
 * 
 * CLR will print forever from 0 to 255.
 * The range of byte is (0, 255). After reaching 255, i++ wraps around to 0. 
 * As (0, 255) is always smaller than 500, the for statement will never end.
 * 
 */


/* Coding question 4: Two Sum
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 * You may assume that each input would have exactly one solution.
 * You may not use the same element twice.
 * You can return the answer in any order.
 */

int[] TwoSums(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] + nums[i] == target) return new int[] { i, j };
        }
    }
    return new int[] { -1, -1 };
}

int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Coding question 4");
Console.WriteLine($"int[] nums: [{string.Join(", ", nums)}]");
Console.WriteLine("target: 6      result: [" + string.Join(", ", TwoSums(nums, 6)) + "]");
Console.WriteLine("target: 17     result: [" + string.Join(", ", TwoSums(nums, 17)) + "]");
Console.WriteLine("target: 50     result: [" + string.Join(", ", TwoSums(nums, 50)) + "]");