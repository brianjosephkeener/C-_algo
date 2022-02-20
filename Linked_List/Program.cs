﻿using System;

//node structure
class Node {
  public int data;
  public Node next;
};

class LinkedList {
  Node head;

  public LinkedList(){
    head = null;
  }
  
  //Add new element at the end of the list
  public void push_back(int newElement) {
    Node newNode = new Node();
    newNode.data = newElement;
    newNode.next = null; 
    if(head == null) {
      head = newNode;
    } else {
      Node temp = new Node();
      temp = head;
      while(temp.next != null)
        temp = temp.next;
      temp.next = newNode;
    }    
  }

  //Delete first node of the list
  public void pop_front() {
    if(this.head != null) {
      Node temp = this.head;
      this.head = this.head.next;
      temp = null;  
    }
  }

  //display the content of the list
  public void PrintList() {
    Node temp = new Node();
    temp = this.head;
    if(temp != null) {
      Console.Write("The list contains: ");
      while(temp != null) {
        Console.Write(temp.data + " ");
        temp = temp.next;
      }
      Console.WriteLine();
    } else {
      Console.WriteLine("The list is empty.");
    }
  }

  // Given a value, return whether value is found in any node within the list.
  public bool contains(int element)
  {
    Node temp = new Node();
    temp = this.head;
    if(temp != null) {
    while(temp != null) {
        if(temp.data == element)
        {
          Console.WriteLine("Found provided parameter in linked list");
          return true;
        }
        temp = temp.next;
      }
    }
    Console.WriteLine("Did not find provided parameter in linked list");
    return false;
  }     
};

// test the code
class Implementation { 
  static void Main(string[] args) {
    LinkedList MyList = new LinkedList();

    //Add four elements in the list.
    MyList.push_back(10);
    MyList.push_back(20);
    MyList.push_back(30);
    MyList.push_back(40);
    MyList.PrintList();   

    //Delete the first node
    MyList.pop_front();
    MyList.PrintList();  

    //test contains
    MyList.contains(10);
    MyList.contains(20);
  }
}