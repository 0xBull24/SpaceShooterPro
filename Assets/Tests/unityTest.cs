using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class APICallerTest
{
    [UnityTest]
    public IEnumerator TestAPICall()
    {
        APICaller apiCaller = new GameObject().AddComponent<APICaller>();
        apiCaller.apiUrl = "https://cat-fact.herokuapp.com/facts";

        yield return apiCaller.CallAPI();
    }
}
