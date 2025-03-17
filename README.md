# C# Interview Questions & Answers

## 1. What is Object-Oriented Programming (OOP)?
Object-Oriented Programming (OOP) is a programming paradigm that uses objects and classes to design and develop applications.

The key principles of OOP are **(A-Pie)**:
  1. **Abstraction**: Hiding the complex implementation details and showing only the necessary features of an object.
  2. **Polymorphism**: Allows entities (like variables, functions, or objects) to have multiple forms, enabling them to behave differently based on the context or the type of object involved. 
  3. **Inheritance**: A mechanism where a new class (derived/child class) inherits properties(variables) and behavior (methods/functions) from an existing class (base/parent class).
  4. **Encapsulation**: Bundling the data (attributes) and methods (functions) that operate on the data into a single unit or class, and restricting access to some of the object's components.

## 2. Advantages of OOP's

  1. **Modularity**: OOP promotes a modular approach to programming, breaking down complex systems into smaller, manageable objects, making code easier to understand, maintain, and modify. 
  2. **Code Reusability**: OOP allows developers to create reusable components (classes and objects) that can be used in different parts of the code or even across different projects, saving time and effort. 
  3. **Encapsulation**:OOP's encapsulation feature hides internal implementation details and offers clearly defined interfaces for dealing with objects, further improving manageability and security. 
  4. **Inheritance**:Inheritance allows developers to create new classes (subclasses) based on existing ones (superclasses), inheriting their properties and behaviors, promoting code reuse and a hierarchical structure. 
  5. **Code Maintenance**:OOP's modular and organized structure simplifies code maintenance and upgrades, as individual modules can be modified without affecting the entire system. 
  6. **Better Problem-Solving**:OOP encourages developers to think in terms of real-world objects and relationships, leading to more intuitive and organized code design, which aids in better problem-solving. 
  7. **Improved Software Development Productivity**:By promoting code reusability, modularity, and easier maintenance, OOP significantly increases software development productivity. 
  8. **Scalability**:OOP supports scalability by allowing developers to add new objects and classes as the system grows, making it easier to accommodate changes and enhancements in the software. 
  9. **Security**:OOP's encapsulation and access control mechanisms enhance security by hiding internal implementation details and preventing unauthorized access to data. 
  10. **Extensibility**:OOP makes code more extensible, allowing developers to add new features and functionalities to the application without compromising or altering the existing code. 
  11. **Faster Development**:OOP's features, such as code reusability and modularity, enable faster development cycles and reduced development costs. 

## 3. Limitations of OOP's

## 4. What is Class?
A class is **blueprint** or template. It contains fields, methods and properties

  Class members:
  1.  **Constructor** : is a method in the class which gets executed when a class object is created.
  2.  **Field**: is a variable of any type. It is basically a data.
  3.  **Property**: is member that provides helps inn read and write of private field.
  4.  **Method**: is code block that contains a series of statements.

## 5. What is Object?
An object is instance of class.

## x. What are the distinctions between Array and Array List in C#?
Arrays store values or elements of the same data type, whereas array lists store values of various data types.

Arrays will use a fixed length, whereas array lists will not.

## x. In C#, What are partial classes?
Partially implemented classes distribute the functionality of a single class across multiple files. During the compilation process, these multiple files are combined into one. The partial keyword is used to create the partial class.

public partial Class_name{
 // code
}

Methods, interfaces, and structures' functionalities can be easily separated into multiple files. You can also include nested partial classes.

## x. What is the use of the method "hiding" in inheritance?
Method hiding or Method shadowing is used to hide the implementation of the base class method under the shadow of the child class method, with the help of a **new** keyword.

This is done to clear the ambiguity when the child class has a method with the same name as that of the base class and hence helps in abstraction.

// C# program to illustrate the
// concept of method hiding
using System;
// Base Class
public class Parent {
public void member()
{
 Console.WriteLine("Parent method");
}
}
// Derived Class
public class Child : Parent {
// Reimplement the method of the base class
// Using new keyword
// It hides the method of the base class
public new void member()
{
 Console.WriteLine("Child method");
}
}
// Driver Class
class DriverClass {
// Main method
static public void Main()
{
 // Creating the object of the derived class
 Child obj = new Child();
 // Access the method of derived class
 obj.member();
}
}

