using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RequestServer : MonoBehaviour
{
    public string status;

    void Start(){
        StartCoroutine(AsynRequest());
    }

    IEnumerator AsynRequest(){
        while(true){
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(GetRequest("http://192.168.1.3:8080"));
        }
        
    }
    
    // // IEnumerator WaitAndRun(){
    // //     yield return newWaitForSeconds
    // // }
    IEnumerator GetRequest(string uri){
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri)){
            yield return webRequest.SendWebRequest();
            if(webRequest.isNetworkError){
                Debug.Log("Error: " + webRequest.error);
            } else {
                Debug.Log(webRequest.downloadHandler.text);
                // print(typeof(webRequest.downloadHandler.text));
                var text = webRequest.downloadHandler.text;
                // print(text['y_pred']);
                var arr = text.Split(',');
                print(arr[0].Split(':')[1].Replace("\"",""));
                status = arr[0].Split(':')[1].Replace("\"","");
            }
        }
    }

    
}
