using System.Linq.Expressions;

namespace _02.DatabaseModel.Interface
{
    public interface IExpressionSearch<T> where T : class
    {
        List<T> IExpressionSearch(Expression<Func<T, bool>> expression);
       
    }
}
