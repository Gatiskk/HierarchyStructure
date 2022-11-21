using System.Collections.Generic;
using Hierarchy.Models;

namespace Hierarchy.Interfaces
{
    public interface ICalculateDepth
    {
        int CalculateDepth(List<Branch> branches, int depth = 1);
    }
}