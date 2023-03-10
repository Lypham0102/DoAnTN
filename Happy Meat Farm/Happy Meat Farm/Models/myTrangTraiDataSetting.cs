using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Happy_Meat_Farm.Models
{
    public interface myTrangTraiDataSettings
    {
        string NhanVienCollectionName { get; set; }
        string ConnectionString { get; set; }
        string Databasename { get; set; }
    }
}
