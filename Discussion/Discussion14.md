# Course: ISTA-220
## Lesson Plan: 14
### Name: Tyler Reed
#### Date: 29 August, 2017

1. How does inheritance promote the principle of don't repeat yourself (DRY)?

	-Inheritance enables derived classes to use the methods and fields defined in the base class. Once you write the common methods and fields in the base class, you don't repeat yourself for each of the derived classes.
1. What is the syntax of a derived class that inherits from a base class?

	-Class Corvette : Car
1. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?

	-Yes, All classes inherit from System.Object. 
1. What happens if you do not have a default constructor in a base class when creating a derived class?

	-Generates a default constructor for you. 
1. Can you assign a variable of a derived class to another variable of its base class? Why or why not?

	-Yes
1. Can you assign a variable of a derived class to another variable of a derived class of its base class? Why or why not?

	-No
1. Can you assign a variable of a base class to another variable of a derived class? Why or why not?

	-Yes, but it limits your functionality.
1. Under what circumstances would you want to use the new keyword when defining a method in a derived class?

	-To ensure the two methods have the same signature.
1. What is a virtual method? Why would you want to define a virtual method?

	-A method that is intended to be overridden.
1. What does override do? Why does it do it?

	-It does it to allow class specific implementations of a common task. 
1. How do you define an extension type?

	-You write a mthod inside a static class 
1. Why do you define an extension type?

	-You can extend an existing type with additional static methods. 