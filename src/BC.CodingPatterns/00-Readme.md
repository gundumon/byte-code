# Two Pointers
A two-pointer pattern refers to an algorithm that utilizes two pointers. Two-pointer algorithms usually take only **O(n)** time by eliminating the need for nested for-loops. There are three main strategies for using two pointers.
1. **Inward Traversal**: in this approach, pointers start at opposite ends of the data structure and move inwards to each other
1. **Unidirectional Traversal**: in this approach, both pointers start at the same end of the data structure (usually the beginning) and move in the same direction
1. **Staged Traversal**: in this approach, we traverse with one pointer, and when it lands on an element that meets a certain condition, we traverse with the second pointer

## When To Use Two Pointers?
A two-pointer algorithm usually requires a linear data structure, such as an array or linked list. Otherwise, an indication that a problem can be solved using the two-pointer algorithm, is when the input follows a predictable dynamic, such as a sorted array

## Examples
1. [Pair Sum Sorted](./01-PairSumSorted.cs)
1. [Triplet Sum](./02-TripletSum.cs)
1. [Palindrome](./03-Palindrome.cs)
1. [Largest Container](./04-LargestContainer.cs)
1. [Shift Zero](./05-ShiftZero.cs)