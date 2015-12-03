// Any comments, input: @KevinDockx
// Any issues, requests: https://github.com/KevinDockx/XmlPatch
//
// Enjoy :-)

using System;
namespace Mvc.XmlPatch.Adapters
{
    public interface IObjectAdapter<T>
     where T : class
    {
        void Add(Mvc.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Copy(Mvc.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Move(Mvc.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Remove(Mvc.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Replace(Mvc.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Test(Mvc.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
    }

   
}
