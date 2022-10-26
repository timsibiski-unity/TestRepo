using System.IO;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    #if UNITY_CLOUD_BUILD
        Debug.Log("TelemetrySystem UNITY_CLOUD_BUILD defined");
    #else
        Debug.Log("TelemetrySystem UNITY_CLOUD_BUILD NOT defined");
    #endif
        string[] files = Directory.GetFiles(Application.dataPath);
        foreach (string file in files)
        {
            if(!file.EndsWith(".meta"))
                Debug.Log("FILE FOUND: " + file);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
