# Course: ISTA-220
## Lesson Plan: 06
### Name: Tyler Reed
#### Date: 20 August, 2017

1. What is an exception? 

	-Signal that an error has occurred.
1. What happens in a try block if the program executes without errors? 

	-All of the statements in the try block run until completion.
1. How does the catch mechanism work for unhandled exceptions? 

	-If a try block throws an exception, there is no corresponding catch handler, and the try block is part of a method, the method immediately exits and execution returns to the calling method. If the calling method uses a try block, the runtime attempts to locate a matching catch handler for this try block and execute it. If the calling method does not use a try block or there is no matching catch handler, the calling method immediately exits and execution returns to its caller, where the process is repeated. If a matching catch handler is eventually found, the handler runs and execution continues with the first statement that follows the catch handler in the catching method.
1. What happens in a program if an exception block fails to handle a particular error? 

	-The program will terminate with an unhandled exception.
1. What is the parent class for all exceptions? How does this work? 

	-Exception is the parent class of all exceptions. In the catch Exception, the handler traps every possible exception that can occurs.
1. How do you determine the type of an error? 

	-By examining the details in the Message property of the thrown exception.
1. What is the purpose of integer checking? 

	-To prevent overflow.
1. What does the finally block do? 

	-A finally block always executes.