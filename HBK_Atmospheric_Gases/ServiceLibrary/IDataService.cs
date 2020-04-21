using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace ServiceLibrary
{
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        List<MDataPublish> GetDataPublishes();

        [OperationContract]
        bool InsertSensorData(MDataPublish dataPublish);
    }
}
