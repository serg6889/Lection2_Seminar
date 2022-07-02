// See https://aka.ms/new-console-template for more information
void printRangeXY(float PlaneNum)
{
    if (PlaneNum == 1) 
    {
        System.Console.WriteLine("Х положительный");
        System.Console.WriteLine("Y положительный");
    }
        
    else if (PlaneNum == 2)
    {
        System.Console.WriteLine("Х отрицательный");
        System.Console.WriteLine("Y положительный");
    }
        
    else if (PlaneNum == 3)
    {
        System.Console.WriteLine("Х отрицательный");
        System.Console.WriteLine("Y отрицательный");
    }
       
    else if (PlaneNum == 4)
    {
        System.Console.WriteLine("Х положительный");
        System.Console.WriteLine("Y отрицательный");
        
    }
        
    else 
    System.Console.WriteLine("Некорректный ввод данных");
}
printRangeXY (1);
