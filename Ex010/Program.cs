
Console.WriteLine("Программа для нахождения вторую цифру трёх значного числа \n");
char rest;
do{
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
Console.Write("Вторая цифра: ");
Console.WriteLine(str[1]);
Console.Write("Для продолжения введите y, для завершения любая клавиша: ");
rest = Convert.ToChar(Console.ReadLine());
}
while (rest =='y');
