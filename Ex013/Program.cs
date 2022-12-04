Console.WriteLine("Программа для нахождения вторую цифру трёх значного числа \n");
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numDig = NumberDigit(number);

if (numDig<=2)
{
  Console.Write("Третьей цифры нет,"); 
   
}
else{
if (numDig>3)
{
    number = number/Convert.ToInt32(Math.Pow(10,numDig-3));
}
number = number %10;
 Console.WriteLine($"Третья цифра введённого числа: {number}");
}


int NumberDigit(int number){
int count = 0;
while (number>0)
{
    number=number/10;
    count ++;
}
 return count;
}
   



