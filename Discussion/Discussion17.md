# Course: ISTA-220
## Lesson Plan: 17
### Name: Tyler Reed
#### Date: 04 September 2017

1. What is the difference between a managed resource and an unmanaged resource? 

	-Managed resources are controlled by the runtime and unmanaged are not
2. When is memory for an object (reference type) allocated? When is the memory deallocated? 

	-When the the object is initialized./When the references fall out of scope.
3. What is a destructor?

	-A method that is called after the memory deallocation.
 4. What is the difference in syntax between a constructor and a destructor?

	-The destructor uses a tilde and a class name vs. a modifier and paramaters with the name.
5. Give some examples of scarce resources. Why would you want to manage scarce resources?

	-File streams, network and database connections and memory./To increase performance
 6. What is exception-safe disposal? 

	-It is a process used to call the disposal in a finally block.
7. How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.

	-It introduces its own block and the object reference goes out of scope at the end of the using block,then it will release its resources./You can use it with minimal resources for something that needs to happen quickly.
 8. What ill effects could result from attempting to dispose of a resource more than once? 

	-It can cause major issues with you application.
9. We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management? A good guess is a sufficient answer to this question. 

	-Threads allow your system to comunicate with multiple lines of communication.  It's like having several phone conversations at once, but able to get all the information.
10. Why does the book recommend not attempting to force the garbage collector? Are there any exceptions to this recommendation?

	-Because you will not know if your objects have been destroyed./Yes
