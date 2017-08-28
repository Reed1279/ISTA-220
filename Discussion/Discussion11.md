# Course: ISTA-220
## Lesson Plan: 11
### Name: Tyler Reed
#### Date: 26 August, 2017

1. What does an array look like in memory?

	-A memory address to the location in the heap that contains the array. 
1. Where is memory allocated to hold an array, on the stack or on the heap?

	-The heap.
1. Where is memory allocated to hold an array reference, on the stack or on the heap?

	-The stack.
1. Can an array hold values of different types? This is a trick question, the answer is, "It depends."

	-It depends,but no in C#
1. Describe the syntax of the condition or a foreach loop.

	-For Each followed by the varable name.
1. How do you make a deep copy of a array?

	-Copy(), CopyTo() or Clone().
1. What is the difference between a multi-dimensional array and an array of arrays?

	-An array of arrays has only a single dimension.
1. How do you "flatten" a multidimensional array? In other words, take something that looks like the matrix below and turn it into an array [1;2;3;4;5;6;7;8;9]?
	(1 2 3)
	(4 5 6)
	(7 8 9)

	-
	int{[]uri = new int [12];
	
	for(int i = 0; i < 4; i++)
	{
		for(j = 0; j < 3; j++)
			{uri[i * 4 + j] = Toni[_i, j]
	}