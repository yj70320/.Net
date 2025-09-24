/*
 * C# Homework 3
 * 
 * Short-Answer Questions
 * 1 Describe the problem generics address.
 *   (1) Generics increases code reuse. Without generics, developers have to write a lot of codes for different data types, 
 *       yet the functions is actually the same. 
 *   (2) Generics provides compiler-time checking. Compiler cannot check object type error, and this can cause exception while running the code.
 *   (3) Generics avoids boxing and unboxing of data types, this can increase performance.
 *   
 * 2 How would you create a list of strings, using the generic List class?
 *   List<string> names = new List<string>();
 *   
 * 3 How many generic type parameters does the Dictionary class have?
 *   2 types: TKey and Tvalue, corresponding to keys and values of dictionary
 * 
 * 4 True/False. When a generic class has multiple type parameters, they must all match.
 *   False. Each parameters can be different types
 * 
 * 5 What method is used to add items to a List object?
 *   Add() method
 *   
 * 6 Name two methods that cause items to be removed from a List.
 *   Remove() method, RemoveAt() method
 * 
 * 7 How do you indicate that a class has a generic type parameter?
 *   By putting the tpye name in the <>.
 *   e.g. List<string> names = new List<string>();
 * 
 * 8 True/False. Generic classes can only have one generic type parameter.
 *   False. 
 * 
 * 9 True/False. Generic type constraints limit what can be used for the generic type.
 *   True
 * 
 * 10 True/False. Constraints let you use the methods of the thing you are constraining to.
 *    True
 */

/* Coding question
 * 1 MyStack<T> class
 * 2 IGenericRepository<T> where T: class
 * 3 GenericReposity<T>
 */

using C__HW3;

Console.WriteLine("C# HW3 Coding Question");
Console.WriteLine("\n=================== Task 1 test ===================");
MyStack<int> myStack = new MyStack<int>();
myStack.Push(10);
myStack.Push(20);
Console.WriteLine("Stack element count:" + myStack.Count());
Console.WriteLine("Pop element:" + myStack.Pop());
Console.WriteLine("Pop element:" + myStack.Pop());
Console.WriteLine("Current stack element count:" + myStack.Count());

Console.WriteLine("\n=================== Task 2 test ===================");
Console.WriteLine("-- Test Add() and GetAll()");
Student student1 = new Student();
student1.Id = 0;
student1.Name = "Alice";
Student student2 = new Student();
student2.Id = 1;
student2.Name = "Bob";
IGenericRepository<Student> repo = new GenericRepository<Student>();
repo.Add(student1);
repo.Add(student2);

foreach (Student s in repo.GetAll())
{
    Console.WriteLine(s);
}
Console.WriteLine("\n-- Test GetById()");
Console.WriteLine(repo.GetById(0));
Console.WriteLine(repo.GetById(1));

Console.WriteLine("\n-- Test Remove(): delete student Bob");
repo.Remove(student2 as Student);
foreach (Student s in repo.GetAll())
{
    Console.WriteLine(s);
}