using System;
using Happy_Meat_Farm.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Happy_Meat_Farm.Interface
{
    public interface INongTrai
    {
        IMongoCollection<NongTrai> nongtraicollection { get; }
        IEnumerable<NongTrai> GetAllNongTrai();

        NongTrai GetNongTraiDetails(string Name);
        void Create(NongTrai nongtraiData);
        void Update(string _id,NongTrai nongtraiData);
        void Delete(string Name);
    }
}

