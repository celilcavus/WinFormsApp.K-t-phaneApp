using System.Linq.Expressions;

namespace _02.DatabaseModel.Interface
{
    public interface ISearch<T> where T : class
    {
       List<T> Search(int id);
    }
}
