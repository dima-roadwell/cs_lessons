// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.Write("Input Quarter: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] quarterArr = {"x > 0, y > 0", 
                        "x < 0, y > 0", 
                        "x < 0, y < 0", 
                        "x > 0, y < 0"
                        };

System.Console.WriteLine(quarterArr[num - 1]);