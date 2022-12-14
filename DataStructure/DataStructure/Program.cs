// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
     public class Program
    {
        static void Main(string[] args)
        {
            Linkedlist list = new Linkedlist();
            //list.Addnote(10);
            //list.Addnote(20);
            //list.Addnote(30);
            //list.Display();



            //list.Addreverse(10);
            //list.Addreverse(20);
            //list.Addreverse(30);
            //list.Display();
            //list.Delete();
            //list.DeleteLast();



            //stack_Ex stack_ = new stack_Ex();
            //stack_.push(10);
            //stack_.push(20);
            //stack_.push(30);
            //stack_.peek();
            //stack_.Display();

            //stack_.Pop();

            //stack_.Display();
            //stack_.Pop();

            //stack_.Display();
            //stack_.Pop();

            //stack_.Display();
            //stack_.Pop();
            //

            Queue_Ex queue_Ex = new Queue_Ex();
            queue_Ex.Enqueue(10);
            queue_Ex.Enqueue(20);
            queue_Ex.Enqueue(30);
            queue_Ex.Enqueue(40);
            queue_Ex.Display();

            queue_Ex.Dequeue();
            queue_Ex.Display();
            queue_Ex.Dequeue();
            queue_Ex.Display();
            queue_Ex.Dequeue();
            queue_Ex.Display();
        }
    }
}


 

