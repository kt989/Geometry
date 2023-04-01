
using Geometry;

Console.WriteLine("Выбери фигуру: треугольник - нажми 1, круг - нажми 2");
int Variable=Convert.ToInt32(Console.ReadLine());
double area;

if (Variable == 1)
{
    Console.WriteLine("Введите длины сторон через пробел: ");
    string Arr_storona=Console.ReadLine();
    char[] Array_Storona = Arr_storona.ToArray();
    double[] storona = new double[3];
    int i = 0;

    foreach (var item in Array_Storona)
    {
        if (item == ' ') continue;
        else storona[i++]=Convert.ToDouble(item);
    }
    Triangle obj1= new Triangle(storona[0], storona[1], storona[2]);
    area = obj1.get_Area();
    Console.WriteLine("Площадь треугольника равна " + area);

}
else
{
    Console.WriteLine("Введите радиусл: ");
    double radius = Convert.ToDouble(Console.ReadLine());
    Circle obj = new Circle(radius);
    area=obj.get_Area();
    Console.WriteLine("Площадь коуга равна " + area);
}
