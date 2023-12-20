// See https://aka.ms/new-console-template for more information
// Паттерн Мост (Bridge)
// структурный паттерн, позволяющий определить
// две взаимодействующих иерархии классов,
// в которых можно заменять участников с любой
// стороны. Взаимодействие построено между
// абстрактными классами, вместо которых 
// подставляются различные реализации

// Плюс моста в том, что клиент работает с абстракциями
// не заботясь о их реализации, соответственно можно
// добавлять новые компоненты без изменения логики
// их взаимодействия (в клиенте)
using Bridge_1125;

namespace BridgeSample;

class Program
{
    public static void Main()
    {
        Client client = new Client(new TableMetalTop(), new TableWoodLegs());
        client.PrintTable();
        client.ChangeTableLegs(new TableMetalLegs());
        client.PrintTable();
        client.ChangeTableTop(new TableWoodTop());
        client.PrintTable();
    }
}

public class TableWoodTop : TableTop
{
    public override void Print()
    {
        Console.WriteLine("Деревянная столешница");
    }
}

public class TableMetalTop : TableTop
{
    public override void Print()
    {
        Console.WriteLine("Металическая столешница");
    }
}

public class TableWoodLegs : TableLegs
{
    public override void Print()
    {
        Console.WriteLine("Деревянные ножки");
    }
}

public class TableMetalLegs : TableLegs
{
    public override void Print()
    {
        Console.WriteLine("Металические ножки");
    }
}

public abstract class TableTop
{
    public TableLegs TableLegs { get; set; }

    public abstract void Print();
}

public abstract class TableLegs
{
    public abstract void Print();
}

public class Client
{
    private TableTop top;
    private TableLegs legs;

    public Client(TableTop top, TableLegs legs)
    {
        this.top = top;
        this.legs = legs;
    }

    public void PrintTable()
    { 
        top.TableLegs = legs;
        top.Print();
        top.TableLegs.Print();
    }

    public void ChangeTableTop(TableTop top)
    {
        this.top = top;
        top.TableLegs = this.legs;
    }

    public void ChangeTableLegs(TableLegs legs)
    {
        this.legs = legs;
        top.TableLegs = legs;
    }
}