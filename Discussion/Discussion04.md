# Course: ISTA-220
## Lesson Plan: 04
### Name: Tyler Reed
#### Date: 20 August, 2017

1. What are all possible values of a Boolean expression? 

	-true or false.
1. List eight Boolean operators. 

	-==, !=, &&, ||, <, <=, > and >=.
1. What are the difference in how short circuiting works for && and ||? 

	-For &&, if it is false, the right operand isn’t evaluated. For ||, if the left operand is true, the right operand isn’t evaluated. For both, it is best practice to put the most likely case as the left operand to boost performance.
1. Look at the list of operators. What operator has the highest precedence? Which has the lowest? 

	-(parenthesis) has the highest precedence and assignment (=) has the lowest.
1. In an if or else construction using multiple lines of code, what effect does the use of curly braces have? 

	-A block is simply a sequence of statements grouped between an opening brace and a closing brace. 
1. In a switch statement, what happens if you omit break? 

	-If any code exists without a break statement, it will fail to compile. 