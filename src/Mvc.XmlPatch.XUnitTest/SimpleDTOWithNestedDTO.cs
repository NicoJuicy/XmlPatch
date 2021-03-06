﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.XmlPatch.XUnitTest
{
    public class SimpleDTOWithNestedDTO
    {
        public int IntegerValue { get; set; }

        public NestedDTO NestedDTO { get; set; }

        public SimpleDTO SimpleDTO { get; set; }

        public List<SimpleDTO> ListOfSimpleDTO { get; set;}

        public SimpleDTOWithNestedDTO()
        {
            this.NestedDTO = new NestedDTO();
            this.SimpleDTO = new SimpleDTO();
            ListOfSimpleDTO = new List<SimpleDTO>();
        }
    }
}
