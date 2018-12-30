using UnityEngine;
using System.Collections;

public class Questions : MonoBehaviour {

    public bool panelOpen = false;
    public Canvas panelCanvas;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}


    void openPanel()
    {
        if (panelOpen == false)
        {
            panelOpen = true;
            panelCanvas.enabled = true;

        }
        else
        {
            panelOpen = false;
            panelCanvas.enabled = false;
        }


    }
}
