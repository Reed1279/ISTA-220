# Course: ISTA-220
## Lesson Plan: 26
### Name: Tyler Reed
#### Date: 25 September 2017

1. What is an enumerable collection?

	-Implements the System.Collections.IEnumerable interface.
1. What properties and methods does the IEnumerable interface contain?

	-Method called GetEnumerator.
1. What properties and methods does the IEnumerator interface contain?

	-object Current { get; } bool MoveNext(); void Reset();
1. What values does the MoveNext() method return? What does it do?

	-Returns true or false./Moves the pointer down to the next item in the list.
1. What values does the Reset() method return? What does it do?

	-None./Returns the pointer before the first item in the list.
1. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?

	-No, but depends./It returns an object rather than a specific type.
1. Why don't recursive methods retain state when used with data structures like binary trees?

	-The data within the recursive call is lost when they lose scope.
1. How do you define an enumerator?

	-By defining a class that implements the IEnumerator<T>
1. What is an iterator?

	-Code that yields an ordered sequence of values. 
1. What does yield do?

	-Indicates the value that should be returned by each iteration.