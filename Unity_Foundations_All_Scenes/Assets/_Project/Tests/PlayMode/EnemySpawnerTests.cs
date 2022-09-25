using System.Collections;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;
using EnemySpawner;

namespace Tests
{
    public class EnemySpawnerTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator _Instantiates_GameObject_From_Prefab()
        {
            // Use the Assert class to test conditions.
            var spawnedEnemy = GameObject.FindWithTag("Enemy");
            var prefabOfTheSpawnedEnemy = PrefabUtility.GetPrefabParent(spawnedEnemy);
            Assert.AreEqual(enemyPrefab, prefabOfTheSpawnedEnemy);
            // Use yield to skip a frame.
            //yield return null;
        }
       
    }
}
