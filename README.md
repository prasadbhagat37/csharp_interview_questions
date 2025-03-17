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

## x.. What is the use of the method "hiding" in inheritance?
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