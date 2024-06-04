using System.Formats.Asn1;
using System.Text;

namespace SoNguyen4byte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(" LỰA CHỌN ");
            Console.WriteLine("1. Tính toán số nguyên 4byte");
            Console.WriteLine("2. Tính tổng các chữ số của số nguyên 4byte");
            Console.WriteLine("3. Đảo ngược chữ số của số nguyên không dấu 4byte");
            Console.WriteLine("Nhập lựa chọn (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int a, b;
                    while (true) 
                    {
                        try
                        {
                            Console.WriteLine("nhập số nguyên a: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("nhập số nguyên b: ");
                            b = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("số bạn nhập không hợp lệ. Vui lòng nhập lại ");
                        }
                    }  
                    int sum = a + b;
                    int difference = a - b;
                    int product = a * b;
                    int quotient = a / b;
                    Console.WriteLine("tổng: " + sum);
                    Console.WriteLine("hiệu: " + difference);
                    Console.WriteLine("tích: " + product);
                    Console.WriteLine("thương nguyên: " +  quotient);
                    break;
                case 2:
                    Console.WriteLine("nhập số lượng phần tử trong mảng: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] array = new int[n];
                    int arraySum = 0;
                    for(int i = 0; i<n; i++)
                    {
                        Console.WriteLine($"nhập phần tử thứ {i + 1}: ");
                        array[i] = Convert.ToInt32(Console.ReadLine());
                        arraySum += array[i];
                    }
                    Console.WriteLine("Tổng các chữ số là: " + arraySum);
                    break;
                case 3:
                    uint number;
                    while (true) {
                        try
                        {
                            Console.WriteLine("nhập số nguyên không dấu 4byte: ");
                            number = Convert.ToUInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("số bạn nhập không hợp lệ. Vui long nhập lại");
                        }
                    }                   
                    uint reverseNumber = 0;
                    while( number > 0)
                    {
                        uint digit = number % 10;
                        reverseNumber = reverseNumber * 10 + digit;
                        number /= 10;
                    }
                    Console.WriteLine("số đã đảo ngược là: " + reverseNumber);
                    break;
            }
        }
    }
}
