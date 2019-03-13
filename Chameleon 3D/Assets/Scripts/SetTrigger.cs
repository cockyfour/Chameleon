using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTrigger : MonoBehaviour {
    public Collider triggercol;
    
   
    void Start () {
        triggercol.GetComponent<BoxCollider>();
        triggercol.isTrigger = true;
        
		
	}
    
    
    void OnCollisionStay(Collision col)
    {
        
        if (col.gameObject.name == "Player" && Input.GetKey("e"))
        {
            triggercol.isTrigger = false;
            print("E is pressed");
            
        }
        
    }
    

}

