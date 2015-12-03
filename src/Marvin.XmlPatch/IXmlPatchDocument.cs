// Any comments, input: @KevinDockx
// Any issues, requests: https://github.com/KevinDockx/XmlPatch
//
// Enjoy :-)
using Marvin.XmlPatch.Operations;
using System.Collections.Generic;

namespace Marvin.XmlPatch
{
    public interface IXmlPatchDocument
    {
        IList<Operation> GetOperations();
    }
}
