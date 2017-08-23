# Course: ISTA-220
## Lesson Plan: 05
### Name: Tyler Reed
#### Date: 20 August, 2017

1. What is a compound assignment operator? How does it work? 

	-A shorthand way to perform arithmetic where the result is stored in one of the operands. For example, instead of a = a + b; you write a += b;. It works with all the arithmetic operators and in all cases the arithmetic operator precedes the assignment operator.
1. List all the compound assignment operators. 

	-+=, -=, *=, /=, and %=.
1. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50. 

	-var = var + 5; and var += 5;/ var = var – 50; and var -= 50;.
1. How long does a while loop run? 

	-A while loop will run as long as the given condition is true.
1. What happens if you don't change the loop variable in the body of the while loop block? 

	-You will end up with an infinite loop.
1. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them? 

	-Three parts: initialization, Boolean statement, and code that updates the control variable. You can omit any or all of the parts. If you omit the Boolean statement, it defaults to true and creates an infinite loop. If you omit the initialization and update parts, it acts like a while loop. If you omit all three, you create an infinite loop.
1. How do you guarantee that a loop runs at least once? 

	-Use a do-while loop.
1. What does the break statement do? 

	-Exits the loop immediately and execution continues at the first statement that follows the loop.
1. What does the continue statement do? 

	-Causes the program to perform the next iteration of the loop immediately (after reevaluating the Boolean expression). Basically, it skips the rest of the code in the loop (for that iteration).