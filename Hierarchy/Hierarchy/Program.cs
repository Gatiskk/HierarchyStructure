using Hierarchy.Models;
using System;
using System.Collections.Generic;

namespace Hierarchy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new Calculator();
            var structure = new Branch
            {
                Branches = new List<Branch>
                {
                    new Branch(new List<Branch> { new Branch(
                        new List<Branch> { new Branch(
                            new List<Branch> { new Branch(
                                new List<Branch> { new Branch(
                                    new List<Branch> { new Branch(
                                        new List<Branch> { new Branch(
                                            new List<Branch> { new Branch() }) }) }) }) }) }) }),
                    
                }
            };

            var result = calculator.CalculateDepth(structure.Branches);
            Console.WriteLine($"The depth of this structure is: {result}");
            Console.ReadLine();
        }
    }
}