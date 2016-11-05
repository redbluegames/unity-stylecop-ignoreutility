using System.Collections;
using UnityEngine;

/// <summary>
/// This script should have no StyleCop errrors, based on
/// rules set in our Settings.Stylecop file.
/// </summary>
public class ScriptWithNoErrors : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        Debug.Log("Begin ScriptWithNoErrors for loop");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("i");
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
