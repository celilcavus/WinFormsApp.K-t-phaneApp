using _01.DatabasebEntity.Entity;
using _02.DatabaseModel.DbContext;
using _02.DatabaseModel.Interface;
using Dapper;

namespace _02.DatabaseModel.Repository
{
    public class YazarRepository :IAdd<Yazar>,IUpdate<Yazar>,IDelete<Yazar>, IToList<Yazar>
    {
        public int Add(Yazar entity)
        {
            return MyDbContext.connection.Execute($"insert into {TableName.Yazar} (yazarAdi,yazarSoyadi) values ('{entity.YazarAdi}','{entity.YazarSoyadi}')"); 
        }

        public int Delete(Yazar entity)
        {
            return MyDbContext.connection.Execute($"delete from {TableName.Yazar} where id = {entity.Id}");
        }

        public List<Yazar> List()
        {
            return MyDbContext.connection.Query<Yazar>($"Select * from {TableName.Yazar}").ToList();
        }

        public int Update(Yazar entity)
        {
            return MyDbContext.connection.Execute(@$"update {TableName.Yazar} 
            set yazarAdi = '{entity.YazarAdi}' ,
            yazarSoyadi ='{entity.YazarSoyadi}' where id = {entity.Id}");
        }
    }
}
