using _01.DatabasebEntity.View;
using _02.DatabaseModel.DbContext;
using _02.DatabaseModel.Interface;
using Dapper;

namespace _02.DatabaseModel.Repository
{
    public class KitapAraRepository:IToList<ViewKitapAra>
    {
        public List<ViewKitapAra> KitapAra(int id , string durum)
        {
            return MyDbContext.connection.Query<ViewKitapAra>(@$"select * from {ViewName.ViewKitapAra} where KitapId = {id} and durum = '{durum}'").ToList();
        }

        public List<ViewKitapAra> List()
        {
            return MyDbContext.connection.Query<ViewKitapAra>($"select * from {ViewName.ViewKitapAra}").ToList();
        }
    }
}
