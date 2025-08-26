using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//-----DSA-Patterns----//
/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int n = 5;
            for (int i = 0; i <n ; i++)
            {
                if (i%2==0)
                {
                    start = 1;
                }
                else
                {
                    start = 0;
                }
                for (int j = 0; j <=i; j++)
                {
                    Console.Write(start);
                    start = 1 - start;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i <=2*n-1; i++)
            {
                int start = i;
                if (start>n)
                {
                    start = 2 * n - i;
                }
                for (int j = 0; j <start; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2*i+1; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <=n-i+1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            for (int i = 1; i <=n; i++)
            {
                int start = 2 * (n - i);

                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                for (int j = 1; j <=start; j++)
                {
                    Console.Write(" ");
                    
                }
                for (int j = i; j >=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
                int num = 1;
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(num+" ");
                    num += 1;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <=n; i++)
            {
                char c = 'A';
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(c);
                    c++;
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i =0 ; i <= n; i++)
            {
                char c = 'A';
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(c);
                    c++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            char c = 'A';
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(c);
                }
                c++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <=n-i-1; j++)
                {
                    Console.Write(" ");
                }
                char c = 'A';
                int breakpoint = (2 * i + 1)/2;
                for (int j = 1; j <=2*i+1; j++)
                {
                    Console.Write(c);
                    if (j<=breakpoint)
                    {
                        c++;
                    }
                    else
                    {
                        c--;
                    }

                }
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (char ch =(char)('E'-i); ch <='E'; ch++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            for (int i = 0; i < 2 * n - 1; i++)
            {
                for (int j = 0; j < 2 * n - 1; j++)
                {
                    int top = i;
                    int left = j;
                    int right = (2 * n - 2) - j;
                    int down = (2 * n - 2) - i;
                    Console.Write(n - Math.Min(Math.Min(top, down), Math.Min(left, right)));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

//recursion backtracking
/*namespace DSA_practice
{
    public class rec
    {
        public void m1(int i, int n)
        {
            if (i>n)
            {
                return;
            }
            m1(i + 1, n);
            Console.WriteLine(i);
           
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            rec r = new rec();
            r.m1(1,5);
            Console.ReadLine();
        }
    }
}*/
// 
/*namespace DSA_practice
{
    public class factorial
    {
        public int fact(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return n * fact(n - 1);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            factorial r = new factorial();
            int r1=r.fact(n);
            Console.WriteLine(r1);
            Console.ReadLine();
        }
    }
}*/

//swap an array using recarsion
/*namespace DSA_practice
{
    public class ArrayShaping
    {
        public void Reverse(int i, int[] s, int n)
        {
            if (i >= n)
                return;

            // Swap elements
            int temp = s[i];
            s[i] = s[n];
            s[n] = temp;

            

            // Recursive call
            Reverse(i + 1, s, n - 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int n = arr.Length;

            ArrayShaping obj = new ArrayShaping();
            obj.Reverse(0, arr, n - 1);

            Console.WriteLine("Reversed array:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}*/

//checking palindrome string using recarsion
/*namespace DSA_practice
{
    public class palindrome
    {
        public string n = "MADAM";
        public bool palNum(int i)
        {
            if (i>=n.Length/2)
            {
                return true;
            }
            if (n[i]!=n[n.Length-i-1])
            {
                return false;
            }
            return palNum(i + 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            palindrome p = new palindrome();
            bool p1=p.palNum(0);
            if (p1 == true)
            {
                Console.WriteLine("is a palindrome");
            }
            else
            {
                Console.WriteLine("is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}*/
//checking the place of the fibonacci number using while loop
/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 55;
            int temp = 0;
            int count = 2;
            int a = 0;
            int b = 1;
            while (temp<n)
            {
                temp = a + b;
                a = b;
                b = temp;
                count++;
            }
            if (temp==n)
            {
                Console.WriteLine($"{n} is a {count}th number");
            }
            else
            {
                Console.WriteLine("not a requried number");
            }
            Console.ReadLine(); 
        }
    }
}*/


/*namespace DSA_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            fib fi = new fib();
           int p=fi.f(4);
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
    public class fib
    {
        public int f(int n)
        {
            if (n<=1)
            {
                return n;

            }
            int last1 = f(n - 1);

            int last2= f(n - 2);

            return last1 + last2;
        }
    }


}*/

// integer array hashing
/*namespace DSA_practice
{
    using System;

    class Program
    {
        static void Main()
        {
            // Ask for size of array
            Console.Write("Enter the number of elements (n): ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            // Ask for array elements
            Console.WriteLine($"Enter {n} integers (space or line separated):");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Create frequency hash (size 13)
            int[] hash = new int[13];
            for (int i = 0; i < n; i++)
            {
                hash[arr[i]]++;
            }

            // Ask for number of queries
            Console.Write("Enter number of queries (q): ");
            int q = int.Parse(Console.ReadLine());

            // Answer each query
            Console.WriteLine("Enter the numbers you want to check:");
            for (int i = 0; i < q; i++)
            {
                Console.Write($"Query {i + 1} - Enter number: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number < hash.Length)
                {
                    Console.WriteLine($"The number {number} appears {hash[number]} time(s).");
                }
                else
                {
                    Console.WriteLine("Number out of range (0-12).");
                }
            }
            Console.ReadLine();
        }
    }

}*/

// character array hashing
/*
 namespace DSA_practice
{

    class Program
    {
        static void Main()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'a', 'b', 'e', 'f', 'c' };

            // Create frequency hash (size 26)
            int[] hash = new int[26];
            for (int i = 0; i < arr.Length; i++)
            {
                hash[arr[i]-'a']++;
            }

            // Ask for number of queries
            Console.Write("Enter number of queries (q): ");
            int q = int.Parse(Console.ReadLine());

            int count = 0;
            while(q-->0)
            {
                count++;
                Console.Write($"enter{count}st character:");
                char c = char.Parse(Console.ReadLine());
                Console.WriteLine(hash[c-'a']);
            }
            Console.ReadLine();
        }
    }

}
*/
//integer array mapping
/*namespace DSA_practice
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] arr = {1,2,3,1,2};
            // Create frequency mapping
            Dictionary<int, int> mpp = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (mpp.ContainsKey(arr[i]))
                    mpp[arr[i]]++;
                else
                    mpp[arr[i]] = 1;

            }

            // Ask for number of queries
            Console.Write("Enter number of queries (q): ");
            int q = int.Parse(Console.ReadLine());

            int count = 0;
            while (q-- > 0)
            {
                count++;
                Console.Write($"enter {count}'st character:");
                int c = int.Parse(Console.ReadLine());
                if (mpp.ContainsKey(c))
                    Console.WriteLine($"Frequency: {mpp[c]}");
                else
                    Console.WriteLine("Number not found in array.");
            }
            Console.ReadLine();
        }
    }

}*/

//selection sort
/*namespace DSA_practice
{

    class Program
    {
        static void Main()
        {

            int[] arr = { 13, 46, 24, 52, 20, 9 };
            for (int i = 0; i < arr.Length-1; i++)
            {
                int min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}*/

//bubble sort
/*namespace DSA_practice
{

    class Program
    {
        static void Main()
        {

            int[] arr = { 13, 46, 24, 52, 20, 9 };
            for (int i =arr.Length-1; i>=1; i--)
            {
                for (int j = 0; j <=i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}*/

//insertion sort
/*
 namespace DSA_practice
{

    class Program
    {
        static void Main()
        {

            int[] arr = { 14,9,15,12,6,8,18 };

            for (int i = 0; i <=arr.Length-1; i++)
            {
                int j = i;
                while (j>0 && arr[j-1]>arr[j])
                {
                    int temp = arr[j-1];
                    arr[j-1] = arr[j ];
                    arr[j] = temp;
                    j--;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
*/
//merge sort(with recursion)
/*namespace DSA_practice
{
    public class merge_sort
    {
        //for dividing 
        public void MG(int[] arr,int low,int high)
        {
            if (low>=high)
            {
                return;
            }
            int mid = (low + high) / 2;
            MG(arr, low, mid);
            MG(arr, mid + 1, high);

            //merging object
            Merge(arr, low, mid, high);
        }

        //merging 
        public void Merge(int[] arr,int low,int mid,int high)
        {
            List<int> temp = new List<int>();
            int left = low;
            int right = mid+1;
            while (left<=mid && right<=high)
            {
                if (arr[left]<=arr[right])
                {
                    temp.Add(arr[left]);
                    left++;
                }

                else
                {
                    temp.Add(arr[right]);
                    right++;
                }
            }

            //for remaining
            while (left<=mid)
            {
                temp.Add(arr[left]);
                left++;
            }
            while (right <= high)
            {
                temp.Add(arr[right]);
                right++;
            }

            //converting temp list to array
            for (int i = low; i <=high; i++)
            {
                arr[i] = temp[i-low];
            }
        }
    }

    class Program
    {
        static void Main()
        {

            int[] arr = { 14, 9, 1, 15, 12, 6, 1, 8, 18 , 1};
            int low = 0;
            int high = arr.Length-1;
            merge_sort m = new merge_sort();
            m.MG(arr, low, high);

            //printing sorted array
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}*/

//quick sort
/*namespace DSA_practice
{

    public class quickSort
    {
        public void qs(int[] arr,int low,int high)
        {
            if (low<high)
            {
                int partion= sort(arr,low,high);
                qs(arr, low, partion - 1);
                qs(arr, partion + 1, high);
            }

        }
        public  int sort(int[] arr,int low,int high)
        {
            int pivote = arr[low];
            int i = low;
            int j = high;
            while (i<j)
            {
                while (arr[i]<=pivote && i<high)
                {
                    i++;
                }
                while (arr[j]>pivote && j>=low)
                {
                    j--;
                }
                if (i<j)
                {
                    int temp1 = arr[i];
                     arr[i] = arr[j];
                     arr[j] = temp1;

                }
                
            }
            int temp2 = arr[low];
            arr[low] = arr[j];
            arr[j] = temp2;
            return j;

        }
    }
    class Program
    {
        static void Main()
        {
            int[] arr = {5,3,2,6,1,4};
            int low = 0;
            int high = arr.Length - 1;
            quickSort Q = new quickSort();
            Q.qs(arr, low, high);

            //printing sorted array
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}*/

//arrays
//largest element in the array 
/*
 namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 2, 1, 5, 2 };
            int largest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine(largest);
            Console.ReadLine();

        }
    }
}
*/
//second largest
//brot force 
/*
 namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 2, 1, 5, 2 };
            //sorting
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine(arr[arr.Length-2]);
            Console.ReadLine();

        }
    }
}
*/

//better solution

/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 2, 1, 5, 2 };
            //first largest
            int largest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            //second largest
            int second_largest = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>second_largest && arr[i]!=largest)
                {
                second_largest = arr[i];
                }
            
            }
            Console.WriteLine(second_largest);

            Console.ReadLine();
        }
    }
}*/

