using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace BusinessLayer
{
    public class DBOperations
    {
        HBK_Atmospheric_GasesEntities db;

        public DBOperations()
        {
            db = new HBK_Atmospheric_GasesEntities();
        }

        public List<MDataPublish> GetPublishData()
        {
            List<MDataPublish> List = new List<MDataPublish>();

            foreach (DataPublish data in db.DataPublishes.ToList())
            {
                List.Add(new MDataPublish()
                {
                    DataPublishId = data.DataPublishId,
                    DataId = (int)data.DataId,
                    SensorId = (int)data.SensorId,
                    DataValue = data.DataValue
                });
            }
            return List;
        }

        public bool InsertSensorData(MDataPublish dataPublish)
        {
            try
            {
                db.DataPublishes.Add(new DataPublish()
                {
                    SensorId = dataPublish.SensorId,
                    DataId = dataPublish.DataId,
                    DataValue = dataPublish.DataValue,
                    PublishTime = dataPublish.PublishDateTime                  
                });
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

    }
}
