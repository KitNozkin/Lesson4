using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(200, 200, 200, 200), "Main menu"))
        {
            Application.LoadLevel("MaimMenu");
        }
    }
}
