using System;
using System.Collections.Generic;
using System.IO;

namespace LeetCode_CircularQueue
{
    public class MyCircularQueue

    {
        private int SIZE ;
        private int[] data ;
        public int FRONT ;
        public int REAR ;
        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            SIZE = k;
            data = new int[k];
            FRONT = -1;
            REAR = -1;

        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull() == true)
            {
                return false;
            }
            if (IsEmpty() == true) 
            {
                FRONT = 0;
            }
            REAR = (REAR + 1) % SIZE;
            data[REAR] = value;
            return true;
        }


        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty() == true) 
            {
                return false;
            
            }

            if (FRONT == REAR) 
            {
                FRONT = -1;
                REAR = -1;
                return true;
            }

            FRONT= (FRONT+ 1) % SIZE;
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (IsEmpty()==true)
            {

                return -1;
            }
            return data[FRONT];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (IsEmpty() == true)
            {

                return -1;
            }
            return data[REAR];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return FRONT == -1;

        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return (REAR + 1) % SIZE == FRONT;
        }
    }
}



