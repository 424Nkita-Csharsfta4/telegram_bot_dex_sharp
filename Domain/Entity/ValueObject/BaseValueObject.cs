namespace Domain.Entyti.ValueObject;

public abstract class BaseValueObject
{
    public override bool Equals(obect? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        throw new Exception();
    }
}