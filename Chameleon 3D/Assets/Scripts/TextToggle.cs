using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToggle : MonoBehaviour {
    public Canvas canvas;


    void Start()
    {
        canvas.enabled = false;
    }


    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            canvas.enabled = true;



        }

        
    }
    
}
