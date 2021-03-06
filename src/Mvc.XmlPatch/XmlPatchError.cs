﻿// Any comments, input: @KevinDockx
// Any issues, requests: https://github.com/KevinDockx/XmlPatch
//
// Enjoy :-)
using Mvc.XmlPatch.Operations;

namespace Mvc.XmlPatch
{
    /// <summary>
    /// Captures error message and the related entity and the operation that caused it.
    /// </summary>
    public class XmlPatchError
    {
        /// <summary>
        /// Initializes a new instance of <see cref="XmlPatchError"/>.
        /// </summary>
        /// <param name="affectedObject">The object that is affected by the error.</param>
        /// <param name="operation">The <see cref="Operation"/> that caused the error.</param>
        /// <param name="errorMessage">The error message.</param>
        public XmlPatchError(
             object affectedObject,
             Operation operation,
             string errorMessage)
        {
            AffectedObject = affectedObject;
            Operation = operation;
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Gets the object that is affected by the error.
        /// </summary>
        public object AffectedObject { get; private set; }

        /// <summary>
        /// Gets the <see cref="Operation"/> that caused the error.
        /// </summary>
        public Operation Operation { get; private set; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        public string ErrorMessage { get; private set; }
    }
}
