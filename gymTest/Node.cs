using System;
using System.Collections.Generic;
using System.Text;

namespace gymTest
{
    public class Node{
        public int? data;
        public Node next;
        public Node(int? data){
            this.data = data;
            this.next = null;
        }
    }
    public class LinkedList{
        public Node head;
        public LinkedList(){
            this.head = new Node(null);
        }
        public void addNode(Node toAdd){
            Node pointer = head;
            while(pointer.next != null){
                pointer = pointer.next;
            }
            pointer.next = toAdd;
        }
        public void printList(){
            Node pointer = head;                        
            while (pointer != null){
                Console.WriteLine(pointer.data);
                pointer = pointer.next;
            }
        }
    }
}
