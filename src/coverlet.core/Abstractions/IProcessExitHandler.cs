using System;

namespace Coverlet.Core.Abstractions
{
    public interface IProcessExitHandler
    {
        void Add(EventHandler handler);
    }
}
