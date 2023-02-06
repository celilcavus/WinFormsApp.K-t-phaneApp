namespace _02.DatabaseModel.Interface
{
    public interface IUpdate<T> where T : class
    {
        int Update(T entity);
    }
}
