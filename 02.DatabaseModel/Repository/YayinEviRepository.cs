using _01.DatabasebEntity.Entity;
using _02.DatabaseModel.DbContext;
using _02.DatabaseModel.Interface;
using Dapper;
namespace _02.DatabaseModel.Repository
{
    public class YayinEviRepository : IAdd<YayinEvi>,IUpdate<YayinEvi>
        ,IDelete<YayinEvi>,IToList<YayinEvi>
    {
        public int Add(YayinEvi entity)
        {
            return MyDbContext.connection.Execute($"insert into {TableName.YayinEvi} (YayinEviAdi) values ('{entity.YayinEviAdi}')");
        }

        public int Delete(YayinEvi entity)
        {
            return MyDbContext.connection.Execute($"delete from {TableName.YayinEvi} where id = {entity.Id}");
        }

        public List<YayinEvi> List()
        {
            return MyDbContext.connection.Query<YayinEvi>($"Select * from {TableName.YayinEvi}").ToList();
        }

        public int Update(YayinEvi entity)
        {
            return MyDbContext.connection.Execute($"update {TableName.YayinEvi} set YayinEviAdi ='{entity.YayinEviAdi}' where id = {entity.Id}");
        }
    }
}
