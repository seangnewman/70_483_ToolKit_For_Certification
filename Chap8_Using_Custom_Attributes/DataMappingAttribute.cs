﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_Using_Custom_Attributes
{
    [System.AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class DataMappingAttribute:System.Attribute
    {
        public string  ColumnName { get; set; }
        public string PropertyName { get; set; }

        public DataMappingAttribute(string columnName, string propertyName)
        {
            ColumnName = columnName;
            PropertyName = propertyName;
        }
    }


}
