using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;

namespace TurboCollections.Test;

public class TurboListTests
{
    [Test]
    public void NewListIsEmpty()
    {
        var list = new TurboList<int>();
        Assert.Zero(list.Count);
    }

    [Test]
    public void AddingAnElementIncreasesCountToOne()
    {
        var list = new TurboList<int>();
        list.Add(5);
        Assert.AreEqual(1, list.Count);
    }

    [Test, TestCase(5), TestCase(7)]
    public void AddingMultipleElementsIncreasesCount(int numberOfElements)
    {
        var list = new TurboList<int>();
        for (int i = 0; i < numberOfElements; i++)
            list.Add(5);
        Assert.AreEqual(numberOfElements, list.Count);
    }
    public void RemovingAnElementFromTheList()
    {
        //Clear();
    }
    [Test]
    public void AnAddedElementCanBeGet()
    {
        var list = new TurboList<int>();
        list.Add(145);
        Assert.AreEqual(145, list.Get(0));
    }
}