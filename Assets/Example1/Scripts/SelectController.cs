using UnityEngine;
using System.Collections;
using System;
using Example1;
using System.Collections.Generic;
using UnityEngine.UI;
public class SelectController : MonoBehaviour
{


    public GameObject scrollViewContent;
    public GameObject ListPrefab;


    public string MethodNameToCall;
    // Use this for initialization
    void Start()
    {
        Type dataManagerType = typeof(DataManager);

        System.Reflection.MethodInfo myMethod = dataManagerType.GetMethod(MethodNameToCall);
        var result = myMethod.Invoke(null, null);

        Debug.Log(result);
        Debug.Log(myMethod.ReturnType);
        var result2 = result as IEnumerable;
        Debug.Log(result2);
        foreach (ISelectable item in result2)
        {
            string displayName = item.GetDisplayName();
            GameObject go = Instantiate(ListPrefab);
            go.GetComponentInChildren<Text>().text = displayName;
         
            go.transform.SetParent(scrollViewContent.transform);
        }


    }
    // Update is called once per frame
    void Update()
    {

    }
}
