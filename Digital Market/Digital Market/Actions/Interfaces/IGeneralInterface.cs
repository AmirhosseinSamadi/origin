namespace Digital_Market.Actions.Interfaces
{
    public interface IGeneralInterface<T>
    {
        void Add(T item);
        void Remove(T item);
        void Edit(T item);
    }
}
