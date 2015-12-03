// Any comments, input: @KevinDockx
// Any issues, requests: https://github.com/KevinDockx/XmlPatch
//
// Enjoy :-)

using System;
namespace Marvin.XmlPatch.Adapters
{
    public interface IObjectAdapter<T>
     where T : class
    {
        void Add(Marvin.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Copy(Marvin.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Move(Marvin.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Remove(Marvin.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Replace(Marvin.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Test(Marvin.XmlPatch.Operations.Operation<T> operation, T objectToApplyTo);
    }

   
}
