namespace ListProject
{
    interface IList<T>
    {
        void Add(T value);
        void Remove(T value);
        void Clear();
    }
}
