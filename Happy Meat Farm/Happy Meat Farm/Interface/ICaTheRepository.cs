using System;
using Happy_Meat_Farm.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Happy_Meat_Farm.Interface
{
    public interface ICaTheRepository
    {
        List<CaThe> GetAllCaThe();
    }
}

