using System;
using System.Runtime.Serialization;

namespace DomainModel
{
    [DataContract]
    public class Human
    {
        [DataMember]
        public Int32 Id { get; set; }
        [DataMember]
        public Int32 Age { get; set; }
        [DataMember]
        public String Sex { get; set; }
        [DataMember]
        public String Name { get; set; }
    }
}
