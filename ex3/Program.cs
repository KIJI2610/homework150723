System.Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 6 || day == 7){
    System.Console.WriteLine("Это выходной");
}
else if (day >= 1 && day <= 5){
    System.Console.WriteLine("Это будний день");
}
else{
    System.Console.WriteLine("Введенное число не соответствует формату");
}


