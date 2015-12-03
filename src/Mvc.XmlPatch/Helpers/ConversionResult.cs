// Any comments, input: @KevinDockx
// Any issues, requests: https://github.com/KevinDockx/XmlPatch
//
// Enjoy :-)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.XmlPatch.Helpers
{
    internal class ConversionResult
    {
        public bool CanBeConverted { get; private set; }
        public object ConvertedInstance { get; private set; }


        public ConversionResult(bool canBeConverted, object convertedInstance)
        {
            CanBeConverted = canBeConverted;
            ConvertedInstance = convertedInstance;

        }
    }
}
