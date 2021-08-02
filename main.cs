using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
  //use floyd cycle finding algorithm
  public bool HasLoop(ListNode head){

    if(head==null){
      return false;
    }
    ListNode fast=head;
    ListNode  slow=head;
    while(slow!=null && fast!=null && fast.next!=null){
      slow=slow.next;
      fast=fast.next.next;

      if(slow==fast){
        return true;
      }
    }
    return false;
  }
}