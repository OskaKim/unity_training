using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class AttackMonster
{
    [UnityTest]
    public IEnumerator 몬스터는_맞으면_체력이_줄어든다()
    {
        TestHelper.PrepareTest();
        var _monster = TestHelper.InstantiateFromResource("MonsterPref");
        var monster = _monster.GetComponent<Monster>();
        var hp = monster.Hp;
        monster.Damaged(10);
        Assert.AreEqual(hp - 10, monster.Hp);
        yield return null;
    }

    public static class TestHelper
    {
        public static GameObject InstantiateFromResource(string _prfName)
        {
            return GameObject.Instantiate(Resources.Load<GameObject>(_prfName));
        }

        public static void CleanUp()
        {
            GameObject[] AllGameObject = GameObject.FindObjectsOfType<GameObject>();
            foreach (GameObject _g in AllGameObject)
            {
                if (_g.name == "Code-based tests runner")
                {
                    // pass
                }
                else
                {
                    GameObject.Destroy(_g);
                }
            }
        }

        public static void PrepareTest()
        {
            CleanUp();
            InstantiateFromResource("MainCameraPref");
            InstantiateFromResource("EventSystemPref");
            InstantiateFromResource("CanvasPref");
        }
    }
}
