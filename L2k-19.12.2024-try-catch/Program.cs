Console.WriteLine(1.0 / 0.0);
var a = 3;
//var b = 3 - 3;
//Console.WriteLine(a / b);
//Console.WriteLine("Конец");

Person p = new Person();
while (true)
{
    try
    {
        p.Age = int.Parse(Console.ReadLine());
        Console.WriteLine(p.Age);
        break;
    }
    catch (AgeException e)
    {
        Console.WriteLine(e.Message + " Повторите ввод");
    }
    catch (FormatException)
    {
        Console.WriteLine("Введено не целое число! Повторите ввод");
    }
    catch
    {
        Console.WriteLine("Что-то пошло не так :(");
    }
    finally
    {
        Console.WriteLine("------");
    }
}
class Person
{
    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            var f = new FileStream("somefile.txt", FileMode.CreateNew);
            try
            {
                if (value >= 0)
                {
                    _age = value;
                    f.Write(new byte[] { 23 });
                }
                else throw new AgeException(value);
            }
            finally
            {
                f.Close();
            }

        }
    }
}

class AgeException : Exception
{
    private int _incorrectAgeValue;
    public AgeException(int age) : 
        base($"Значение {age} является некорректным. " +
              "Укажите положительное число")
    {
        _incorrectAgeValue = age;
    }

}