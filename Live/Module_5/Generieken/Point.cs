namespace Generieken;

public struct Point<T> where T: struct
{
    public T X { get; set; }
    public T Y { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
