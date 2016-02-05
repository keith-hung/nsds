﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsds.Exceptions
{
    public class DictionaryServiceNotFoundException : NsdsException
    {
        public DictionaryServiceNotFoundException(string msg)
            :base(msg, "1")
        {
        }
    }
}
