using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class APICaller : MonoBehaviour
{
    public string apiUrl = "https://cat-fact.herokuapp.com/facts"; 

    public IEnumerator CallAPI()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(apiUrl))
        {
            yield return request.SendWebRequest();
            Debug.Log("Sweet cat data coming back successful!");
        }
    }
}
