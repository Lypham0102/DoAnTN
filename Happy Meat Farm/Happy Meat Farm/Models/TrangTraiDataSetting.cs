using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Happy_Meat_Farm.Models
{
    public class TrangTraiDataSetting : myTrangTraiDataSettings
    {
        public string NhanVienCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string Databasename { get; set; } = String.Empty;
    }
}
