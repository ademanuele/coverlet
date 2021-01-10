using System;
using Coverlet.Core.Abstractions;

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
