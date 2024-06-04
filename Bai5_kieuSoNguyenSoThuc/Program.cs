using System.Text;

namespace Bai5_kieuSoNguyenSoThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Tìm min max trong mảng số thực kích thước 4byte");
            Console.WriteLine("2. Tính tổng các số trong mảng số thực kích thước 4bytes");
            int choice = int.Parse(Console.ReadLine()); 
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Nhập số phần tử của mảng số thực có kích thước 4byte: ");
                    int size = int.Parse(Console.ReadLine());
                    float[] floatArray1 = new float[size];
                    for(int i = 0; i<size; i++)
                    {
                        Console.WriteLine($"Nhập phần tử thứ {i + 1}: ");
                        floatArray1[i] =  float.Parse(Console.ReadLine());
                    }
                    float min = floatArray1[0];
                    float max = floatArray1[1];
                    for(int i = 0; i<size; i++)
                    {
                        if (floatArray1[i] < min)
                        {
                            min = floatArray1[i];
                        }
                        if (floatArray1[i] > max)
                        {
                            max = floatArray1[i];
                        }
                    }
                    Console.WriteLine("phần tử nhỏ nhất của mảng là: " + min);
                    Console.WriteLine("phần tử lớn nhất của mảng là: " + max);
                    break;
                case 2:
                    Console.WriteLine("nhập phần tử của mảng: ");
                    int size1 = int.Parse(Console.ReadLine());
                    float[] floatArray2 = new float[size1];
                    for(int i = 0; i < size1; i++)
                    {
                        Console.WriteLine($"nhập phần tử thứ {i+1}: ");
                        floatArray2[i] = float.Parse(Console.ReadLine());
                    }
                    float sum = 0;
                    for(int i = 0; i<size1; i++)
                    {
                        sum += floatArray2[i];
                    }
                    Console.WriteLine("tổng các phần tử trong mảng là: " + sum);
                    break;
                
            }
        }
    }
}
