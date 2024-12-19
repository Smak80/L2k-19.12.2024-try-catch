Console.WriteLine(1.0 / 0.0);
var a = 3;
//var b = 3 - 3;
//Console.WriteLine(a / b);
//Console.WriteLine("Конец");

Person p = new Person();
while(true)
    try
    {
        p.Age = int.Parse(Console.ReadLine());
        Console.WriteLine(p.Age);
        break;
    } 
    catch
    {
        Console.WriteLine("Введен неверный возраст. Повторите ввод");
    }

class Person
{
    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            if (value >= 0) _age = value;
            else throw new Exception("Возраст должен быть положительной величиной");
        }
    }
}