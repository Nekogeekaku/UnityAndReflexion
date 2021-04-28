using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;
using System.Reflection;
using Example1;
using Example1.Attributes;

public class Basics
{
    // A Test behaves as an ordinary method
    [Test(Description ="Will count the number of methods with the attributes selectables")]
    public void CountAllSelectablesFunctionFromDataManager()
    {

        //System.Reflection.MemberInfo info = typeof(DataManager);

        Type dataManagerType = typeof(DataManager);
        int count = 0;
        foreach (MethodInfo m in dataManagerType.GetMethods())
        {

            foreach (Attribute a in m.GetCustomAttributes(true))
            {
                Selectables sel = (Selectables)a;

                if (null != sel)
                {


                    Debug.LogFormat("Method: {0} is selectable", m.Name);
                    count++;


                }
                else
                {
                    Debug.LogFormat("Method: {0} is not selectable",m.Name);

                }
            }
            if (m.GetCustomAttributes(true).Length==0)
                Debug.LogFormat("Method: {0} has no attribute", m.Name);
        }
       
        Assert.AreEqual(2,count);
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator BasicsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
