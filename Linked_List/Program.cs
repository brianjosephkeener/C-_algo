using System;

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
  public void addFront(int newElement) {
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
  public void Display() {
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
          Console.WriteLine($"Found provided parameter in linked list which is : {temp.data}");
          return true;
        }
        temp = temp.next;
      }
    }
    Console.WriteLine("Did not find provided parameter in linked list");
    return false;
  }


// Return the ​value​ (not the node) at the head of the list. If list is empty, return null.

public int front()
{
  Console.WriteLine($"the data value at the head of the list is: {this.head.data}");
  return this.head.data;
}

// Create a function that returns number of nodes in sList.
  public int length()
  {
    int count = 0;
    Node runner = new Node();
    runner = this.head;
      if(runner != null) {
        while(runner != null) {
          Console.WriteLine(runner.data + " ");
          runner = runner.next;
          count++;
        }
      
    }
    Console.WriteLine($"Length of linked list is: {count}");
    return count;
  }

// get average of total sList.
  public int average()
  {
    Node runner = new Node();
    runner = this.head;
    int avg = 0;
    int sum = 0;
    int total = 0;
    if(runner != null)
    {
      while(runner != null) {
        sum+=runner.data;
        total++;
        runner = runner.next;
      }
    }
    avg = sum / total;
    Console.WriteLine($"The average of the dataset in the linked list is: {avg}");
    return avg;
  }


// Create function​ m​in()​ and ​max()​ to returning smallest and largest values in the list.

public int min()
{
  int min = int.MaxValue;
  Node runner = new Node();
  runner = this.head;
    if(runner != null)
    {
      while(runner != null) {
        if(min > runner.data)
        {
          min = runner.data;
        }
        runner = runner.next;
      }
    }
    Console.WriteLine($"The min of the dataset in the linked list is: {min}");
    return min;
}

public int max()
{
  int max = int.MinValue;
  Node runner = new Node();
  runner = this.head;
    if(runner != null)
    {
      while(runner != null) {
        if(max < runner.data)
        {
          max = runner.data;
        }
        runner = runner.next;
      }
    }
    Console.WriteLine($"The max of the dataset in the linked list is: {max}");
    return max;
}

// back Create a standalone function that accepts a listNode pointer and returns the last value in the linked list.

public int back()
{
  int backVal = 0;
  Node runner = new Node();
  runner = this.head;
    if(runner != null)
    {
      while(runner != null) {
        backVal = runner.data;
        runner = runner.next;
      }
    }
    Console.WriteLine($"{backVal}");
    return backVal;
}

// Create a function that creates a listNode with given value and inserts it at end of a linked list.

public void addBack(int newElement)
{
  Node newNode = new Node();
  newNode.data = newElement;
  newNode.next = null;
  if(head == null)
  {
    head = newNode;
  }
  else {
    Node temp = new Node();
    temp = head;
    while (temp.next != null)
    {
      temp = temp.next;
    }
    temp.next = newNode;
  }
}

  public void removeBack() {
    if(this.head != null) {
      if(this.head.next == null) {
        this.head = null;
      } else {
        Node temp = new Node();
        temp = this.head;
        while(temp.next.next != null)
        {
          temp = temp.next;
        }
        Node lastNode = temp.next;
        temp.next = null; 
        lastNode = null;
      }
    }
  }

  // Create ​preprendVal(value,pos) ​that inserts a listNode with given ​value​ immediately before the given node.
  // Return the new list.


  public void preprendVal(int newElement, int pos)
  {
    Node newNode = new Node();
    newNode.data = newElement;
    newNode.next = null;
    if(pos < 1 )
    {
      Console.WriteLine("Position should be at least 1");
    }
    else if (pos == 1)
    {
      newNode.next = head;
      head = newNode;
    }
    else {
      Node runner = new Node();
      runner = head;
      for(int i = 1; i < pos - 1; i++) {
        if(runner != null) {
          runner = runner.next;
        }
      }
      if(runner != null)
      {
        newNode.next = runner.next;
        runner.next = newNode;
      }
      else 
      {
        Console.WriteLine("The previous node is null.");
      }
    }


  }

};

/*

*/


// test the code
class Implementation { 
  static void Main(string[] args) {
    LinkedList MyList = new LinkedList();

    //Add four elements in the list.
    MyList.addFront(10);
    MyList.addFront(20);
    MyList.addFront(30);
    MyList.addFront(40);
    MyList.Display();   

    MyList.appendVal(300, 2);
    MyList.Display();

  }
}