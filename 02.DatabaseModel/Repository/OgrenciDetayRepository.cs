using _01.DatabasebEntity.View;
using _02.DatabaseModel.DbContext;
using _02.DatabaseModel.Interface;
using System.Linq.Expressions;
using Dapper;
namespace _02.DatabaseModel.Repository
{
    public class OgrenciDetayRepository : ISearch<ViewOgrenciDetaylari>
    {
        public List<ViewOgrenciDetaylari> Search(int id)
        {
            return MyDbContext.connection.Query<ViewOgrenciDetaylari>(@$"select 
            ogr.Id,
            ogr.OgrenciAdi,
            ogr.OgrenciSoyadi,
            COUNT(kt.KitapId) as KitapId
            from Ogrenci as ogr
            inner join  KitapHareket as kt on kt.OgrenciId = ogr.Id
            where kt.OgrenciId = {id}
            group by ogr.Id,ogr.OgrenciAdi,ogr.OgrenciSoyadi,kt.KitapId").ToList()!;
        }
        public List<ViewOgrenciDetaylari> getId(int id)
        {
            return MyDbContext.connection.Query<ViewOgrenciDetaylari>(@$"select * from {TableName.Ogrenci} where id = {id}").ToList()!;
        }
    }
}
