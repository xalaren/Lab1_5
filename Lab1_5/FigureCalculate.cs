namespace Lab1_5
{
    public class FigureCalculate
    {
        //Проверка на существование треугольника
        //Правило существования: треугольник существует только тогда, когда сумма его двух сторон больше третьей
        //Иначе треугольник не существует
        public static bool GetTriangleExists(int a, int b, int c)
        {
            return a + b > c && b + c > a && a + c > b;
        }
    }
}