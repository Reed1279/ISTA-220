# Course: ISTA-220
## Lesson Plan: 10
### Name: Tyler Reed
#### Date: 23 August, 2017

1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, PFC, Corporal, or 1stLt, 2ndLt, Capt? 

	-enum OfficerRanks
	{
		2LT, 1LT, CPT, MAJ, LTC, 
		COL, BG, MG, LTG, GEN, GOA
	}
1. Using the Ranks enum, assign a rank to yourself or a friend.

	-Enlisted Tyler = Enlisted.SFC;
1. Determine the numeric index of particular ranks, using the Ranks enum.

	-For me, it would be seven had I used the Enlisted Ranks.
1. How do you select the type of an enum?

	-enum OfficerRanks : short { 2LT, ... GOA}
1. Are structs stored on the stack or on the heap? What about enums?

	-Structs and enums are both stored on the stack.
1. Declare a struct named DOD with four branches. 

	-struct DoD
	{
		private string army, savy, chairforce, coastguardians;   {:^ )
	}
1. Why can't you create a default constructor for a struct?

	-The compiler always generates one.
1. What is CIL? What does the CLR do to the CIL?

	-Common Intermediate Language (CIL). The CLR converts the CIL computer language.