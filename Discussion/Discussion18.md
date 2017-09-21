# Course: ISTA-220
## Lesson Plan: 18
### Name: Tyler Reed
#### Date: 07 September 2017

1. What is the difference between a property and a field?  

	-A property is protected against direct access.
1. What is the difference between a property and a method?  

	-A method can modify the fields.
1. What is your understanding of encapsulation?  

	-It is used to maintain privacy of data.
1. Some languages are case insensitive, that is, an "a" and an "A" are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identifiers? Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?  

	-Readability and maintenance./Yes
1. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write-only property.  

	-A bank balance. Allowing someone the ability to change the bank acount password.
1. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.  

	-Yes, for any time that you want to specify a read and write only.  Due to application security, I can not think of a reason why you would not want a method to be public.  The more private restraints you push within an application, the more secure.   
1. What are restrictions on the use of properties?  

	-a value can be assingned through a property of a structure or class after the structure or class has been initialized.
	
	-you can not use a property as a reference or an out argument to a method.
	
	-a property can contain one get accessor and one set accessor. It cannot contain other methods, fields, or properties.
	
	-the get and set accessors cannot take any parameters. 
	
	-you can not declare properties by using constructors.	
1. What is an object initializer? What is the syntax for an object initializer?  

	-"new", followed by the class constructor./MyPhone = new MyPhone();