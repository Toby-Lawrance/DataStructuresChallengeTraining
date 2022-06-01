using System;
using System.Collections.Generic;
using System.Linq;
using Challenge;
using Xunit;

namespace ChallengeTests
{
    public class Challenge3Tests
    {
        [Theory]
        [MemberData(nameof(TestTreeOne))]
        [MemberData(nameof(TestTreeTwo))]
        [MemberData(nameof(TestTreeThree))]
        [MemberData(nameof(TestTreeFour))]
        [MemberData(nameof(TestTreeFive))]
        public void Validation(Node<int> root, IEnumerable<Node<int>> path)
        {
            Assert.Equal(path.Select(n => n.Value),Challenge3Class.Challenge3(root).Select(n => n.Value));
        }

        public static IEnumerable<object[]> TestTreeOne
        {
            get
            {
                int index = 0;
                var root = Create(ref index);
                root.Children = new List<Node<int>> {Create(ref index), Create(ref index)};
                return new []{new object[]{root, new [] { root, root.Children[0], root.Children[1]}}};
            }
        }
        
        public static IEnumerable<object[]> TestTreeTwo
        {
            get
            {
                int index = 0;
                var root = Create(ref index);
                var leaf = Create(ref index);
                var parent = Create(ref index);
                parent.Children.Add(leaf);
                root.Children.Add(parent);
                return new []{new object[]{root, new [] { root, root.Children[0], root.Children[0].Children[0]}}};
            }
        }
        
        public static IEnumerable<object[]> TestTreeThree
        {
            get
            {
                int index = 0;
                var root = Create(ref index);
                var leaf = Create(ref index);
                var leaf2 = Create(ref index);
                var parent = Create(ref index);
                parent.Children.Add(leaf);
                parent.Children.Add(leaf2);
                root.Children.Add(parent);
                return new []{new object[]{root, new [] { root, root.Children[0], root.Children[0].Children[0], root.Children[0].Children[1]}}};
            }
        }
        
        public static IEnumerable<object[]> TestTreeFour
        {
            get
            {
                int index = 0;
                var root = Create(ref index);
                root.Children = new List<Node<int>> {Create(ref index), Create(ref index), Create(ref index), Create(ref index)};
                root.Children[3].Children.Add(Create(ref index));
                return new []{new object[]{root, new [] { root, root.Children[0], root.Children[1], root.Children[2], root.Children[3], root.Children[3].Children[0]}}};
            }
        }
        
        public static IEnumerable<object[]> TestTreeFive
        {
            get
            {
                int index = 0;
                var root = Create(ref index);
                root.Children = new List<Node<int>> {Create(ref index), Create(ref index), Create(ref index), Create(ref index)};
                root.Children[3].Children.Add(Create(ref index));
                root.Children[0].Children.Add(Create(ref index));
                root.Children[1].Children.Add(Create(ref index));
                root.Children[1].Children[0].Children.Add(Create(ref index));
                return new []{new object[]{root, new [] { root, root.Children[0], root.Children[0].Children[0], root.Children[1], root.Children[1].Children[0], root.Children[1].Children[0].Children[0],root.Children[2],root.Children[3],root.Children[3].Children[0]}}};
            }
        }

        private static Node<int> Create(ref int index)
        {
            return new Node<int> {Value = index++};
        }
    }
}