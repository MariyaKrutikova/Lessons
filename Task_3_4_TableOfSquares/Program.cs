/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

int getNumber(string message){
    int result = 0;
    Console.WriteLine("Введите число: ");
    while(true){    
        if (int.TryParse(Console.ReadLine(), out result)){
            break;
        }
        else{
            Console.WriteLine("Введены некорректные данные. Повторите ввод!");
        }
    }
    return result;
}

int number = getNumber("Введите число: ");
for (int i=1; i <= number; i++){
    Console.Write(i*i + " ");
}



