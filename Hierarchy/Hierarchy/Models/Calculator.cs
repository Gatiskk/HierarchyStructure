using Hierarchy.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Hierarchy.Models
{
    public class Calculator : ICalculateDepth
    {
        public int CalculateDepth(List<Branch> branches, int depth = 1)
        {
            if (branches == null)
            {
                return depth;
            }
            depth++;
            var results = branches.Select(branch => CalculateDepth(branch.Branches, depth)).ToList();

            return results.Max();
        }
    }
}