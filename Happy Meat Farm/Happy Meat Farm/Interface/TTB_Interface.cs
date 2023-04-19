using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Interface
{
	public interface TTB_Interface
	{
		IMongoCollection<TTBModel>TrangThietBiCollection { get; }
        IEnumerable<TTBModel> GetAllTrangThietBi();
        TTBModel GetTrangThietBiDetails(string Name);
        void Create(TTBModel TrangThietBiData);
        void Update(string _id, TTBModel TrangThietBiData);
        void Delete(string Name);

    }
}

