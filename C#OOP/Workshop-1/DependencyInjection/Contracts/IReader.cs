﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Contracts
{
    interface IReader
    {
        string ReadKey();

        string ReadLine();
    }
}
