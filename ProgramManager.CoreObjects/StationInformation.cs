using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;

namespace ProgramManager.CoreObjects
{
    [DataContract]
    public class StationInformation
    {
        [DataMember]
        public DateTime LastModified { get; set; }
        [DataMember]
        public string AuthorOfChanges { get; set; }
    }
}
