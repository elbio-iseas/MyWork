
def bubbleSort(arr):

    l = len(arr)

    for i in range(l-1):

        for j in range(l-i-1):

            if arr[j] > arr[j+1]:

                arr[j], arr[j+1] = arr[j+1], arr[j]


arr = [25, 3, 19, 38, 1, 78, 21, 95, 34, 15, 48]

bubbleSort(arr)

print("After sorting array with bubblesort.")

print(arr)


def selectionSort(array, size):

	for ind in range(size):

		min_index = ind

		for j in range(ind + 1, size):

			if array[j] < array[min_index]:

				min_index = j

		(array[ind], array[min_index]) = (array[min_index], array[ind])


arr1 = [48, 15, 34, 95, 21, 78, 1, 38, 19, 3, 25]

size = len(arr1)

selectionSort(arr1, size)

print("After sorting array with selectionsort.")

print(arr1)


def insertionSort(arr):

	for i in range(1, len(arr)):

		key = arr[i]

		j = i-1

		while j >=0 and key < arr[j] :

				arr[j+1] = arr[j]

				j -= 1

		arr[j+1] = key


arr2 = [98, 24, 51, 76, 2, 33, 17, 5, 22, 49]

insertionSort(arr2)

print("After sorting array with insertionsort.")

print(arr2)

# This code is contributed by Mohit Kumra
