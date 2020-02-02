﻿using System;
using Coverlet.Core.Abstracts;

namespace Coverlet.Core.Helpers
{
    public class ProcessExitHandler : IProcessExitHandler
    {
        public void Add(EventHandler handler)
        {
            AppDomain.CurrentDomain.ProcessExit += handler;
        }
    }
}
