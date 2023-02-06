using _01.DatabasebEntity.Entity;
using _02.DatabaseModel.DbContext;
using _02.DatabaseModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Linq.Expressions;

namespace _02.DatabaseModel.Repository
{
    public class OgrenciRepository : IAdd<Ogrenci>, IUpdate<Ogrenci>, IDelete<Ogrenci>, IToList<Ogrenci>
    {

        public int Add(Ogrenci entity)
        {
          return  MyDbContext.connection.Execute($"Insert into {TableName.Ogrenci} (OgrenciAdi,OgrenciSoyadi,OgrenciTelefon,OgrenciTc,OgrenciCinsiyet) values ('{entity.OgrenciAdi}',  '{entity.OgrenciSoyadi}', '{entity.OgrenciTelefon}',  '{entity.OgrenciTc}',  '{entity.OgrenciCinsiyet}')");
        }

        public int Delete(Ogrenci entity)
        {
           return MyDbContext.connection.Execute($"Delete from {TableName.Ogrenci} where Id = {entity.Id}");
        }

        public List<Ogrenci> List()
        {

            return MyDbContext.connection.Query<Ogrenci>($"select * from {TableName.Ogrenci}").ToList();
        }
        public int Update(Ogrenci entity)
        {
            return MyDbContext.connection.Execute($"Update {TableName.Ogrenci} set OgrenciAdi = '{entity.OgrenciAdi}',OgrenciSoyadi = '{entity.OgrenciSoyadi}',OgrenciTelefon = '{entity.OgrenciTelefon}',OgrenciTc = '{entity.OgrenciTc}',OgrenciCinsiyet = '{entity.OgrenciCinsiyet}' where Id = {entity.Id}");
        }
    }
}
