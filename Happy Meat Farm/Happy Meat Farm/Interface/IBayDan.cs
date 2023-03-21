using Happy_Meat_Farm.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Data;

namespace Happy_Meat_Farm.Interface
{
    public interface IBayDan
    {
        IMongoCollection<BayDan> BayDancollection { get; }
        IEnumerable<BayDan> GetAllBayDan();
        BayDan GetBayDanDetails(string Name);

        void Create(BayDan BayDanData);
        void Update(string _id, BayDan BayDanData);
        

    }
}

