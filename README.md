# Implement Stack using Two Queues

This project was coded for a StackOverflow for questions. The goal of the project is to make the stack using 2 queues.

### Solution Ways
There are two ways to solve this I code version A on this project.
 Version A (efficient push):
   - push:
      enqueue in queue1

  - pop:
     while size of queue1 is bigger than 1, pipe dequeued items from queue1 into queue2
     dequeue and return the last item of queue1, then switch the names of queue1 and queue2

Version B (efficient pop):
  - push:
    enqueue in queue2
    enqueue all items of queue1 in queue2, then switch the names of queue1 and queue2
  - pop:
    deqeue from queue1

Problem Source: http://stackoverflow.com/questions/688276/implement-stack-using-two-queues