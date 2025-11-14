# PROG366 Portfolio
Ashani Li Peissigma
Last updated: 11/2/2025

## Big O Notation
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/tree/main/src/BigO)

Big O notation describes the complexity of an algorithm, independent of the hardware, software, or language it's running on.
**Time Complexity** (see [code](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/BigO/BigODemo.cs) for examples with explanations)
+ O(1) Constant Time: Performance is the same regardless of the size of the input data.
+ O(n) Linear Time: Performance grows linearly and in direct proportion to the size of the input data set. 
+ O(n^2) Quadratic Time: Performance is directly proportional to the square of the size of the input data set. Involves nested iterations of the data set. 

## The Fisher-Yates Shuffle
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/tree/main/src/Shuffle)

The Fisher-Yates algorithm generates a random, unbiased permutation of a sequence by randomly drawing an element from the sequence to shuffle until no elements remain. 
**Implementation**
 The algorithm is implemented in the "Deck" class on line 23 as Shuffle(). It shuffles a list of cards in place as many times as there are cards in the deck and returns the shuffled deck. It is called in the "Forecast" class in the Go() function using the unshuffled deck as a parameter. 

## Data Structures

### Linked Lists
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/DataStructures/LinkedListDemo.cs)

Linked lists are linear data structures that organize elements (nodes) in sequential order, with each element storing a reference to the next element. 
+ Linked lists are fast and flexible to use, but must be traversed linearly and use more storage in memory.
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
Arrays are linear, concrete data structures that store a sequence of elements of the same type.
+ Elements are indexed, and array indexes are 0-based.
+ Arrays are fixed size, and must be resized in order to add more elements. 
#### Maps
Maps are abstract data structures that implement an associative array which maps keys to values. 
+ More specifically, hashmaps involve a hashing function that generates unique keys to index elements.
+ Maps are non-sequential, and do not store elements in a particular order.
##### Open Addressing (Linear Map)
Open addressed maps have elements stored in the hash table itself, with one element per index. The map is probed in a linear sequence in order to insert, find, and delete elements.
##### Closed Addressing (Chaining Map)
Maps implementing the closed addressing method have buckets with linked lists to store elements. New elements with the same index are added to the end of the list. 

## Sorting Algorithms

[Demo](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/SortDemo.cs)\

#### Bubble Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/BubbleSort.cs)\
Description: An in-place sorting algorithm that iteratively swaps two adjacent values at a time, shrinking the unsorted portion (lower bound) of the set with each pass until the set is sorted. 
+ Best Case: O(n)
+ Worst Case: O(n^2)
```
BubbleSort(values[])
	
	Bool: notSorted = true
	
	WHILE (notSorted)
			
			//preemptively mark the set as sorted
				notSorted = false
			
			//iterate down the set
			FOR(i = n - 1 to 0)
			
				//compare adjacent values
					IF (values[i] < values[i - 1])
					
					//swap adjacent values
						temp = values[i];
						values[i] = values[i - 1];
						values[i - 1] = temp; 
					
					//since the set was found to be unsorted, mark it as unsorted
						notSorted = true; 
					
					//decrease the lower bound
						i--
					
					END IF
			END FOR
	END WHILE
END BubbleSort
```
  
#### Insertion Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/InsertionSort.cs)\
Description: An in-place sorting algorithm that builds the sorted portion (lower bound) of the set by sorting each element individually. Iteratively, the current index value is INSERTED into its correct position in the sorted portion (lower bound) before increasing the lower bound. 
+ Best Case: O(n)
+ Worst Case: O(n^2)
```
InsertionSort(values[])

    //start at position 1 
    FOR (i = 1 to n)

        //get current key's value and the index of it's adjacent value
        key = values[i]
        left = i
			
        //if the key is larger than the adjacent value, swap
        WHILE (values[left - 1] > key AND left > 0)
            values[left] = values[left - 1]
            left--
        END WHILE
			
        //insert key in correct position
        values[left] = key; 
		
    END FOR
END InsertionSort
```

#### Selection Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/SelectionSort.cs)\
Description: An in-place sorting algorithm that iteratively SELECTS the smallest value in the unsorted portion (upper bound) of the set and swaps it with the current index i before increasing the lower bound and iterating further. 
+ Best Case: O(n^2)
+ Worst Case: O(n^2)
```
SelectionSort(values[])
	FOR i = 0 to n - 1
	
        //find min value in the range of i...n-1
        minIndex = i //temp holding value
        FOR (j = i + 1 to n)
            IF (values[j] < values[minIndex])
                minIndex = j
            END IF
        END FOR
		
		//swap min with i
        temp = arr[i] 
        values[i] = values[min] 
        values[minIndex] = temp

    END FOR
END SelectionSort
```

#### Quick Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/QuickSort.cs)\
Description:
+ Best Case: 
+ Worst Case:

#### Merge Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/MergeSort.cs)\
Description:
+ Best Case: 
+ Worst Case:
