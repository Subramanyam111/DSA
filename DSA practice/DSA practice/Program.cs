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


namespace DSA_practice
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


}

