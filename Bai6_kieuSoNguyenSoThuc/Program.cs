using System.Text;

namespace Bai6_kieuSoNguyenSoThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Tính trung bình cộng trong mảng số thực kích thước 8byte");
            Console.WriteLine("1. Tìm min max trong mảng số thực kích thước 8byte");
            Console.Write("Nhập lựa chọn: ");
            int choice = int.Parse(Console.ReadLine()); 
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Nhập số phần tử của mảng: ");
                    int size = int.Parse(Console.ReadLine());
                    double[] doubleArray = new double[size];
                    for(int i = 0; i < size; i++)
                    {
                        Console.WriteLine($"Nhập phần tử thứ {i+1}: ");
                        doubleArray[i] = double.Parse(Console.ReadLine());
                    }
                    double average = 0;
                    double sum = 0;
                    for(int i = 0; i < size; i++)
                    {
                        sum += doubleArray[i];
                        average = sum / size;
                    }
                    Console.WriteLine("trung bình cộng các phần tử trong mảng là: " + average);
                    break;
                case 2:
                    Console.WriteLine("Nhập kích thước của mảng: ");
                    int size1 = int.Parse(Console.ReadLine());
                    double[] double1Array = new double[size1];
                    for(int i = 0; i < size1; i++)
                    {
                        Console.WriteLine($"Nhập phần tử thứ {i + 1}: ");
                        double1Array[i] = double.Parse(Console.ReadLine());
                    }
                    double min = double1Array[0];
                    double max = double1Array[0];
                    for(int i = 0; i < size1; i++)
                    {
                        if(double1Array[i] < min ) min = double1Array[i];
                        if(double1Array[i] > max ) max = double1Array[i];
                    }
                    Console.WriteLine("Giá trị nhỏ nhất trong mảng là: " + min);
                    Console.WriteLine("Giá trị lớn nhất trong mảng là: " + max);
                    break;

            }
        }
    }
}
