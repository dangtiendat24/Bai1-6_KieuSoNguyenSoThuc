using System.Text;

namespace Bai2_kieuSoNguyenSoThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            do
            {
                Console.WriteLine("Chọn chức năng:");
                Console.WriteLine("1. Tìm số lớn nhất và nhỏ nhất trong dãy số nguyên có dấu kích thước 1 byte");
                Console.WriteLine("2. Tính tổng các số chẵn trong dãy số nguyên có dấu kích thước 1 byte");
                Console.WriteLine("3. Tính tổng của các số từ 1 đến n");
                Console.WriteLine("4. Tính tổng các chữ số trong số nguyên không dấu kiểu byte");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        FindMinMax();
                        break;
                    case 2:
                        SumEven();
                        break;
                    case 3:
                        SumToN();
                        break;
                    case 4:
                        SumDigits();
                        break;
                    case 0:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 0);
            static void FindMinMax()
            {
                sbyte[] nums = new sbyte[100];
                int n;
                sbyte max, min;

                Console.Write("Nhập số lượng số nguyên: ");
                n = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhập {0} số nguyên:", n);
                for (int i = 0; i < n; i++)
                {
                    nums[i] = sbyte.Parse(Console.ReadLine());
                }

                max = sbyte.MinValue;
                min = sbyte.MaxValue;

                for (int i = 0; i < n; i++)
                {
                    if (nums[i] > max)
                    {
                        max = nums[i];
                    }
                    if (nums[i] < min)
                    {
                        min = nums[i];
                    }
                }

                Console.WriteLine("Số lớn nhất: {0}", max);
                Console.WriteLine("Số nhỏ nhất: {0}", min);
            }
            static void SumEven()
            {
                Console.Write("Nhập số lượng số nguyên: ");
                 int n = int.Parse(Console.ReadLine());
                sbyte[] nums = new sbyte[100];
                int sumEven = 0;

                for (int i = 0; i < n; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        sumEven += nums[i];
                    }
                }

                Console.WriteLine("Tổng các số chẵn: {0}", sumEven);
            }
            static void SumToN()
            {
                byte num;
                uint sum = 0;

                Console.Write("Nhập số nguyên không dấu: ");
                num = byte.Parse(Console.ReadLine());

                for (byte i = 1; i <= num; i++)
                {
                    sum += i;
                }

                Console.WriteLine("Tổng các số từ 1 đến {0} là: {1}", num, sum);
            }
            static void SumDigits()
            {
                byte numDigits;
                byte sumDigits = 0;

                Console.Write("Nhập số nguyên không dấu kiểu byte: ");
                numDigits = byte.Parse(Console.ReadLine());

                while (numDigits > 0)
                {
                    sumDigits += (byte)(numDigits % 10);
                    numDigits /= 10;
                }

                Console.WriteLine("Tổng các chữ số: {0}", sumDigits);
            }
        }
    }
}
