// Any comments, input: @KevinDockx
// Any issues, requests: https://github.com/KevinDockx/XmlPatch
//
// Enjoy :-)

using System.Xml.Serialization;
using System;

namespace Mvc.XmlPatch.Operations
{
    [XmlRoot(Namespace="")]
    public class Operation
    {
        [XmlIgnore]
        public OperationType OperationType
        {
            get
            {
                return (OperationType)Enum.Parse(typeof(OperationType), op, true);
            }
        }
        [XmlElement("value")]
        public object value { get; set; }

        [XmlElement("path")]
        public string path { get; set; }

        [XmlElement("op")]
        public string op { get; set; }

        [XmlElement("from")]
        public string from { get; set; }
        
        public Operation()
        {
        }

        public Operation(string op, string path, string from)
        {
            this.op = op;
            this.path = path;
            this.from = from;
        }
     
         public Operation(string op, string path, string from, object value)
             : this(op, path, from)
         {
             this.value = value;
         } 

        public bool ShouldSerializefrom()
        {
            return (OperationType == Operations.OperationType.Move
                || OperationType == OperationType.Copy);
        }
        
        public bool ShouldSerializevalue()
        {
            return (OperationType == Operations.OperationType.Add
                || OperationType == OperationType.Replace
                || OperationType == OperationType.Test);
        }
    }
}
