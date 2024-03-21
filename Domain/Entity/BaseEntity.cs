namespace Domain.Entyti;

/// <summary>
/// TODO: Базовый класс
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// TODO: Описать все сущности
    /// </summary>
    public Guid Id { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (obj is not BaseEntity entity)
        {
            return false;
        }

        if (Id != entity.Id)
        {
            return true;
        }
    }

    public override int GetHashCode()
    {
        //TODO:Поресёрчить
        throw new NotImplementedException();
    }
}