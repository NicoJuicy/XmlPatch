// Any comments, input: @KevinDockx
// Any issues, requests: https://github.com/KevinDockx/XmlPatch
//
// Enjoy :-)

using Mvc.XmlPatch.Adapters;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Mvc.XmlPatch.Operations
{
    [DataContract(Name = "OperationTest", Namespace = "", IsReference = false)]
    [XmlRoot(ElementName = "OperationTest", IsNullable = false, Namespace = "")]
    public class Operation<T> : Operation where T : class
    {   
        public Operation()
        {
        }

        public Operation(string op, string path, string from, object value)
            : base(op, path, from)
        {
            this.value = value;
        }

        public Operation(string op, string path, string from)
            : base(op, path, from)
        {
        } 

        internal void Apply(T objectToApplyTo, IObjectAdapter<T> adapter)
        {
            switch (OperationType)
            {
                case OperationType.Add:
                    adapter.Add(this, objectToApplyTo);
                    break;
                case OperationType.Remove:
                    adapter.Remove(this, objectToApplyTo);
                    break;
                case OperationType.Replace:
                    adapter.Replace(this, objectToApplyTo);
                    break;
                case OperationType.Move:
                    adapter.Move(this, objectToApplyTo);
                    break;
                case OperationType.Copy:
                    adapter.Copy(this, objectToApplyTo);
                    break;
                case OperationType.Test:
                    throw new NotImplementedException("Test is currently not implemented.");   
                default:
                    break;
            }
        }
    }
}
