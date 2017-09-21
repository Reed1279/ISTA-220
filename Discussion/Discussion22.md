# Course: ISTA-220
## Lesson Plan: 22
### Name: Tyler Reed
#### Date: 12 September 2017

1. What is a type parameter?

	-A generic type that can be used in place of a real type.
1. What does a type parameter do?

	-Acts as a placeholder.
1. How many type parameters can a generic class have?

	-There is no limit
1. What is the difference between a generic class and a generalized class?

	-A generic class has its type parameters converted to real types and a generalized class can hold any object, so the data being used can be cast to the correct type anytime the programmer.
1. What is a constraint? How do you specify a constraint?

	-Limit the type parameters of a generic class to those that implement a particular set of interfaces and provides the methods defined by those interfaces./public class EdibleCollection<T> where T : IEdible.
1. What is a generic method? How do you define a generic method?

	-A generic method specifies the types of the parameters and the return type by using a type parameter in a manner similar to that used when you define a generic class./By using the same type parameter syntax you use when you create generic classes.
1. What do we mean when we say that a generic type interface is invariant?

	-You cannot assign an IWrapper<A> object to a reference of type IWrapper.
1. What do we mean when we say that a generic type interface is covariant?

	-You can inform the compiler that some implicit conversions are legal and that it does not have to enforce strict type safety. 
1. Does covariance work with value types? Does it work with reference types?

	-No./Yes.
1. What do we mean when we say that a generic type interface is contravariant?

	-Enables you to use a generic interface to reference an object of type B through a reference to type A as long as type B derives from type A.
