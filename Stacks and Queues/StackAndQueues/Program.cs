//creating stack
using Nito.Collections;
using StackAndQueues;

Stack<int> stack = new Stack<int>();

stack.Push(0); //adding 0 to the stack. So this will be the last element if removed
stack.Push(1);
stack.Push(2);
stack.Push(3); //this will be first element if removed

Console.WriteLine(stack.Pop());

//Creating Queue
Queue<int> q = new Queue<int>();

q.Enqueue(1); //adding 1 to the queue, this will be the first one if removed
q.Enqueue(2);
q.Enqueue(3);
q.Enqueue(4); //this will be the last one if removed

Console.WriteLine(q.Dequeue());

//creating a deque which will 

Deque<int> deque = new Deque<int>();
deque.AddToFront(1);
deque.AddToFront(2);

deque.AddToBack(3);


CustomStackImplemention customStack = new CustomStackImplemention(5);

customStack.push(0); //adding 0 to the customStack. So this will be the last element if removed
customStack.push(1);
customStack.push(2);
customStack.push(3);
customStack.push(4);
customStack.push(4);

Console.WriteLine(customStack.peek());
Console.WriteLine(customStack.pop());

DynamicCustomStackImplementation dynamicStack = new DynamicCustomStackImplementation(2);

dynamicStack.push(1);   
dynamicStack.push(2);
dynamicStack.push(3);