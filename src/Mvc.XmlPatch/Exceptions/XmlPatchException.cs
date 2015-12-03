// Any comments, input: @KevinDockx
// Any issues, requests: https://github.com/KevinDockx/xmlPatch
//
// Enjoy :-)

using Mvc.XmlPatch.Operations;
using System;

namespace Mvc.XmlPatch.Exceptions
{
    public class XmlPatchException : Exception
    {
        public Operation FailedOperation { get; private set; }
        public object AffectedObject { get; private set; }
        
        public int SuggestedStatusCode { get; internal set; }

        public XmlPatchException()
        {
        }

        public XmlPatchException(XmlPatchError xmlPatchError, Exception innerException, int suggestedStatusCode)
            : base(xmlPatchError.ErrorMessage, innerException)
        {
            FailedOperation = xmlPatchError.Operation;
            AffectedObject = xmlPatchError.AffectedObject;
            SuggestedStatusCode = suggestedStatusCode;
        }

        public XmlPatchException(XmlPatchError xmlPatchError, int suggestedStatusCode)
            : this(xmlPatchError, null, suggestedStatusCode)
        {
        }

        public XmlPatchException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
