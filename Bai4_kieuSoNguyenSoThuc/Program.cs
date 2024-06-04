using System.Text;

namespace Bai4_kieuSoNguyenSoThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn chức năng bạn muốn thực hiện:");
            Console.WriteLine("1. Kiểm tra số Palindrome (số nguyên không dấu kích thước 8 byte)");
            Console.WriteLine("2. Tính tổng của mảng số nguyên (số nguyên có dấu kích thước 8 byte)");
            Console.Write("Lựa chọn của bạn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Nhập và kiểm tra số Palindrome
                    Console.WriteLine("Vui lòng nhập một số nguyên không dấu kích thước 8 byte (ulong):");
                    ulong number = ulong.Parse(Console.ReadLine());

                    bool isPalindrome = IsPalindrome(number);

                    if (isPalindrome)
                    {
                        Console.WriteLine($"Số {number} là số Palindrome.");
                    }
                    else
                    {
                        Console.WriteLine($"Số {number} không phải là số Palindrome.");
                    }
                    break;

                case 2:
                    // Nhập và tính tổng của mảng số nguyên có dấu
                    Console.WriteLine("Vui lòng nhập số phần tử của mảng (số nguyên có dấu kích thước 8 byte):");
                    int size = int.Parse(Console.ReadLine());
                    long[] numbers = new long[size];

                    Console.WriteLine("Vui lòng nhập các phần tử của mảng (mỗi phần tử trên một dòng):");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Phần tử thứ {i + 1}: ");
                        numbers[i] = long.Parse(Console.ReadLine());
                    }

                    long sum = 0;
                    for (int i = 0; i < size; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine($"Tổng của các số trong mảng là: {sum}");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        // Phương thức để kiểm tra số Palindrome
        public static bool IsPalindrome(ulong number)
        {
            string str = number.ToString();
            int len = str.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
