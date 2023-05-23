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
		IMongoCollection<ThucAn> ThucAnCollection { get; }
        IEnumerable<ThucAn> GetAllThucAn();
        ThucAn GetThucAnDetails(string Name);
        void Create(ThucAn thucAnData);
        void Update(string _id, ThucAn thucAnData);
        void Delete(string Name);
    }
}

