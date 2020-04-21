using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    [DataContract]
    public class MDataPublish
    {
        [DataMember]
        public int DataPublishId { get; set; }
        [DataMember]
        public int SensorId { get; set; }
        [DataMember]
        public int DataId { get; set; }
        [DataMember]
        public string DataValue { get; set; }
        [DataMember]
        public DateTime PublishDateTime { get; set; }
    }
}
