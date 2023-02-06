namespace _02.DatabaseModel.Interface
{
    public interface IAdd<T> where T : class
    {
        int Add(T entity);
    }
}
