# PROG366 Portfolio
Ashani Li Peissigma
Last updated: 11/2/2025

## Big O Notation
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/tree/main/src/BigO)
Big O notation describes the complexity of an algorithm, independent of the hardware, software, or language it's running on.
**Time Complexity** (see [code](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/BigO/BigODemo.cs) for examples with explanations)
+ O(1) Constant Time: Performance is the same regardless of the size of the input data.
+ O(n) Linear Time: Performance grows linearly and in direct proportions to the size of the input data set. 
+ O(n^2) Quadratic Time: Performance is directly proportional to the square of the size of the input data set. Involves nested iterations of the data set. 

## The Fisher-Yates Shuffle
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/tree/main/src/Shuffle)
The Fisher-Yates algorithm generates a random, unbiased permutation of a sequence by randomly drawing an element from the sequence to shuffle until no elements remain. 
**Implementation**
 The algorithm is implemented in the "Deck" class on line 23 as Shuffle(). It shuffles a list of cards in place as many times as there are cards in the deck and returns the shuffled deck. It is called in the "Forecast" class in the Go() function using the unshuffled deck as a parameter. 

## Data Structures
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/tree/main/src/DataStructures)

### Linked Lists
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/DataStructures/LinkedListDemo.cs)
Linked lists are linear data structures that organize elements (nodes) in sequential order, with each element storing a reference to the next element. 
+ Linked lists are fast and flexible to use, but must be traversed linearly and use more sotrage in memory.
+ Traditional linked lists are traversed forwards, while doubly linked lists can be traversed forwards and backwards due to nodes having references to both the next and previous nodes.

### Stacks & Queues
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/DataStructures/StackQueue/QueueStackDemo.cs)
(Both implementations are built on top of the linked list implementation.)
#### Stacks
Stacks are data structures that store elements in a last-in, first-out (LIFO) order.
+ Elements are pushed (inserted) and popped (removed) from the front of the list.
#### Queues
Queues are data structures that store elements in a first-in, first-out (FIFO) order.  
+ Elements are enqueued (inserted) at the end of the list and popped (removed) from the front of the list.

### Arrays & Maps
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/DataStructures/Map/MapDemo.cs)
#### Arrays
Arrays are linear data structures that store a sequence of elements of the same type.
+ Elements are indexed, and array indexes are 0-based.
+ Arrays are fixed size, and must be resized in order to add more elements. 
#### Maps
Maps are an abstract data type that implement an associative array which maps keys to values. 
+ More specifically, hashmaps involve a hashing function that generates unique keys to index elements.
##### Open Addressing (Linear Map)
Open addressed maps have elements stored in the hash table itself, with one element per index. The map is probed in a linear sequence in order to insert, find, and delete elements.
##### Closed Addressing (Chaining Map)
Maps implementing the closed addressing method have buckets with linked lists to store elements. New elements with the same index are added to the end of the list. 