using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    [DataContract]
    public class MSensors
    {
        [DataMember]
        public int SensorId { get; set; }
        [DataMember]
        public string SensorName { get; set; }
    }
}
