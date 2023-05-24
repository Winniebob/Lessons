// Напишите программу которая принимает на вход координаты точки (X и Y ) причем X!= 0 Y!=0 и выдает номер четверти плоскости в которой она находится

Console.WriteLine("Введите координаты X ");
int xCooridnate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());


int quarter = Quater(xCooridnate,yCoordinate ); // отработав метод возвращает  в пременную int  quarter

string result = quarter >0 ? $"Указанные координаты соответствуют четверти -> {quarter}" : "Введены некорректные координаты";

Console.WriteLine(result);

int Quater (int x, int y )
{
    
    if ( x>0 && y>0) return 1;
    if ( x<0 && y>0) return 2;
    if ( x<0 && y<0) return 3;  // Else не добавляется потому что, мы идем по циклу вниз и доходя до нужного нам if, выходим из метода с помощью return;
    if ( x>0 && y<0) return 4;
    
    return 0;
}