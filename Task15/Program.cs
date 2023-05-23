Console.WriteLine("Введите день недели");
int weekDay = Convert.ToInt32(Console.ReadLine());

if (ValldateWeekend(weekDay))
{   
    if (IsWeekend(weekDay))
       {
    Console.WriteLine("Выходной!");
       }
    else 
    {
    Console.WriteLine("Arbaiten match frai!!"); 
    }
}



bool IsWeekend(int weekDay)
{
    if (weekDay>5)
    {
       return true;
    }
   return false;
}

bool ValldateWeekend (int weekDay)
{
    if ( weekDay >0 && weekDay<=7)
    {
       return true;
    }
    
        Console.WriteLine("Это не день недели!");
        return false;

}

