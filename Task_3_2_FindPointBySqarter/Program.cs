/* Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).*/


int GetQuarter(string message)
{ 
    int result  = 0;
    while (true){
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 5){
            if (result != 0){
                break;                
                }
        }
        else{
             Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
            }
        } 
    return result;
}
int quarter = GetQuarter("Введите номер четверти: ");

    if (quarter == 1){
        Console.WriteLine("x > 0 и y > 0");}
    else if (quarter == 2){
         Console.WriteLine("x < 0 и y > 0");}
    else if (quarter == 3){
         Console.WriteLine("x < 0 и y < 0");}
    else if (quarter == 4)
         {Console.WriteLine("x > 0 и y < 0");}




