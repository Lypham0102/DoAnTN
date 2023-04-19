using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Interface
{
	public interface IThucAn
	{
		IMongoCollection<ThucAnModel> ThucAnCollection { get; }
        IEnumerable<ThucAnModel> GetAllThucAn();
        //ThucAnModel GetThucAnDetails(string Name);
        //void Create(ThucAnModel nhanvienData);
        //void Update(string _id, ThucAnModel thucAnData);
        //void Delete(string Name);
    }
}

