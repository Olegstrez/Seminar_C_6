/* Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */
Console.WriteLine("Введите число или если хотите закончить введите Exit");
int count = 0;
for (var i = 0; i < i+1 ; i ++)
{
   string Number = Console.ReadLine();
   if (Number == "Exit") break;
   int Number1 = Convert.ToInt32(Number);
   if (Number1 > 0 ) count++;   
}
Console.WriteLine ("Колличество больше 0 = " + count);



