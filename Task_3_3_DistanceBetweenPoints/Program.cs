/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

int getPointCoordinates(string message){
    int result = 0;
    Console.WriteLine(message);
    while(true){
        if (int.TryParse(Console.ReadLine(), out result)){
            break;
        }
        else {
            Console.WriteLine("Введены некорректные данные. Повторите ввод!");
        }
    }
    return result;
}

int xA = getPointCoordinates("Введите координату х для точки А: ");
int yA = getPointCoordinates("Введите координату y для точки А: ");

int xB = getPointCoordinates("Введите координату х для точки B: ");
int yB = getPointCoordinates("Введите координату y для точки B: ");

double distanse = Math.Sqrt(Math.Pow(xA-xB,2)+Math.Pow(yA-yB,2));

Console.WriteLine($"Расстояние между точками А и В равно {distanse}");
