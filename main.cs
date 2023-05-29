using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonBehaviour : MonoBehaviour
{

    public GameObject cube;

    VirtualButtonBehaviour vbutton;

    void Start()
    {
        cube.SetActive(false);

        vbutton = GetComponentInChildren<VirtualButtonBehaviour>();
    }

    void onButtonPressed(VirtualButtonBehaviour vb) {
        
    }
}
