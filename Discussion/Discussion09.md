# Course: ISTA-220
## Lesson Plan: 09
### Name: Tyler Reed
#### Date: 22 August, 2017

1. What is the difference between deep copy and shallow copy?

	-When an object being cloned contains fields that are reference types and the referenced types have a clone method this is considered a deep copy. If the referenced type does not have a clone method, then only the references are copied and this is considered a shallow copy.
1. What is the value of a reference after you declare and initialize it?

	-A memory address.
1. How do you declare a value type?

	-Provide the type and a variable name.
1. How do you declare a reference type?

	-Provide the type and a variable name.
1. Does C# allow you to assign NULL to a value type?

	-Depends
1. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?

	-No
1. What is the difference between the stack and the heap?

	-The stack is a organized allocation of memory for each parameter and local variable of a methods, created as the methods are called, where a heap is an unorganized assortment of memory allocations for new objects, each object has a reference to it contained in the stack.
1. What does it mean when we say that all classes are specialized types?

	-They all store data in a unique way.
1. What does ref do?

	-It references to the actual argument rather than a copy of an argument.
1. What does out do?

	-Creates an alias for the argument. 
1. Describe boxing and unboxing in your own words.

	-Boxing assigns a value from a value type to an object. Unboxing assigns the value from an object to a value type. 
1. What does cast do?

	-Checks whether converting an item of one type to another is safe before actually making the copy. 