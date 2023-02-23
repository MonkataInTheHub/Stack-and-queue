// See https://aka.ms/new-console-template for more information
using Stack_and_queue.Models;

Console.WriteLine("Hello, World!");
var aQueue = new ArrayQueue<int>(15);
var lQueue = new ArrayQueue<int>(15);
var lStack = new ArrayStack<int>(15);
var aStack = new ArrayStack<int>(15);
aStack.Push(1);
aStack.Pop();
lStack.Push(1);
lStack.Pop();
aQueue.Enqueue(1);
aQueue.Dequeue();
lQueue.Enqueue(1);
lQueue.Dequeue();
