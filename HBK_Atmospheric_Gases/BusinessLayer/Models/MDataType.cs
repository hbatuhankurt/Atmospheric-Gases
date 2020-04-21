using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    [DataContract]
    public class MDataType
    {
        [DataMember]
        public int DataId { get; set; }
        [DataMember]
        public string DataType { get; set; }
    }
}
