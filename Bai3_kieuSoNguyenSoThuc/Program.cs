namespace Bai3_kieuSoNguyenSoThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chọn loại mảng bạn muốn nhập:");
            Console.WriteLine("1. Mảng số nguyên không dấu (ushort)");
            Console.WriteLine("2. Mảng số nguyên có dấu (short)");
            Console.Write("Lựa chọn của bạn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:                   
                    Console.WriteLine("Vui lòng nhập số phần tử của mảng (số nguyên không dấu kích thước 2 byte):");
                    int sizeUshort = int.Parse(Console.ReadLine());
                    ushort[] ushortArray = new ushort[sizeUshort];

                    Console.WriteLine("Vui lòng nhập các phần tử của mảng:");
                    for (int i = 0; i < sizeUshort; i++)
                    {
                        Console.Write($"Phần tử thứ {i + 1}: ");
                        ushortArray[i] = ushort.Parse(Console.ReadLine());
                    }

                    uint sumUshort = 0;
                    for (int i = 0; i < sizeUshort; i++)
                    {
                        sumUshort += ushortArray[i];
                    }

                    Console.WriteLine($"Tổng của các số trong mảng là: {sumUshort}");
                    break;

                case 2:
                    Console.WriteLine("Vui lòng nhập số phần tử của mảng (số nguyên có dấu kích thước 2 byte):");
                    int sizeShort = int.Parse(Console.ReadLine());
                    short[] shortArray = new short[sizeShort];

                    Console.WriteLine("Vui lòng nhập các phần tử của mảng:");
                    for (int i = 0; i < sizeShort; i++)
                    {
                        Console.Write($"Phần tử thứ {i + 1}: ");
                        shortArray[i] = short.Parse(Console.ReadLine());
                    }

                    int sumShort = 0;
                    for (int i = 0; i < sizeShort; i++)
                    {
                        sumShort += shortArray[i];
                    }

                    Console.WriteLine($"Tổng của các số trong mảng là: {sumShort}");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
