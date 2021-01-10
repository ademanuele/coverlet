using System.Collections.Generic;
using Coverlet.Core.Symbols;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Coverlet.Core.Abstractions
{
    public interface ICecilSymbolHelper
    {
        IReadOnlyList<BranchPoint> GetBranchPoints(MethodDefinition methodDefinition);
        bool SkipNotCoverableInstruction(MethodDefinition methodDefinition, Instruction instruction);
    }
}
