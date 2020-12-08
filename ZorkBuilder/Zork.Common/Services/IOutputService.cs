﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    public interface IOutputService
    {
        void Write(string value);

        void WriteLine(string value);
        
        void Write(object value);
        
        void WriteLine(object value);

        void Clear();
    }
}