//optimal solution
/*
 namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 2, 1, 5, 2 };
            int largest = arr[0];
            int second_largest = -1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>largest)
                {
                    second_largest = largest;
                    largest = arr[i];

                }
                else if (arr[i]<largest && arr[i]>second_largest)
                {
                    second_largest = arr[i];
                }
            }
            Console.WriteLine(second_largest);
            Console.ReadLine();
        }
    }
}
*/

//second smallest
/*
 namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 2, 1, 5, 2 };
            int smallest = arr[0];
            int second_smallest = 9;//max value
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    second_smallest = smallest;
                    smallest = arr[i];

                }
                else if (arr[i] > smallest && arr[i] < second_smallest)
                {
                    second_smallest = arr[i];
                }
            }
            Console.WriteLine(second_smallest);
            Console.ReadLine();
        }
    }
}
 */

//checking the array is sorted or not
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            //int[] arr = { 3, 2, 1, 5, 2 };
            int[] arr = { 1, 2, 3, 4, 4, 4, 5 };
            bool is_sorted = true;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>=arr[i-1])
                {
                    
                }
                else
                {
                    is_sorted=false;
                    break;

                }              
            }
            
            if (is_sorted==true)
            {
                Console.WriteLine("array is  perfect");
            }
            else
            {
                Console.WriteLine("array is not perfect");
            }
   
            Console.ReadLine();
        }
    }
}*/
//brot force(eliminating duplicate elements)
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            //int[] arr = { 3, 2, 1, 5, 2 };
            int[] arr = { 1, 2, 3, 4, 4, 4, 5 };
            SortedSet<int> st = new SortedSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                st.Add(arr[i]);
            }
            
            foreach (int n in st)
            {
                Console.WriteLine(n);
            }
            
            Console.ReadLine();
        }
    }
}*/

