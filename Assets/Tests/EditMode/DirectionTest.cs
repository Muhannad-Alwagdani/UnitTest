using NUnit.Framework;
using UnityEngine;

public class DirectionTest
{
    [Test]
    public void North()
    {
        Assert.AreEqual(new Vector3(0, 1, 0),new Vector3(0, 1, 0));
    }
    [Test]
    public void South()
    {
        Assert.AreEqual(new Vector3(0, -1, 0),new Vector3(0, -1, 0));
    }
}
