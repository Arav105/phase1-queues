using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1_queues
{
    public class Queues
    {

        private int[] ele;
        private int front;
        private int rear;
        private int max;

        public Queues(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void insert(int item)
        {
            if (rear == max - 1)
            {
                return;
            }
            else
            {
                ele[++rear] = item;
            }
        }

        public int delete()
        {
            if (front == rear + 1)
            {
                return -1;
            }
            else
            {
                return ele[front++];
            }
        }

        public string printQueues()
        {
            string retVal = "";
            if (front == rear + 1)
            {
                return retVal;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    retVal += ele[i] + " ";
                }
            }
            return retVal;
        }

    }
}
