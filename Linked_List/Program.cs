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
    MyList.min();
    MyList.max();
  }
}