﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain.BaseEntity
{
    internal class MyException:Exception
    {
        public MyException(string message): base(message)
        {

        }
    }
}
