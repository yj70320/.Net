/* 
 * C# Homework 2 
 * 
 * Short-Answer Questions: OOP
 * 1 What are the six combinations of access modifier keywords and what do they do?
 *   public: the variable, method or class can be used anywhere and no limitations.
 *   private: the variable or method can only be used in the class which defines it
 *   protected: : the variable or method can only be used in the class which defines it and its subclasses.
 *   internal: the variable, method or class can only be used in the same assembly (compiled project output).
 *   protexted internal: the variable, method or class can only be used in the same assembly or its subclasses.
 *   private protected: the variable, method or class can only be used in the class which defines it and its subclasses in the same assembly.
 *   
 * 2 What is the difference between the static, const, and readonly keywords when applied to a type member?
 *   static: declare a variable or method belong to the class itself instead of an instance.
 *           there is only one copy, and can be changed at runtime.
 *   const: declare a constant variable that is sured during compiling, the variable must be initialized when declared.
 *   readonly: declare a variable that is only defined while declaring or in the constructors. Once defined, the variable cannot be changed.
 *   
 * 3 What does a constructor do?
 *   A construtor is a special method that is used to create an instance/object of a class. 
 *   
 * 4 Why is the partial keyword useful?
 *   The partial keyword allows the definition of a class, struct, or interface to be split across multiple files. 
 *   This is useful for team collaboration, because different developers can work on different parts of the same type 
 *   without editing the same file. 
 * 
 * 5 What is a tuple?
 *   A tuple is a data structure that can hold a certain number of elements of different types.
 * 
 * 6 What does the C# record keyword do?
 *   record is used to define a reference type that is intended to hold immutable data. It can include multiple values.
 *   
 * 7 What does overloading and overriding mean?
 *   overloading: define multiple methods in the same class with the same name but different parameter lists
 *   overriding: provide a new implementation of a virtual or abstract method in a subclass
 *   
 * 8 What is the difference between a field and a property?
 *   A field: Variables declared in a class, usually kept private.
 *   A property: the getters and setters of attributes, provides controlled access to fields.
 *  
 * 9 How do you make a method parameter optional?
 *   We can set a default value in the method signature or we can use overloading.
 *   
 * 10 What is an interface and how is it different from an abstract class?
 *    interface: provide a blueprint for subclasses to follow, only include abstract methods with no implementations.
 *    abstract class: have at least one abstract method, can also have non-abstract methods. 
 *    A class can implement many interfaces but only inherit from one superclass.
 *    
 * 11 What accessibility level are members of an interface by default?
 *    By default, all members of an interface are public, and developers cannot change the access modifiers. 
 *    
 *    
 * True / False
 * 12 - 15 TTFF
 * 16 - 20 TTTTF
 * 20 - 24 FTFT
 */

/* Coding questions:
 * a. Person class
 * b. Instructor class
 * c. Student class, Course class
 */
