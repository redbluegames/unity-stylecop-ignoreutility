using UnityEngine;
using System.Collections;

/// <summary>
/// Script with some example StyleCop errors. When running StyleCop
/// it should find and report errors on this file.
/// </summary>
public class ScriptWithErrors : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Debug.Log( "Begin ScriptWithErrors for loop" );
        for (int i = 0; i<5; i++)
        {
            Debug.Log ("i");
        }
    }

    // Update is called once per frame
    void Update () {

    }
}