//optimal solution
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 1,1,2,2,2, 3, 4, 4, 4, 5,5,5, };

            int i = 0;
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[j]!=arr[i])
                {
                    arr[i + 1] = arr[j];
                    i++;
                }
            }
            for (int j = 0; j <=i; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.ReadLine();
        }
    }
}*/
//armstrong number for any number
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int temp = 153;
            int num = temp;
            int sum = 0;
            int power = temp.ToString().Length;
            while (num!=0)
            {
                int digit = num % 10;
                sum = sum +(int)Math.Pow(digit,power);
                num /= 10;
            }
            if (temp==sum)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.ReadLine();
        }
    }
}*/
//counting digits 
/*
 namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int num = -13456;
            int count = 0;
            if (num==0)
            {
                count = 1;
            }
            num = Math.Abs(num);
            while (num!=0)
            {
                count++;
                num /= 10;
                  
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
 */
//left rotate the array by one place
/*
 namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 2, 1, 5, 2 };
            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = temp;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
 */
//left rotate the array by D place (brut force)
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1,2,3,4,5 };
            int d = 7%arr.Length;
            int[] temp = new int[d];
            //srep-1 creating a temp d array
            for (int i = 0; i < d; i++)
            {
                temp[i] = arr[i];
            }
            //step-2 shifting the remainging elements to frount 
            for (int i = 0; i < arr.Length-d; i++)
            {
                arr[i] = arr[d+i]; 
            }
            //step-3 inserting temp to the array 
            for (int i = arr.Length-d; i < arr.Length; i++)
            {
                arr[i] = temp[i - (arr.Length - d)];
            }
            foreach (int item in arr)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
    }
}*/
//left rotate the array by one place(optimal solution)
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int n = nums.Length;
            int k = 3;
            k %= n;
            Array.Reverse(nums,0,n);
            Array.Reverse(nums, 0,k);
            Array.Reverse(nums, k, n-k);
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}*/

