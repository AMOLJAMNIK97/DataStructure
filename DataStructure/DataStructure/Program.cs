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



            list.Addreverse(10);
            list.Addreverse(20);
            list.Addreverse(30);
            list.Display();
            list.Delete();
            //list.DeleteLast();
        }
    }
}


 

