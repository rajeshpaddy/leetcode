using System;

namespace LeetCode_AddTwoNumbers
{
    class Program
    {
          public class ListNode
        {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
     }

        static ListNode NumberToNode(int number)
        {
            ListNode headnode = new ListNode(0);
            ListNode travelnode = headnode;
            foreach (char c in number.ToString().ToCharArray())
            {
                travelnode.val = Convert.ToInt32(c.ToString());
                travelnode.next = new ListNode(0);
                travelnode=travelnode.next;
            }
            return headnode;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! test ter");
            ListNode finalnode = AddTwoNumbers(NumberToNode(321),NumberToNode(432));

        }
        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int l1Number = 0, l2Number = 0;
            ListNode returnNode = new ListNode(0);
            ListNode travelnode = returnNode;
            int carryover = 0;
            while (l1 != null || l2 != null)
            {

                if (l1 != null)
                {
                    l1Number = l1.val;
                    l1 = l1.next;
                }
                else
                {
                    l1Number = 0;
                }
                if (l2 != null)
                {
                    l2Number = l2.val;
                    l2 = l2.next;
                }
                else
                {
                    l2Number = 0;
                }

                int finalnumber = l1Number + l2Number + carryover;


                carryover = finalnumber / 10;
                travelnode.val = finalnumber % 10;

                if (l1 != null || l2 != null || carryover > 0)
                {
                    travelnode.next = new ListNode(carryover);
                    travelnode = travelnode.next;
                }

            }

            return returnNode;

        }
    }
}
