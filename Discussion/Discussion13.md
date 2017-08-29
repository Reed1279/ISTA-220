# Course: ISTA-220
## Lesson Plan: 13
### Name: Tyler Reed
#### Date: 28 August, 2017

1. How do you define a method that takes an arbitrary number of arguments?

	-public static int Example(params int[] paramList).
1. How do you call a method that takes an arbitrary number of arguments?

	-Example(1,2,3,4,5)
1. Why can't you use an array to pass an arbitrary number of arguments to a method?

	-The compiler just counts the number of arguments, creates an array of that size, fills the array with the arguments, and then calls the method by passing the single array parameter.
1. How many parameters can a method have?

	-Many
1. Do parameter arguments have to have the same type?

	-Yes
1. What is the difference between a method that takes a parameter argument and one that takes optional arguments?

	-Has a fixed parameter list, and you cannot pass an arbitrary list of arguments. 
1. How do you define a method that takes different (and arbitrary) types of arguments?

	-public static void Example(params object[] paramList)