using System;
using System.Collections.Generic;

//Tedros Abay
//Mid Term Project For Advanced Data Structure
namespace MidTermProjectForAdvancedDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicationUnderTest = new Program();
            var result = applicationUnderTest.CreatePair(new[] { 1, 3, 5, 7, 0, 90 });
            Console.WriteLine("Content of the Pair object after getting created");
            foreach (var resultItem in result)
            {
                Console.WriteLine(resultItem);
            }
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            var inputArray = new[] { 1, 3, 5, 7, 0, 90 };
            Console.WriteLine("Before Calling Reverse Array");
            Console.WriteLine("-----------------------------");
            foreach (var item in inputArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var resultArray = applicationUnderTest.ReverseArray(new[] { 1, 3, 5, 7, 0, 90 });
            Console.WriteLine("After  Calling Reverse Array");
            Console.WriteLine("-----------------------------");
            foreach (var item in resultArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            var array1 = new[] { -5, 6, 3, -2, 10, -12, 20, 11 };
            var array2 = new[] { 7, 20, 9, -5, 2, 14, 3 };

            Console.WriteLine("Content of  Array1");
            Console.WriteLine("-----------------------------");
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Content of  Array2");
            Console.WriteLine("-----------------------------");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            var resultUnion = applicationUnderTest.FindIntersection(array1, array2);
            Console.WriteLine("Intersection  of Array1 and Array2");
            Console.WriteLine("-----------------------------");
            foreach (var item in resultUnion)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            var nonUniqueValues = new []{ 7, 10, 10, 12, 15, 17, 17, 17, 17, 20, 25, 33, 40, 40, 40, 45, 45, 49 };
            Console.WriteLine("Values of nonUnique Array");
            Console.WriteLine("-----------------------------");
            foreach (var item in nonUniqueValues)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            var resultUniqueValues = applicationUnderTest.RemoveDuplicates(nonUniqueValues);
           Console.WriteLine("Content of  unique result");
            Console.WriteLine("-----------------------------");
            foreach (var item in resultUniqueValues)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();


            var myLinkedList = new MyLinkedList(10);
            myLinkedList.addLast(15);
            myLinkedList.addLast(20);
            myLinkedList.addLast(25);
            myLinkedList.addLast(30);
            myLinkedList.addLast(35);
            myLinkedList.addLast(40);
           // myLinkedList.addLast(45);

            Console.WriteLine("Content of  the linkedlist before reversal ");
            myLinkedList.DisplayAll();

            //Apply Reverse linked list operation.
            var reversedLinkedList = applicationUnderTest.ReverseLinkedList(myLinkedList);

            Console.WriteLine("Content of  the linkedlist after reversal ");
            reversedLinkedList.DisplayAll();
            Console.WriteLine();
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();


            myLinkedList = new MyLinkedList(10);
            myLinkedList.addLast(103);
            myLinkedList.addLast(20);
            myLinkedList.addLast(88);
            myLinkedList.addLast(30);
            myLinkedList.addLast(99);
            Console.WriteLine("Content of  the linkedlist before applying sorting with ascending order ");
            myLinkedList.DisplayAll();
            Console.WriteLine("Content of  the linkedlist after applying sorting with ascending order ");
            myLinkedList.bubblesortAscending();
            myLinkedList.DisplayAll();
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            myLinkedList = new MyLinkedList(10);
            myLinkedList.addLast(103);
            myLinkedList.addLast(20);
            myLinkedList.addLast(88);
            myLinkedList.addLast(30);
            myLinkedList.addLast(99);
            myLinkedList.addLast(40);
            Console.WriteLine("Content of  the linkedlist before applying sorting with descending order ");
            myLinkedList.DisplayAll();
            Console.WriteLine("Content of  the linkedlist after applying sorting with descending order ");
            myLinkedList.bubblesortDescending();
            myLinkedList.DisplayAll();
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            Console.WriteLine();

            myLinkedList = new MyLinkedList(10);
            myLinkedList.addLast(103);
            myLinkedList.addLast(103);
            myLinkedList.addLast(20);
            myLinkedList.addLast(20);
            myLinkedList.addLast(88);
            myLinkedList.addLast(30);
            myLinkedList.addLast(30);
            myLinkedList.addLast(99);
            myLinkedList.addLast(99);
            myLinkedList.addLast(99);
            myLinkedList.addLast(40);
            myLinkedList.addLast(400);
            myLinkedList.bubblesortAscending();
            Console.WriteLine("Content of  sorted  linkedlist before applying Remove duplicate with descending order ");
            myLinkedList.DisplayAll();
           
            myLinkedList.RemoveDuplicateFromSortedList();

            Console.WriteLine("Content of  the sorted linkedlist after removeing duplicates.");
            myLinkedList.DisplayAll();
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            Console.WriteLine();

            var intStack = new Stack<int>();
            intStack.Push(103);
            intStack.Push(100);
            intStack.Push(20);
            intStack.Push(55);
            intStack.Push(88);
            intStack.Push(31);
            intStack.Push(30);
            intStack.Push(29);
            intStack.Push(79);
            intStack.Push(99);
            intStack.Push(80);
            intStack.Push(400);
            
            Console.WriteLine("Content of  Stack   before applying Remove last entry:");
            intStack.GetEnumerator();
            var enumerator = intStack.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current + " ");
            }
            Console.WriteLine();
           
            Console.WriteLine("Content of  Stack   after applying Remove last entry");
            intStack = applicationUnderTest.RemoveTop(intStack);
            enumerator = intStack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            Console.WriteLine();

             intStack = new Stack<int>();
            intStack.Push(103);
            intStack.Push(100);
            intStack.Push(20);
            intStack.Push(55);
            intStack.Push(88);
            intStack.Push(31);
            intStack.Push(30);
            intStack.Push(29);
            intStack.Push(79);
            intStack.Push(99);
            intStack.Push(80);
            intStack.Push(400);

            Console.WriteLine("Content of  Stack before Swapping  half of the stack:");
            intStack.GetEnumerator();
            enumerator = intStack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Content of Stack after Swapping  half of the stack:");
            intStack = applicationUnderTest.SwapHalfOfStack(intStack);
            enumerator = intStack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            Console.WriteLine();

            var intQueue = new Queue<int>();
            intQueue.Enqueue(103);
            intQueue.Enqueue(100);
            intQueue.Enqueue(20);
            intQueue.Enqueue(55);
            intQueue.Enqueue(88);
            intQueue.Enqueue(3100);
            intQueue.Enqueue(30);
            intQueue.Enqueue(29);
            intQueue.Enqueue(79);
            intQueue.Enqueue(99);
            intQueue.Enqueue(80);
            intQueue.Enqueue(400);

            Console.WriteLine("Content of  Queue before positioning the max to the front:");
            intQueue.GetEnumerator();
           var  enumeratorQueue = intQueue.GetEnumerator();
            while (enumeratorQueue.MoveNext())
            {
                Console.WriteLine(enumeratorQueue.Current + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Content of  Queue after positioning the max to the front:");
            intQueue = PositionMaxEntryToTheFront(intQueue);
            enumeratorQueue = intQueue.GetEnumerator();
            while (enumeratorQueue.MoveNext())
            {
                Console.WriteLine(enumeratorQueue.Current + " ");
            }
            Console.WriteLine();

            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            Console.ReadKey();
        }
    

        public Pair[] CreatePair(int[] inputValues)
        {
            List<Pair> zeroSumPairs = new List<Pair>();
            foreach (var inputValue in inputValues)
            {
                var targetPair = new Pair(inputValue, -1 * inputValue);
                zeroSumPairs.Add(targetPair);

            }
            return zeroSumPairs.ToArray(); ;
        }

        /// <summary>
        /// Reverses the array input.
        /// </summary>
        /// XAs<param name="inputValues"></param>
        /// <returns></returns>
        public int[] ReverseArray(int[] inputValues)
        {
            var n = inputValues.Length;
            for (int i = 0; i < n / 2; i++)
            {
                /* var leftItem = inputValues[i];
                 var rightItem = inputValues[n - i - 1];
                 var temp = leftItem;//back up leftitem
                 leftItem = rightItem; //put theitem into leftmemory address
                 rightItem = temp;
                 */
                var temp = inputValues[i];
                inputValues[i] = inputValues[n - i - 1];
                inputValues[n - i - 1] = temp;
            }
            return inputValues;
        }

        /// <summary>
        /// Finds common values between Array1 and Array2
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        int [] FindIntersection(int[] array1, int[] array2)
        {
            List<int> intersection = new List<int>();
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if(array1[i] == array2[j])
                    {
                        intersection.Add(array1[i]);
                    }
                }

            }
            return intersection.ToArray();
        }
        /// <summary>
        /// Eliminate redundant item from the array
        /// </summary>
        /// <param name="arrayValue"></param>
        /// <returns></returns>
        int[] RemoveDuplicates(int[] arrayValue)
        {
            //Yenoh Merkeb
            List<int> uniqueContainer = new List<int>();
            uniqueContainer.Add(arrayValue[0]);
            for (int index = 1; index < arrayValue.Length; index++)
            {
                if(arrayValue[index -1] == arrayValue[index])
                {
                    continue;
                }
                else
                {
                    uniqueContainer.Add(arrayValue[index]);
                }
            }
            return uniqueContainer.ToArray();

        }

        MyLinkedList ReverseLinkedList(MyLinkedList myLinkedList)
        {
            MyLinkedListNode left = myLinkedList.getFirst();
            MyLinkedListNode right = myLinkedList.getLast();
            MyLinkedListNode tempNode = null;

            //Shuffle the  right neighbours of left node to point to right.
            left.getNext().setPrevious(right);
            
            //Shuffle the left of neighbours of right node to point to left.           
            right.getPrevious().setNext(left);

            // make sure that the old left neighbor of right node is  now the recent  left neighbour of left node
            // and the old left neighbour of  left node is now  the recent left neighbor of right node
            tempNode = left.getPrevious();
            left.setPrevious(right.getPrevious());
            right.setPrevious(tempNode);
                       
            // make sure that the old right neighbor of right node is  now the recent  right neighbour of left node
            // and the old right neighbour of left node is now  the recent right neighbor of right node
            tempNode = left.getNext();
            left.setNext(right.getNext());
            right.setNext(tempNode);

            //Arrange the first and last node as they are at the edge
            myLinkedList.setFirstNode(right);
            myLinkedList.setLastNode(left);

            //Get the first and last after reversing the left and right edge nodes.
            left = myLinkedList.getFirst();
            right = myLinkedList.getLast();
            
            //This is for the remaining inner nodes.
            for (int i = 1; i < myLinkedList.getCount()/2; i++)
            {
                left = left.getNext();
                if(left == right) //left and right have joined  for even length  of linked list.
                {
                    break;
                }

                right = right.getPrevious();                

                if(left == right)//left and right have joined  for odd length  of linked list.
                {
                    break;
                }
                //Shuffle the refences of neighbours of left to point to right.
                if(left.getNext()== right) // left and right about to join
                {
                    left.getPrevious().setNext(right);
                    right.getNext().setPrevious(left);

                    left.setNext(right.getNext());
                    right.setPrevious(left.getPrevious());

                    left.setPrevious(right);
                    right.setNext(left);
                    break;
                }

                left.getNext().setPrevious(right);
                left.getPrevious().setNext(right);
                //Shuffle the refences of neighbours of right to point to left.
                right.getNext().setPrevious(left);
                right.getPrevious().setNext(left);

                // make sure that the old left neighbor of right node is  now the recent  left neighbour of left node
                // and the old left neighbour of  left node is now  the recent left neighbor of right node
                tempNode = left.getPrevious();
                left.setPrevious(right.getPrevious());
                right.setPrevious(tempNode);

                // make sure that the old right neighbor of right node is  now the recent  right neighbour of left node
                // and the old right neighbour of left node is now  the recent right neighbor of right node
                tempNode = left.getNext();
                left.setNext(right.getNext());
                right.setNext(tempNode);

                tempNode = left;
                left = right;
                right = tempNode;
            }
            return myLinkedList;
        }

        Stack<int> RemoveTop(Stack<int> intStack)
        {
            if(intStack != null && intStack.Count > 0)
            {
                intStack.Pop();
            }
            return intStack;
        }

        Stack<int> SwapHalfOfStack(Stack<int> intStack)
        {
            var firstHalf = new Stack<int>();
            var seconfHalf = new Stack<int>();
            var halfSize = intStack.Count / 2;
            int i = 1;
            for ( ; i <= halfSize; i++)
            {
                firstHalf.Push(intStack.Pop());
            }
            for ( i = 1; i <= halfSize; i++)
            {
                seconfHalf.Push(intStack.Pop());
            }

            var mergedStack = new Stack<int>();

            for (i = 1; i <= halfSize; i++)
            {
                mergedStack.Push(firstHalf.Pop());
            }
            for (i = 1; i <= halfSize; i++)
            {
                mergedStack.Push(seconfHalf.Pop());
            }
            return mergedStack;
        }

        // To heapify a subtree with  
        // root at given index 
        static void MaxHeapify(int[] arr,
                               int currentIndex, int n)
        {
            int leftChildIndex = 2 * currentIndex + 1;
            int rightChildIndex = 2 * currentIndex + 2;
            int largest = currentIndex;
            if (leftChildIndex < n && arr[leftChildIndex] > arr[currentIndex])
                largest = leftChildIndex;
            if (rightChildIndex < n && arr[rightChildIndex] > arr[largest])
                largest = rightChildIndex;
            if (largest != currentIndex) // if either left or right child is greater that the current, then make the greter one to be the current one, and heapify the current largest until both children are not greater than the current.
            {
                // swap arr[i] and arr[largest] 
                int temp = arr[currentIndex];
                arr[currentIndex] = arr[largest];
                arr[largest] = temp;
                MaxHeapify(arr, largest, n);
            }
        }

        // This function basically 
        // builds max heap 
        static void ConvertMaxHeap(int[] arr,
                                   int n)
        {
            // Start from bottommost and  
            // rightmost internal mode and  
            // heapify all internal modes  
            // in bottom up way 
            for (int i = (n - 2) / 2; i >= 0; --i)
                MaxHeapify(arr, i, n);
        }

        static Queue<int>  PositionMaxEntryToTheFront(Queue<int> input)
        {
            Queue<int> maxQueue = new Queue<int>();
            var convertedArray = input.ToArray();
            Array.Sort(convertedArray, (x, y) => y - x);
            foreach (var item in convertedArray)
            {
                if (maxQueue.Count == 0)
                {
                    maxQueue.Enqueue(item);
                }
                else if (maxQueue.Peek() >= item)
                {
                    maxQueue.Enqueue(item);
                }
                else
                {
                    maxQueue.Enqueue(item);
                    var count = maxQueue.Count;

                    while (count > 1)
                    {
                        maxQueue.Enqueue(maxQueue.Dequeue());
                        count--;
                    }
                }
                
            }
            return maxQueue;
        }
    }
    //=============================End of Consumer class=====================
    public class MyLinkedListNode
    {
        //for a doubly linked list
        private int data;
        private MyLinkedListNode next;
        private MyLinkedListNode previous;
        //constructor
        public MyLinkedListNode(int data)
        {
            this.data = data;
            next = null;
            previous = null;
        }
        //get and set

        public int getData()
        {
            return data;
        }

        public MyLinkedListNode getNext()
        {
            return next;
        }

        public MyLinkedListNode getPrevious()
        {
            return previous;
        }

        public void setData(int data)
        {
            this.data = data;
        }

        public void setNext(MyLinkedListNode next)
        {
            this.next = next;
        }

        public void setPrevious(MyLinkedListNode previous)
        {
            this.previous = previous;
        }


    }

    public class MyLinkedList
    {

        MyLinkedListNode first;
        MyLinkedListNode last;
        int count;

        public MyLinkedList()
        {
            first = null;
            last = null;
            count = 0;
        }
        public MyLinkedList(int data)
        {
            //create a node
            MyLinkedListNode node = new MyLinkedListNode(data);
            first = node;
            last = node;
            count = 1;
        }
        //getters

        public MyLinkedListNode getFirst()
        {
            return first;
        }

        public void setFirstNode(MyLinkedListNode first)
        {
            this.first = first;
        }

        public MyLinkedListNode getLast()
        {
            return last;
        }

        public void setLastNode(MyLinkedListNode last)
        {
            this.last = last;
        }

        public int getCount()
        {
            return count;
        }
        //===============================================
        //methods:
        public void addFirst(int data)
        {
            MyLinkedListNode node = new MyLinkedListNode(data);
            //check if empty
            if (count == 0)
            {
                first = last = node;
            }
            else
            {
                first.setPrevious(node);
                node.setNext(first);
                first = node;
            }
            count++;
        }
        public void addLast(int data)
        {
            MyLinkedListNode node = new MyLinkedListNode(data);
            //check if empty
            if (count == 0)
            {
                first = last = node;
            }
            else
            {
                //connect last to node
                last.setNext(node);
                //connect node back to last
                node.setPrevious(last);
                //make the node the last one
                last = node;
            }
            count++;
        }
        public int getFirstData()
        {
            //get first element 
            return first.getData();
        }
        public int getLastData()
        {
            //get last element
            return last.getData();
        }
        public int removeFirst()
        {
            if (count == 0)
            {
                throw new Exception("No such element exists!");

            }
            else if (count == 1)
            {
                //make first and last null
                //save the data you want to return before changing
                //the references
                int temp = first.getData();
                first = last = null;
                count--;
                return temp;
            }
            else
            {
                //save the data
                int temp = first.getData();
                //save a reference to the second node
                MyLinkedListNode tempref = first.getNext();
                //break the next link from first to the second node
                first.setNext(null);
                //break the link from second node back to first node
                tempref.setPrevious(null);
                //reset first to the second node
                first = tempref;
                count--;
                return temp;//return the data of the remove node
            }

        }
        //    public int removeLast(){
        //        
        //    }
        public int[] toArray()
        {
            //copy the entire list to an array an return it
            //create the array
            int[] array = new int[count];
            //sequence through linkedlist from first node to last
            //use a temp to start at the first node
            MyLinkedListNode temp = first;
            int index = 0;
            while (temp != null)
            {
                //get data from node and copy it to array
                array[index] = temp.getData();

                //increment index
                index++;
                //move to next node
                temp = temp.getNext();
            }
            return array;
        }

        public int getData(int index)
        {
            //make sure that the index is valid
            if (index < 0 || index >= count)
                throw new Exception("index out of bound");
            //sequence through the linkedlist until you reach the node
            //at the given index
            //return its data
            MyLinkedListNode temp = first;
            int i = 0;
            while (i < index)
            {
                temp = temp.getNext();
                i++;
            }
            //temp should be referencing the node at the given index
            return temp.getData();
        }
        //problems
        public int set(int index, int data)
        {
            //replace the data of the node at the given index
            //return the previous data
            throw new IndexOutOfRangeException();
        }
        public bool contains(int data)
        {
            //return true if this data is contained in one of the nodes
            throw new IndexOutOfRangeException();
        }
        public int indexOf(int data)
        {
            //return the index of the node that contains the given data
            throw new IndexOutOfRangeException();
        }
        //challenging
        //apply bubblesort to the linkedlist
        public void bubblesortAscending()
        {
            //apply bubble sort priciples to a linked list
            for (MyLinkedListNode i = this.first; i != this.last; i= i.getNext())
            {

                for (MyLinkedListNode j = i.getNext(); j != null; j=j.getNext())
                {
                     if( i.getData() > j.getData())
                    {
                        var temp = i.getData();
                        i.setData(j.getData());
                        j.setData(temp);
                    }
                }
            }
        }

        public void bubblesortDescending()
        {
            //apply bubble sort priciples to a linked list
            for (MyLinkedListNode i = this.first; i != this.last; i = i.getNext())
            {

                for (MyLinkedListNode j = i.getNext(); j != null; j = j.getNext())
                {
                    if (i.getData() < j.getData())
                    {
                        var temp = i.getData();
                        i.setData(j.getData());
                        j.setData(temp);
                    }
                }
            }
        }
        /// <summary>
        /// Removes duplicated from sorted list
        /// ASsumption: the list is already sorted either ascending or descending.
        /// </summary>
        public void RemoveDuplicateFromSortedList()
        {
            for (MyLinkedListNode i = this.first; i!= null && i != this.last; i = i.getNext())
            {
                var leftNode = i;
                var rightNode = i.getNext();
                if (leftNode.getData() == rightNode.getData())
                {
                    MyLinkedListNode duplicateNode = rightNode.getNext();
                    for (; duplicateNode != null && duplicateNode.getData() == rightNode.getData(); duplicateNode = duplicateNode.getNext())
                    { }
                    if(duplicateNode != null) // if nonduplicate found
                    {
                        duplicateNode.setPrevious(leftNode);
                        leftNode.setNext(duplicateNode);
                    }
                    else //duplicate till the end of the linked list.
                    {
                         leftNode.setNext(duplicateNode);
                    }                   
                   //recliam the duplicate chain  to get garbage collected.
                }

            }
        }
            //merge two linked list
        public static MyLinkedList Merge(MyLinkedList list1, MyLinkedList list2)
        {
            //create a new linked list that contains both
            //but merge them by alternating between list1 and list2
            //also don't assume that both lists have the same count
            throw new IndexOutOfRangeException();
        }

        public void DisplayAll()
        {
            //return its data
            MyLinkedListNode temp = first;
            while(temp!= null)
            {
                Console.Write( temp.getData() + " ");
                temp = temp.getNext();
            }
            Console.WriteLine();

        }



    }



    public class Pair
    {

        private int firstPair;
        private int secondPair;

        public Pair(int x, int y)
        {
            this.firstPair = x;
            this.secondPair = y;
            var sum = this.firstPair + this.secondPair;
            if(sum  != 0)
            {
                throw new Exception("Invalid Pair creation!");
            }
        }
        /// <summary>
        /// ToString method for the Pair class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"[{this.firstPair},{this.secondPair}]";
        }
    }
}
