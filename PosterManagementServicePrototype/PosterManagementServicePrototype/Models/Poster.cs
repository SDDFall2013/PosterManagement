using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PosterManagementServicePrototype.Models
{
    [DataContract]
    public partial class Poster
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public System.DateTime CreateDatetime { get; set; }
        [DataMember]
        public System.DateTime ModifyDatetime { get; set; }
    }
}
