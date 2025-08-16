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


