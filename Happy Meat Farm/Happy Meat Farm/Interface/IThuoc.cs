using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Interface
{
	public interface IThuoc
	{
        IMongoCollection<ThuocModel> ThuocCollection { get; }
        IEnumerable<ThuocModel> GetAllThuoc();
        ThuocModel GetThuocDetails(string Name);
        void Create(ThuocModel ThuocData);
        void Update(string _id, ThuocModel ThuocData);
        void Delete(string Name);
    }
}

