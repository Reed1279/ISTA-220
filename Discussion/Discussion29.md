# Course: ISTA-220
## Lesson Plan: 29
### Name: Tyler Reed
#### Date: 26 September 2017

1. What is a delegate? Explain delegates in terms of pointers and reference types.

	-An object that refers to a method.
1. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.

	-Use the delegate keyword and specify the return type.
1. How do you create instances of delegates and assign values to the instance? What are the values?

	-Specify an access modifier, then specify the type (the delegate name), that is followed by a variable name, and include value assignment./ Methods without parenthesis or parameters. 
1. How do you invoke a method that has been added to a delegate?

	-You use the same syntax to invoke a delegate as you use to call a method..
1. What is an event? Why do we have events?

	-Events define significant actions./ We have events to run code automatically when something significant happens.
1. How do you declare events?

	-You must prefix the declaration with the event keyword.
1. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?

	-Operators./ Through += and -=
1. How do you raise an event? How do you declare code that raises an event?

	-You call it like a method./ Call them in sequence.
1. Explain with specificity what happens when an event fires and that event has been attached to a delegate.

	-The methods are called in sequence and subscribed methods must be unsubscribed individually.