// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }

// void OddsCheck(int number)
// {
//     if (number)
//     {
//         int[]myArr= ArrayInput(number);
//         ArrayPrint(myArr);
//         System.Console.Write($"Количество положительных чисел равно {PositiveNumber(myArr)} ");
        
//     }
//     else
//     {
//         System.Console.Write($"Количество не может быть отрицательным или равным нулю" );
//     }
// }
// int[] ArrayInput(int number) 
// {
//         int[] myArr = new int[number];
//         int i = 0;     
//         while (i < number) 
//         {
//         Console.Write("Введите число "); 
//         myArr[i] = int.Parse(Console.ReadLine());
//         i++;
//         }
//         return myArr;
// }   
// int PositiveNumber(int []myArr)
// {
//     int count =0;
//     for (int i = 0; i <myArr.Length; i++)
//     {
//       if(myArr[i]>0)  
//       {
//         count++;
//       }
//     }
//     return count;
// }
// void ArrayPrint(int[] myArr)                            
// {
//     for (int j = 0; j < myArr.Length; j++)
//     {
//     System.Console.Write($"{myArr[j]}  ");
//     }
// }

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());


var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);
Console.WriteLine($"Пересечение в точке: ({x};{y})");