namespace _02.DatabaseModel.Interface
{
    public interface IDelete<T> where T : class
    {
        int Delete(T entity);
    }
}
