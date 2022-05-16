namespace Fuck;

interface IFuck
{
    // 接口成员
    void Fuck();
}

class FuckImpl : IFuck
{ 
    public void Fuck()
    {
        Console.WriteLine("fuck");
    }
}