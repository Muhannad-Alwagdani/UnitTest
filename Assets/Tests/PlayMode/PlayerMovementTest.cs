using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Player;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerMovementTest
{
    
    [UnityTest]
    public IEnumerator MovePlayerNorth()
    {
        var gameObject = new GameObject();
        gameObject.AddComponent<CharacterController>();
        var player = gameObject.AddComponent<PlayerMovements>();
        player.Move(Vector3.forward);
        yield return null;
        Assert.AreEqual(Vector3.forward, gameObject.transform.position);
    }
}
