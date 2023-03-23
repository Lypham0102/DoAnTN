using Happy_Meat_Farm.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Data;

namespace Happy_Meat_Farm.Interface
{
    public interface ICaThe
    {
        IMongoCollection<CaThe> cathecollection { get; }
        IEnumerable<CaThe> GetAllCaThe();
        CaThe GetCaTheDetails(string Name);

        void Create(CaThe catheData);
        void Update(string _id, CaThe catheData);
        void Delete(string Name);
        
    }
}
