using FluentAssertions;
using Hierarchy.Models;
using System;
using System.Collections.Generic;
using Hierarchy.Interfaces;
using Xunit;
using System.Linq;

namespace Hierarchy.Tests
{
    public class CalculateDepthTests
    {
        public List<Branch> Branches;

        [Fact]
        public void CalculateDepth_IfListIsnull_ReturnException()
        {
            //Arrange
            var calculator = new Calculator();
            Branches = new List<Branch>();

            //Assert & Act
            Action act = () => calculator.CalculateDepth(branches:new List<Branch>());
            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Sequence contains no elements");
        }

        [Fact]
        public void ListAddMethod_CanAddBranch()
        {
            //Arrange
            Branches = new List<Branch>();

            //Act
            Branches.Add(new Branch());

            //Assert
            Branches.Count().Should().Be(1);
        }

        [Fact]
        public void CalculateDepth_Adding5branches_return5()
        {
            //Arrange
            var calculator = new Calculator();
            Branches = new List<Branch>
            {
                new Branch(
                    new List<Branch> { new Branch() }),
                new Branch(
                    new List<Branch> { new Branch(
                        new List<Branch> { new Branch() }), new Branch(
                        new List<Branch> { new Branch(
                            new List<Branch> { new Branch() }), new Branch() }), new Branch() }),
            };

            //Act
            int depth = calculator.CalculateDepth(Branches);

            //Assert
            depth.Should().Be(5);
            
        }

        [Fact]
        public void CalculateDepth_Adding9branches_return9()
        {
            //Arrange
            var calculator = new Calculator();
            Branches = new List<Branch>
            {
                
                    new Branch(new List<Branch> { new Branch(
                        new List<Branch> { new Branch(
                            new List<Branch> { new Branch(
                                new List<Branch> { new Branch(
                                    new List<Branch> { new Branch(
                                        new List<Branch> { new Branch(
                                            new List<Branch> { new Branch() }) }) }) }) }) }) }),

                
            };

            //Act
            int depth = calculator.CalculateDepth(Branches);

            //Assert
            depth.Should().Be(9);

        }
    }
}