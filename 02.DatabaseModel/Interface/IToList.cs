namespace _02.DatabaseModel.Interface
{
    public interface IToList<T> where T : class
    {
        List<T> List();
    }
}