//string plaindrom
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            string s = "A man, a plan, a canal: Panama";
            s = s.ToLower();
            
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c)) // only allow letters and numbers
                {
                    sb.Append(c);
                }
            }
            string str = sb.ToString();
            
            char[] arr = str.ToCharArray();
            int n = arr.Length;
            Array.Reverse(arr);
            string reversed = new string(arr);
            Console.WriteLine();
            if (n==0)
            {
                Console.WriteLine("it is a palindrom ");
            }
            else if (str == reversed)
            {
                Console.WriteLine("it is a palindrom ");
            }
            else
            {
                Console.WriteLine("not");
            }
                      
            Console.ReadLine();
        }
    }
}*/

/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {

            int a = 0 ,b = 1,c = 0;
            int n = 0;
            if (n==0)
            {
                c = 0;
            }
            else if (n==1)
            {
                c = 1;
            }
            else if(n>1)
            {
                for (int i = 1; i < n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            
            Console.WriteLine($"{n}th Fibonacci number is {c}");
            Console.ReadLine();
        }
    }
}*/
//moving zeros to the right(my solution brut force)
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 0, 2, 3, 2, 0, 0, 4, 5, 1 };
            List<int> temp = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!=0)
                {
                    temp.Add(arr[i]);
                }
            }
            for (int i = 0; i < temp.Count; i++)
            {
                arr[i] = temp[i];
            }
            for (int i = temp.Count; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            foreach (int item in arr)
            {
                Console.Write(item+ " ");
            }
            Console.ReadLine();
        }
    }
}*/

//optimal solution
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 0, 2, 3, 2, 0, 0, 4, 5, 1 };
            int j = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==0)
                {
                    j = i;
                    break;
                }
            }
            for (int i = j+1; i < arr.Length; i++)
            {
                if (arr[i]!=0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }
            foreach (int item in arr)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
    }
}*/

//linear search
//if the array contains same multiple elements it gets only the first apeared element 
/*namespace DSA_practice
{
    public class search
    {
        public int m1(int[] arr,int num)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == num)
                {
                    return i;                  
                }

            }
            return -1;
        }
    }
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 0, 4, 5};
            int num=0;
            search s = new search();
            int ss=s.m1(arr, num);
            if (ss!=-1)
            {
                Console.WriteLine(num+" found at index "+ss);
            }
            else
            {
                Console.WriteLine(num+" not found");
            }
            Console.ReadLine();
        }
    }
}*/

//union of arrays (brout force)
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = { 1, 1, 2, 3, 4, 5 };
            int[] arr2 = { 2, 3, 4, 4, 5, 6 };
           
            SortedSet<int> temp = new SortedSet<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                temp.Add(arr1[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                temp.Add(arr2[i]);
            }
            int[] union =new int[temp.Count];
            int j = 0;
            foreach (int item in temp)
            {
                union[j] = item;
                j++;
                
            }
            foreach (int item in union)
            {
                Console.WriteLine(item+" ");
            }
            

            Console.ReadLine();
        }
    }
}
*/

