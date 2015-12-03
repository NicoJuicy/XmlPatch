// Any comments, input: @KevinDockx
// Any issues, requests: https://github.com/KevinDockx/XmlPatch
//
// Enjoy :-)
using Mvc.XmlPatch.Operations;
using System.Collections.Generic;

namespace Mvc.XmlPatch
{
    public interface IXmlPatchDocument
    {
        IList<Operation> GetOperations();
    }
}
