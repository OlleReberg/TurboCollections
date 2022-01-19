using NUnit.Framework;

namespace TurboCollections.Test;

[TestFixture]
public class TurboStackTests
{
    [Test]
    public void HasEmptyConstructor()
    {
        new TurboStack<int>();
        Assert.Pass();
    }
}

public class GivenANewStack
{
    private TurboStack<int> stack;

    [SetUp]
    private static TurboStack<int> Give()
    {
        return new TurboStack<int>();
    }

    [Test]
    public void HasACountOfZero()
    {
        Assert.Zero(stack.Count);
    }
    public class WhenPushing
    {
        private static TurboStack<int> GiveAndPush(int count)
        {
            var stack = Give();
            for (int i = 0; i < count; i++)
            {
                stack.Push(3); 
            }
            return stack;
        }
        [TestCase(1), TestCase(5), TestCase(499)]
        public void ItIncreasesCount(int count)
        {
            var stack = GiveAndPush(count);
            Assert.AreEqual(count, stack.Count);
        }
        [TestCase(1), TestCase(-56), TestCase(99), TestCase(908)]
        public void TheLatesttItemCanBePeeked(int count, int item)
        {
            var stack = Give();
            for (int i = 0; i < count; i++)
            {
                stack.Push(3); 
            }
            stack.Push(item);
            Assert.AreEqual(item, stack.Peek());
        }
        [TestCase(9)]
        [TestCase(-8)]
        [TestCase(98)]
        [TestCase(908)]
        public void TheLatesttItemCanBePopped(int count, int item)
        {
            var stack = GiveAndPush(count);
            stack.Push(item);
            Assert.AreEqual(item, stack.Pop());
        }
    }

    // public class WhenPopping
    // {
    //     [TestCase(9)]
    //     [TestCase(-8)]
    //     [TestCase(98)]
    //     [TestCase(908)]
    // }
}