## x. What is Serialization in C#?
When we want to store any object to a memory, a database, or a file, it needs a special process known as Serialization. 

Serialization is the process of converting an object into a different form to store it on to a file, database, or memory. The purpose of Serialization is to transfer the object and its state across the network and recreate it successfully when needed.

The reverse of Serialization is known as Deserialization.


There are many types of serialization in C#, such as:

  1.  Binary serialization: To save the state of the object in binary format.  This is done using classes defined in the System.Runtime.Serialization namespace.
  2. Soap Serialization: To save the state of the object in binary format, with the use of network-related communication.
  3. XML Serialization: To save the state of the object in XML format. This is done using classes defined in the System.Xml.Serialization namespace.
  4. JSON Serialization: To save the state of the object in JSON format.  This is done using classes defined in the System.Text.Json namespace.
There are some third-party serialization formats as well that are supported in C#, such as MessagePack (msgpack).

## x. How many types of constructors can a class have?
Like functions, a class can have any number of constructors. But unlike functions, all the constructors will have the same name, the name of the class, but different parameter signatures. In other words, you can create as many valid overloads of a constructor, as you want.

## x. What is a namespace?
Namespace is a container in which you can define classes, methods, interfaces, structures, or other child namespaces, such that classes with the same name but different namespaces won’t cause any error. In C#, namespaces are an efficient entity to organize codes for larger applications.

The major advantages of Namespace are:

1. Namespaces help in effectively organizing large C# code projects.
2. To use any entity in a namespace, simply use <namespace name>.<entity name>
3. No two classes with the same name in a different namespace will cause any error.

## x. What is the difference between ref and out keywords?
When an argument is passed as a ref, it must be initialized before it can be passed to the method. An out parameter, on the other hand, need not to be initialized before passing to a method.

## X. What is the benefit of ‘using’ statement in C#?
The ‘using’ statement can be used in order to obtain a resource for processing before automatically disposing it when execution is completed.

## X. What is meant by Unmanaged or Managed Code?
In simple terms, managed code is code that is executed by the CLR (Common Language Runtime). This means that every application code is totally dependent on the .NET platform and is regarded as overseen in light of it. Code executed by a runtime programme that is not part of the .NET platform is considered unmanaged code. Memory, security, and other activities related to execution will be handled by the application's runtime.

## x. What is the difference between read-only and constants?
During the time of compilation, constant variables are declared as well as initialized. It’s not possible to change this particular value later. On the other hand, read-only is used after a value is assigned at run time.

## X. What are reference types and value types?
A value type holds a data value inside its memory space. Reference type, on the other hand, keeps the object’s address where the value is stored. It is, essentially, a pointer to a different memory location.

## X. What are sealed classes in C#?
When a restriction needs to be placed on the class that needs to be inherited, sealed classes are created. 
Compile-time error occurs when a sealed class is forcefully specified as a base class.

## X. Is it possible for a private virtual method to be overridden?
A private virtual method cannot be overridden as it can’t be accessed outside the class.

## X. What are the differences between System.String and System.Text.StringBuilder classes?
System.String is absolute. When a string variable’s value is modified, a new memory is assigned to the new value. The previous memory allocation gets released. 
System.StringBuilder, on the other hand, is designed so it can have a mutable string in which a plethora of operations can be performed without the need for allocation of a separate memory location for the string that has been modified.

Difference Between Abstract Class and Interface |
| Points | Abstract Class | Interface |

| Definition | Cannot be instantiated; contains both abstract (without implementation) and concrete methods (with implementation) | Specifies a set of methods a class must implement; methods are abstract by default. |

| Implementation Method | Can have both implemented and abstract methods. | Methods are abstract by default; Java 8, can have default and static methods. |

| Inheritance | class can inherit from only one abstract class. | A class can implement multiple interfaces. |

| Access Modifiers | Methods and properties can have any access modifier (public, protected, private). | Methods and properties are implicitly public. |

| Variables | Can have member variables (final, non-final, static, non-static). | Variables are implicitly public, static, and final (constants). |