//untin of sorted arrays (optimal solution-2 pointer )
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] a = { 1, 1, 2, 3, 4, 5 };
            int[] b = { 2, 3, 4, 4, 5, 6 };
            List<int> union = new List<int>();
            int n1 = a.Length;
            int n2 = b.Length;
            int i = 0;
            int j = 0;
            while (i<n1 && j<n2)
            {
                if (a[i]<=b[j])
                {
                    if (union.Count==0 || union[union.Count-1]!=a[i])
                    {
                        union.Add(a[i]);

                    }
                    i++;
                }
                else
                {
                    if (union.Count == 0 || union[union.Count - 1] != b[j])
                    {
                        union.Add(b[j]);

                    }
                    j++;
                }
            }
            while (j<n2)
            {
                if (union.Count == 0 || union[union.Count - 1] != b[j])
                {
                    union.Add(b[j]);

                }
                j++;
            }
            while (i < n1)
            {
                if (union.Count == 0 || union[union.Count - 1] != a[i])
                {
                    union.Add(a[i]);

                }
                i++;
            }
            foreach (int item in union)
            {
                Console.Write(item+" " );
            }
            Console.ReadLine();
        }
    }
}*/

//intersection two sorted arrays(brut force)
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] a = { 1, 2,2,3,3,4,5,6 };
            int[] b = { 2, 3, 3,5,6,6,7 };
            int n1 = a.Length;
            int n2 = b.Length;

            List<int> vis = new List<int>(n2);
            for (int i = 0; i < n2; i++)
            {
                vis.Add(0);
            }

            List<int> inter = new List<int>();

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    if (a[i]==b[j] && vis[j]==0)
                    {
                        inter.Add(a[i]);
                        vis[j]=1;
                        break;
                    }
                    if (b[j]>a[i])
                    {
                        break;
                    }
                }
            }
            foreach (int item in inter)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
    }
}*/

//intersection of two sored arrays (optimal solution-2 pointer)
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] a = { 1, 2, 2, 3, 3, 4, 5, 6 };
            int[] b = { 2, 3, 3, 5, 6, 6, 7 };
            int n1 = a.Length;
            int n2 = b.Length;
            int i = 0;
            int j = 0;
            List<int> inter = new List<int>();
            while (i<n1 && j<n2)
            {
                if (a[i]<b[j])
                {
                    i++;
                }
                else if (b[j]<a[i])
                {
                    j++; 

                }
                else
                {
                    inter.Add(a[i]);
                    i++;
                    j++;
                }
            }
            foreach (int item in inter)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
    }
}*/

//missing element in the arrray(brute force)
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr= { 1, 2, 4, 5 };
            int n = 5;
            int missing = 0;
            for (int i = 1; i <=n; i++)
            {
                int flag = 0;
                for (int j = 0; j < n-1; j++)
                {
                    if (arr[j]==i)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag==0)
                {
                    missing = i;
                    break;
                }
            }
            Console.WriteLine(missing);
            Console.ReadLine();
        }
    }
}*/

//missing element in the arrray(hashing -better solution)
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 4, 5 };
            int n = 5;
            int missing = 0;
            int[] hash = new int[n+1];
            
            for (int i = 0; i <arr.Length; i++)
            {
                hash[arr[i]] = 1;
            }
            for (int i = 1; i <=n; i++)
            {
                if (hash[i]==0)
                {
                    missing= i;
                    break;
                }
            }
            Console.WriteLine(missing);
            Console.ReadLine();
        }
    }
}*/


//missing element in the arrray(sum -optimal solution-1)
/*namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 4, 5 };
            int n = 5;
            int a = 0;

            int sum = (n * (n + 1)) / 2;
            for (int i = 0; i < arr.Length; i++)
            {
                a += arr[i];
            }
            Console.WriteLine(sum-a);
            Console.ReadLine();
        }
    }
}*/

//missing element in the arrray(XOR -optimal solution-2)
namespace DSA_practice
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3,0,1 };
            int n = arr.Length;
            int XOR1 = 0;
            int XOR2 = 0;
            Array.Sort(arr);
            for (int i = 0; i <=n; i++)
            {
                XOR1 = XOR1 ^ i;

            }
            for (int i = 0; i < arr.Length; i++)
            {
                XOR2 = XOR2 ^ arr[i];
            }
            int res = XOR1 ^ XOR2;
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
