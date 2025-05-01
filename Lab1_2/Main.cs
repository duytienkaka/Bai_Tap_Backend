using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Chon bai tap de chay (1-6, nhap 0 de thoat): ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 6)
            {
                Console.WriteLine("Lua chon khong hop le! Thoat chuong trinh.");
                break;
            }

            if (choice == 0)
            {
                Console.WriteLine("Thoat chuong trinh.");
                break;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Nhap so phan tu cua mang: ");
                    int n1 = int.Parse(Console.ReadLine() ?? "0");
                    int[] arr1 = new int[n1];
                    for (int i = 0; i < n1; i++)
                    {
                        Console.Write($"Nhap phan tu thu {i + 1}: ");
                        arr1[i] = int.Parse(Console.ReadLine() ?? "0");
                    }
                    Lab1_2.bai1(arr1);
                    break;
                case 2:
                    Lab1_2.bai2();
                    break;
                case 3:
                    Lab1_2.bai3();
                    break;
                case 4:
                    Lab1_2.bai4();
                    break;
                case 5:
                    Lab1_2.bai5();
                    break;
                case 6:
                    Lab1_2.bai6();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }
}