﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosedXML.Excel
{
    public interface IXLRow: IXLRange
    {
        Double Height { get; set; }
        
    }

    public static class IXLRowMethods
    {

    }
}
