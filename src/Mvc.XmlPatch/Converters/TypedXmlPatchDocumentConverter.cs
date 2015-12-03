// Any comments, input: @KevinDockx
// Any issues, requests: https://github.com/KevinDockx/XmlPatch
//
// Enjoy :-)

using Mvc.XmlPatch.Exceptions;
using Mvc.XmlPatch.Operations;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Mvc.XmlPatch.Converters
{
    public class TypedXmlPatchDocumentConverter // : XmlConverter
    {
        //override
        public  bool CanConvert(Type objectType)
        {
            return true;
        }

        //override
        public  object ReadXml(XmlReader reader, Type objectType, object existingValue, XmlSerializer serializer)
        {
            try
            {
                //if (reader.TokenType == JsonToken.Null)
                //    return null;

                Type genericType = objectType.GetGenericArguments()[0];

                // load jObject
                
               // JArray jObject = JArray.Load(reader);

                // Create target object for Json => list of operations, typed to genericType
                var genericOperation = typeof(Operation<>);
                var concreteOperationType = genericOperation.MakeGenericType(genericType);

                var genericList = typeof(List<>);
                var concreteList = genericList.MakeGenericType(concreteOperationType);

                var targetOperations = Activator.CreateInstance(concreteList);

                //Create a new reader for this jObject, and set all properties to match the original reader.
                //JsonReader jObjectReader = jObject.CreateReader();
                //jObjectReader.Culture = reader.Culture;
                //jObjectReader.DateParseHandling = reader.DateParseHandling;
                //jObjectReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
                //jObjectReader.FloatParseHandling = reader.FloatParseHandling;

                //// Populate the object properties
                //serializer.Populate(jObjectReader, targetOperations);

                //var serializer = new XmlSerializer(typeof(List<Operation>));
                targetOperations = serializer.Deserialize(reader);

                // container target: the typed XmlPatchDocument. 
                var container = Activator.CreateInstance(objectType, targetOperations);  

                return container;
            }
            catch (Exception ex)
            {
                throw new XmlPatchException(
                    new XmlPatchError(null, null, "The XmlPatchDocument was malformed and could not be parsed."), ex, 400);
            }             
        }

        //override
        public  void WriteXml(XmlWriter writer, object value, XmlSerializer serializer)
        {
            if (value is IXmlPatchDocument)
            {
                var XmlPatchDoc = (IXmlPatchDocument)value;
                var lst = XmlPatchDoc.GetOperations();
                 
                // write out the operations, no envelope
                serializer.Serialize(writer, lst);
            }
        }
    }
}
