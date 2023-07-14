System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100 || num > 999){
System.Console.Write("Число не является трехзначным");
}   
else{
    num = num % 100;
    double numD = num / 10;
    Math.Floor(numD);
    System.Console.WriteLine(numD);
}



