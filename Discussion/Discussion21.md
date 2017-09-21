# Course: ISTA-220
## Lesson Plan: 21
### Name: Tyler Reed
#### Date: 11 September 2017

1. Give five examples (using valid C# code) of the five bitwise operators listed in the text. 

	-int x = ~10;
	
	-int x = 10 <<4;
	
	-int x = 10 | 4;
	
	-int x = 10 & 4;
	
	-int x = 10 ^ 4;
	  
	  GOOD BUDDY :)
1. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid C# code.

	-Yes./int x = 10 >> 4;.
1. Explain in detail this code: bits & (1 << index);.

	-(1 << index) will return a value binary equivalent of 1. & is comparing the binary value of the variable bits to the binary value of (1 << index). 
1. Explain in detail this code: bits |= (1 << index);.

	-The assignment operator compares the value in the binary value of the variable bits to the binary value of (1 << index) and returns a value that has 1 in all the binary positions. 
1. Explain in detail this code: bits &= (1 << index);.

	-Same code as before with the exception of the  compound assignment operator.
1. How does C# interpret this: bool peek = bits[n];?

	-Calls to the get accessor for bits and the index argument is set to the value of n. 
1. How does C# interpret this: bits[n] = true;?

	-Calls to the set accessor for bits where the index is the value of n and sets the value to true (1).
1. How does C# interpret this: bits[n] ^= true;?

	-Calls the get/set accessor for bits where the index is the value of n. 
1. Assume that users were assigned read, write, and execute permissions according to this scheme: read = 1, write = 2, execute = 4. How would you interpret the following user permissions:
(a) permission = 0

	-No permissions.
(b) permission = 1

	-Read.
(c) permission = 2

	-Write.
(d) permission = 3

	-Read and Write.
(e) permission = 4

	-Execute.
(f) permission = 5

	-Read and Execute.
(g) permission = 6

	-Write and Execute. 
(h) permission = 7

	-Read, Write, and Execute.
1. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this scheme of permissions?

	-It was written with integer indexing as an array of Boolean values.
A. permission = 0

	-No permissions/000.
B. permission = 1

	-Read/001.
C. permission = 2

	-Write/010.
D. permission = 3

	-Read and Write/011.
E. permission = 4

	-Execute/100.
F. permission = 5

	-Read and Execute/101.
G. permission = 6

	-Write and Execute/110.
H. permission = 7

	-Read, Write, and Execute/111.