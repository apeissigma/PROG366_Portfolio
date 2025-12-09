# PROG366 Portfolio
Ashani Li Peissigma
Last updated: 12//2025

## Contents
1. [Big O Notation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/README.md#big-o-notation)
2. [The Fisher-Yates Shuffle](https://github.com/apeissigma/PROG366_Portfolio/blob/main/README.md#the-fisher-yates-shuffle)
3. [Data Structures](https://github.com/apeissigma/PROG366_Portfolio/blob/main/README.md#data-structures)
4. [Sorting Algorithms](https://github.com/apeissigma/PROG366_Portfolio/blob/main/README.md#sorting-algorithms)
5. [Searching Algorithms](https://github.com/apeissigma/PROG366_Portfolio/blob/main/README.md#searching-algorithms)
6. [Trees]()

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

### Arrays & Maps
[Arrays & Maps Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/DataStructures/Map/MapVsArrayDemo.cs)
[Linear & Chaining Map Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/DataStructures/Map/MapDemo.cs)

#### Arrays
Arrays are linear, concrete data structures that store a sequence of elements of the same type.
+ Elements are indexed, and array indexes are 0-based.
+ Arrays are fixed size, and must be resized in order to add more elements.
  
Choose an array over a map when...
+ Associated values aren't necessary
+ Storing ordered, index-based data
+ Needing to prioritize memory efficiency
#### Maps
Maps are abstract data structures that implement an associative array which maps keys to values. 
+ More specifically, hashmaps involve a hashing function that generates unique keys to index elements.
+ Maps are non-sequential, and do not store elements in a particular order.
  
C# has two built in map types, both with the same functionality:
+ Hashtable: a non-generic collection of key/value pairs that returns object types.
+ Dictionary: a generic collection of key/value pairs with better performance than hashtables.
  
Choose a map over an array when...
+ Implementing complex keys such as hashes
+ Needing to access an element by its key rather than its index
+ Storing irregular or non-sequential data

##### Open Addressing (Linear Map)
Open addressed maps have elements stored in the hash table itself, with one element per index. The map is probed in a linear sequence in order to insert, find, and delete elements.
##### Closed Addressing (Chaining Map)
Maps implementing the closed addressing method have buckets with linked lists to store elements. New elements with the same index are added to the end of the list. 

### Stacks & Queues
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/DataStructures/StackQueue/QueueStackDemo.cs)

(Both implementations are built on top of the linked list implementation.)
#### Stacks
Stacks are data structures that store elements in a last-in, first-out (LIFO) order.
+ Elements are pushed (inserted) and popped (removed) from the front of the list.
  
Choose a queue over a stack when...
+ Processing data in reverse order, like executing undo operations
+ Managing context
#### Queues
Queues are data structures that store elements in a first-in, first-out (FIFO) order.  
+ Elements are enqueued (inserted) at the end of the list and popped (removed) from the front of the list.
  
Choose a queue over a stack when...
+ Handling data in the order it arrives, like messages or print jobs
+ Preserving sequences

## Sorting Algorithms

[Demo](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/SortDemo.cs)

### Bubble Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/BubbleSort.cs)

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
  
### Insertion Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/InsertionSort.cs)

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
        values[left] = key
		
    END FOR
END InsertionSort
```

### Selection Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/SelectionSort.cs)

Description: An in-place sorting algorithm that iteratively SELECTS the smallest value in the unsorted portion (upper bound) of the set and swaps it with the current index i before increasing the lower bound and iterating further. 
+ Best Case: O(n^2)
+ Worst Case: O(n^2)
```
SelectionSort(values[])

	//find minimum value in the range of i...n-1 and swap
	FOR i = 0 to n - 1
	
		//compare and set the minimum value's index
        minIndex = i 
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

### Quick Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/QuickSort.cs)

Description: A sort-in-place, divide-and-conquer approach where a value is chosen as a pivot, which partitions the set into two subsets (low values and high values relative to the pivot). The subarrays are partitioned and sorted recursively in relation to the pivot until the set is sorted.
+ Best Case: O(n log(n))
+ Worst Case: O(n^2)
```
Quicksort(values[], low, high)

	//partition the input set, 
	//then partition and sort each subset recursively 
	IF (low < high)
		pivot = Partition(values[], low, high)
		QuickSort(values[], low, pivot)
		Quicksort(value[], pivot + 1, high)
	END IF
END QuickSort

Partition(values[], low, high)

	//choose the last value as the partition
	pivot = A[high]
	smallIndex = low - 1

	//iteratively swap elements in the subset
	FOR i = low to high - 1
		IF (values[i] < pivot)
			smallIndex++
			Swap(values[], smallIndex, i)
		END IF
	END FOR
	
	//swap pivot and return the pivot's new position
	Swap(values[], smallIndex + 1, high)
	return smallIndex + 1
	
END Partition
	
Swap(values[], low, high)
	temp = values[low]
	values[low] = values[high]
	values[high] = temp
END Swap
```

### Merge Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/MergeSort.cs)

Description: Using the divide and conquer strategy, the algorithm splits the set into two equally-sized subsets, recursively sorts them, and merges the sorted subsets together. 
+ Best Case: O(n log(n))
+ Worst Case: O(n log(n))
```
MergeSort(values[], left, right)
    if (left < right)
    {
		    //get middle index value to split the set
        mid = (left + right) / 2
        
        //sort left and right subsets recursively
        MergeSort(values[], left, mid)
        MergeSort(values[], mid + 1, right)
        
        //merge the sorted subsets back together
        Merge(values[], left, mid, right)
    }
END MergeSort

Merge(values[], left, mid, right)
		
    //create a temporary set for the subset
    new temp[]
    leftIndex = left
    rightIndex = mid + 1
    tempIndex = 0

    //compare and merge values from both halves
    WHILE (leftIndex <= mid AND rightIndex <= right)
        IF (values[leftIndex] <= values[rightIndex]) 
	        temp[tempIndex++] = values[leftIndex++];
	      END IF
        ELSE 
	        temp[tempIndex++] = values[rightIndex++];
	      END ELSE
    END WHILE

    //copy remaining values from left half
    WHILE (leftIndex <= mid)
        temp[tempIndex++] = values[leftIndex++];
    END WHILE

    //copy remaining values from right half
    WHILE (rightIndex <= right)
        temp[tempIndex++] = values[rightIndex++];
    END WHILE

    //copy merged values from temp set back to original set
    FOR (leftIndex = left, tempIndex = 0; leftIndex <= right; leftIndex++, tempIndex++)
        values[leftIndex] = temp[tempIndex];
    END FOR
	  
END Merge

```

### Heap Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Sort/Algorithms/HeapSort.cs)

Description: A sort-in-place algorithm that uses a heap data structure to sort the input set. It builds a heap before swapping the first and last items in the heap, rebuilding the heap excluding the last item and adding it to the end of the sorted set. 
+ Best Case: O(n log(n))
+ Worst Case: O(n log(n))
```
Heapsort(array arr)

    //build initial unsorted heap
	BuildMaxHeap(arr)

		//sort 
		FOR i = n - 1 to 0
			Swap(0, i)
			 Heapify(heap, 0, i)
			i--
		END FOR
	END BuildMaxHeap
END HeapSort

//builds the initial heap
BuildMaxHeap(array arr)

	//heapify from last non-leaf node to root
	FOR i = n/2 - 1 to 0
		Heapify(arr, i, n)
		i--
	END FOR
END BuildMaxHeap

//maintains heap structure
Heapify(array arr, int i, int n)
	left = 2i + 1
	right = 2i + 2
	max = val
	
	//if left node is larger than maximum node, set new max
	IF (left < n) AND (arr[left] > arr[max])
		max = left
	END IF

	//if right node is larger than maximum node, set new max
	IF (right < n) AND (arr[right) > arr[max])
		max = right
	END IF
	
	//if the value is no longer the largest max, swap and re-heapify
	IF (max != i)
		swap(i, max)
		Heapify(arr, max, n)
	END IF
END Heapify
```

## Searching Algorithms

### Linear Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Search/Algorithms/LinearSearch.cs)

Description: A simple searching algorithm that sequentially checks each value of a dataset. Works best on very small datasets. 
+ Best Case: O(1)
+ Worst Case: O(n)
```
LinearSearch(array, target)
	FOR i = 0 to n
		IF array[i] = target, return i
	END FOR
    return -1
END LinearSearch
```

### Binary Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Search/Algorithms/BinarySearch.cs)

Description: Requiring a sorted dataset, the algorithm compares the value in the middle of the dataset to the target value. If the values are equal, the target has been found, otherwise the algorithm splits the dataset and recursively searches with the remaining half containing the target.
+ Best Case: O(1)
+ Worst Case: O(log n)
```
BinarySearch(array, low, high, target)
 
 WHILE (low <= high)
 
	 mid = (high + low) / 2
	 
	 IF (array[mid] == target), return mid
	 IF ELSE (array[mid] < target), return BinarySearch(array, mid + 1, high, target)
	 ELSE return BinarySearch(array, low, mid - 1, target)
	 
 END WHILE
 
	 return -1

END BinarySearch
```

### Interpolation Sort
[Implementation](https://github.com/apeissigma/PROG366_Portfolio/blob/main/src/Search/Algorithms/InterpolationSearch.cs)

Description: An improvement over Binary Search for sorted datasets with uniformly distributed values. Calculates a key/probe based on the upper and lower bounds of the dataset, adjusting the searchable area of the dataset and recalculating the probe until the value is found. 
The formula to calculate the probe is as followed, where "x" is the target: $$lo + [ (hi - lo) * (x - arr[lo]) / (arr[hi] - arr[lo]) ]$$
+ Best Case: O (log (log (n))
+ Worst Case: O(n)
```
InterpolationSearch(array, target)
	high = n - 1
	low = 0
	
	WHILE (target >= array[low] && target <= array[high] && low <= high)
		
		prob = low + ((high - low) * (target - array[low]) / (array[high] - array[low]))
		
		IF (array[probe] = target, return probe
		IF (array[probe] < target, low = probe + 1
		ELSE high = probe + 1
		
	END WHILE
	
	return -1

END InterpolationSearch
```
