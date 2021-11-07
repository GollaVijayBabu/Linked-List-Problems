using System;

namespace Day_14_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weclcome to Day 14 Problems \n");
            Console.WriteLine("Please select following options \n");
            Console.WriteLine(" 1.UC_1 \n 2.UC_2 \n 3.UC_3 \n 4.UC_4 \n 5.UC_5 \n " +
                "6.UC_6 \n 17.UC_7 \n 8.UC_8 \n 9.UC_9 \n 10.UC_10 \n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LinkedListOperations<int> linkedListAdd = new LinkedListOperations<int>();
                    linkedListAdd.add(56);
                    linkedListAdd.add(30);
                    linkedListAdd.add(70);
                    Console.WriteLine("Linked list sequence is");
                    linkedListAdd.display();
                    break;

                case 2:
                    LinkedListOperations<int> linkedListsequence = new LinkedListOperations<int>();
                    linkedListsequence.add(70);
                    Console.WriteLine("Linked list sequence is");
                    linkedListsequence.display();
                    linkedListsequence.InsertAtFirst(30);
                    Console.WriteLine("Linked list sequence is");
                    linkedListsequence.display();
                    linkedListsequence.InsertAtFirst(56);
                    Console.WriteLine("Linked list sequence is");
                    linkedListsequence.display();
                    break;

                case 3:
                    LinkedListOperations<int> linkedListseq = new LinkedListOperations<int>();
                    linkedListseq.add(56);
                    linkedListseq.add(30);
                    linkedListseq.add(70);
                    Console.WriteLine("Linked list sequence is");
                    linkedListseq.display();
                    break;

                case 4:
                    LinkedListOperations<int> linkedListInsert = new LinkedListOperations<int>();
                    linkedListInsert.add(56);
                    linkedListInsert.add(70);
                    Console.WriteLine("Linked list sequence is");
                    linkedListInsert.display();
                    linkedListInsert.InsertAfter(56, 30);
                    Console.WriteLine("Linked list sequence is");
                    linkedListInsert.display();

                    break;

                case 5:
                    LinkedListOperations<int> linkedListDelete = new LinkedListOperations<int>();
                    linkedListDelete.add(56);
                    linkedListDelete.add(30);
                    linkedListDelete.add(70);
                    Console.WriteLine("Linked list sequence is");
                    linkedListDelete.display();
                    linkedListDelete.RemoveFirst();
                    Console.WriteLine("Linked list sequence is");
                    linkedListDelete.display();
                    break;

                case 6:
                    LinkedListOperations<int> linkedListDel = new LinkedListOperations<int>();
                    linkedListDel.add(56);
                    linkedListDel.add(30);
                    linkedListDel.add(70);
                    Console.WriteLine("Linked list sequence is");
                    linkedListDel.display();
                    linkedListDel.RemoveLast();
                    Console.WriteLine("Linked list sequence is");
                    linkedListDel.display();
                    break;

                case 7:
                    LinkedListOperations<int> linkedListSearch = new LinkedListOperations<int>();
                    linkedListSearch.add(56);
                    linkedListSearch.add(30);
                    linkedListSearch.add(70);
                    Console.WriteLine("Linked list sequence is");
                    linkedListSearch.display();
                    linkedListSearch.search(30);
                    break;

                case 8:
                    LinkedListOperations<int> Insert = new LinkedListOperations<int>();
                    Insert.add(56);
                    Insert.add(30);
                    Insert.add(70);
                    Console.WriteLine("Linked list sequence is");
                    Insert.display();
                    Insert.InsertAfter(30, 40);
                    Console.WriteLine("Linked list sequence is");
                    Insert.display();
                    break;

                case 9:
                    LinkedListOperations<int> Delete = new LinkedListOperations<int>();
                    Delete.add(56);
                    Delete.add(30);
                    Delete.add(70);
                    Console.WriteLine("Linked list sequence is");
                    Delete.InsertAfter(30, 40);
                    Console.WriteLine("Linked list sequence is");
                    Delete.display();
                    Delete.Remove(40);
                    Console.WriteLine("Linked list sequence is");
                    Delete.display();
                    break;

                case 10:
                    LinkedListOperations<int> Sort = new LinkedListOperations<int>();
                    Sort.addSort(56);
                    Sort.addSort(30);
                    Sort.addSort(40);
                    Sort.addSort(70);
                    Console.WriteLine("Linked list sequence is");
                    Sort.display();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}
