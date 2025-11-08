using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Level-0 Snippets Runner");
        Console.WriteLine("[1] Snippet 1");
        Console.WriteLine("[2] Snippet 2");
        Console.WriteLine("[3] Snippet 3");
        Console.Write("Enter choice: ");
        var key = Console.ReadKey();
        Console.WriteLine();

        switch (key.KeyChar)
        {
            case '1':
                RunSnippet1();
                break;
            case '2':
                RunSnippet2();
                break;
            case '3':
                RunSnippet3();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }

    // ---- Snippet 1 ----
    static void RunSnippet1()
    {
        int a = 3;
        int b = a++;
        Console.WriteLine($"a is {+a++}, b is {-++b}");

        int c = 3;
        int d = ++c;
        Console.WriteLine($"c is {-c--}, d is {~d}");
    }

    // ---- Snippet 2 ----
    class P2
    {
        public int age;
        public P2() => age = (age == 0) ? age + 1 : age - 1;
    }
    static void RunSnippet2()
    {
        int k = "010%".Replace('0', '%').Length;
        Console.Write("[" + (k << ++new P2().age).ToString() + "]");
        Console.Write("[" + "010%".Split('1')[1][0] + "]");
        Console.Write("[" + "010%".Split('0')[1][0] + "]");
        Console.Write("[" + int.Parse(Convert.ToString("123".ToCharArray()[~-1])) + "]");
    }

    // ---- Snippet 3 ----
    static void RunSnippet3()
    {
        int[] nums = { 0, 1, 0, 3, 12 };
        int pos = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[pos];
                nums[pos] = nums[i];
                nums[i] = temp;
                pos++;
            }
        }
        Console.WriteLine(string.Join(", ", nums));
    }
}
