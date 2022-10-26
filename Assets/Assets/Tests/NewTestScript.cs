using System.Collections;
using System.IO;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void NewTestScriptSimplePasses()
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

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
