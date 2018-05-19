﻿using System;
using System.Collections.Generic;

namespace DeviceLibrary.Abstract.DataObjects.Containers
{
    public class DateValues : List<(string value, DateTime timeMark)>
    {
        public DateValues() : base()
        {
        }

        public DateValues(int capasity) : base(capasity)
        {
        }
    }
}