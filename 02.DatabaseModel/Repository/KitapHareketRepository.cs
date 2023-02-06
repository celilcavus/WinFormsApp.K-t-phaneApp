using _01.DatabasebEntity.Entity;
using _01.DatabasebEntity.View;
using _02.DatabaseModel.DbContext;
using _02.DatabaseModel.Interface;
using Dapper;

namespace _02.DatabaseModel.Repository
{
    public class KitapHareketRepository : IAdd<KitapHareket>, IUpdate<KitapHareket>, IDelete<KitapHareket>, IToList<ViewKitapAra>
    {
        public int Add(KitapHareket entity)
        {
            var returnval = MyDbContext.connection.Execute(@$"insert into {TableName.KitapHareket} (KitapId,OgrenciId,KitapVerilisTarihi,KitapSonTeslimTarihi,durum) values 
                ({entity.KitapId},
                {entity.OgrenciId},
                '{entity.KitapVerilisTarihi.ToString("")}',
                '{entity.KitapSonTeslimTarihi.ToString("")}'),
                '{entity.durum}'");
            return returnval;
        }

        public int Delete(KitapHareket entity)
        {
            var returnval = MyDbContext.connection.Execute(@$"delete from {TableName.KitapHareket} where Id ={entity.Id}");
            return returnval;
        }

        public List<ViewKitapAra> List()
        {
            return MyDbContext.connection.Query<ViewKitapAra>($"select * from {ViewName.ViewKitapAra}").ToList();
        }

        public int Update(KitapHareket entity)
        {
            var returnval = MyDbContext.connection.Execute(@$" update {TableName.KitapHareket}  
            set KitapId = {entity.KitapId},
             OgrenciId ={entity.OgrenciId},
             KitapVerilisTarihi ='{entity.KitapVerilisTarihi.ToString()}',
             KitapSonTeslimTarihi ='{entity.KitapSonTeslimTarihi.ToString()}',
             durum = '{entity.durum}'
            where id = {entity.Id}");
            return returnval;
        }
    }
}
