Advantages of the array implementation:
Random access: Arrays allow for constant-time access to any element by index, which is not possible in linked lists.
Memory efficiency: Arrays use a contiguous block of memory, so they are more memory-efficient than linked lists, which require extra memory for each node.
Disadvantages of the array implementation:
Fixed capacity: Arrays have a fixed capacity that is set when the array is created. If the number of elements exceeds this capacity, a new, larger array must be created and the existing elements must be copied over.
Costly resizing: Resizing an array can be a costly operation in terms of time and memory. If the array needs to be resized frequently, this can negatively impact performance.
Note: The array resizing may be done with Array.Resize() method but this way better emphasizes the advantages and disadvantages of both approaches.
