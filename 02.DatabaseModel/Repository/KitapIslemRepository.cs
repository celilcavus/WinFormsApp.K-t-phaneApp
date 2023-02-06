using _01.DatabasebEntity.Entity;
using _01.DatabasebEntity.View;
using _02.DatabaseModel.DbContext;
using _02.DatabaseModel.Interface;
using Dapper;

namespace _02.DatabaseModel.Repository
{
    public class KitapIslemRepository : IAdd<Kitap>, IUpdate<Kitap>, IDelete<Kitap>, IToList<Kitap>
    {
        
        public int Add(Kitap entity)
        {
            return MyDbContext.connection.Execute($"Insert into {TableName.Kitap} (KitapAdi,KitapSayfasi,KitapYayinEviId,KitapYazarId) values ('{entity.KitapAdi}',{entity.KitapSayfasi},{entity.KitapYayinEviId},{entity.KitapYazarId})");
        }

        public int Delete(Kitap entity)
        {
            return MyDbContext.connection.Execute($"Delete from {TableName.Kitap} where Id = {entity.Id}");
        }

        public List<Kitap> List()
        {
            return MyDbContext.connection.Query<Kitap>($"Select * from {TableName.Kitap}").ToList();
        }

        public int Update(Kitap entity)
        {
            return MyDbContext.connection.Execute($"Update {TableName.Kitap} set KitapAdi = '{entity.KitapAdi}',KitapSayfasi ='{entity.KitapSayfasi}', KitapYayinEviId = {entity.KitapYayinEviId},KitapYazarId = {entity.KitapYazarId} where id = {entity.Id}");
        }

        public  List<ViewKitap> getViewList()
        {
            return MyDbContext.connection.Query<ViewKitap>($@"select * from {ViewName.ViewKitap}").ToList();
        }
    }
}
//select
//            kt.Id,
//            kt.KitapAdi,
//            kt.KitapSayfasi,
//            yayin.YayinEviAdi,
//            y.YazarAdi
//            from { TableName.Kitap} as kt
//            inner join { TableName.YayinEvi } as yayin on yayin.Id = kt.KitapYayinEviId
//            inner join { TableName.Yazar} as y on y.Id = kt.KitapYazarId