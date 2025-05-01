using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Chon bai tap de chay (1-10, nhap 0 de thoat): ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 10)
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
                    Lab1.bai1();
                    break;
                case 2:
                    Lab1.bai2();
                    break;
                case 3:
                    Lab1.bai3();
                    break;
                case 4:
                    Lab1.bai4();
                    break;
                case 5:
                    Lab1.bai5();
                    break;
                case 6:
                    Lab1.bai6();
                    break;
                case 7:
                    Lab1.bai7();
                    break;
                case 8:
                    Lab1.bai8();
                    break;
                case 9:
                    Lab1.bai9();
                    break;
                case 10:
                    Lab1.bai10();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }
}