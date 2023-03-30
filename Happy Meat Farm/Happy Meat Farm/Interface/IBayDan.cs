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
        IMongoCollection<BayDan> baydancollection { get; }
        IEnumerable<BayDan> GetAllBayDan();
        BayDan GetBayDanDetails(string Name);
        IEnumerable<CaThe> GetCaTheTheoBay(string Name);

        void Create(BayDan baydanData);
        void Update(string _id, BayDan baydanData);
        void Delete(string Name);
        //void Inf(string Name);
        //void Inf(string cathetheobayData);
    }
}

