using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Models;

namespace ServiceLibrary
{
    public class DataService : IDataService
    {
        DBOperations db = new DBOperations();

        public List<MDataPublish> GetDataPublishes()
        {
            return db.GetPublishData();
        }

        public bool InsertSensorData(MDataPublish dataPublish)
        {
            return db.InsertSensorData(dataPublish);
        }
    }
}
