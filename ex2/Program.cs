System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 100){
    string numSrt = num.ToString();
    char result = numSrt[2];
    System.Console.WriteLine(result);
}
else{
    System.Console.WriteLine("Нет третьей цифры");
}











// int nums = 32121;
// string numsStr = nums.ToString();
// char num = numsStr[2];
// System.Console.WriteLine(num);