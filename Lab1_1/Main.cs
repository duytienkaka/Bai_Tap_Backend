using System;

class Program
{
    public static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Chon bai tap de thuc hien (1-10, nhap 0 de thoat): ");
            choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    Lab1_1.bai1();
                    break;
                case 2:
                    Lab1_1.bai2();
                    break;
                case 3:
                    Lab1_1.bai3();
                    break;
                case 4:
                    Lab1_1.bai4();
                    break;
                case 5:
                    Lab1_1.bai5();
                    break;
                case 6:
                    Lab1_1.bai6();
                    break;
                case 7:
                    Lab1_1.bai7();
                    break;
                case 8:
                    Lab1_1.bai8();
                    break;
                case 9:
                    Lab1_1.bai9();
                    break;
                case 10:
                    Lab1_1.bai10();
                    break;
                case 0:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        } while (choice != 0);
    }
}