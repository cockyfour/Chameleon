using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLight : MonoBehaviour {
    Light Camlight;
    public float wait = 0.5f;

	
	void Start () {
        Camlight = GetComponent<Light>();
        StartCoroutine(Flash());
		
	}
	
	IEnumerator Flash()
    {
        while (true)
        {
            yield return new WaitForSeconds(wait);
            Camlight.enabled = !Camlight.enabled;
        }
    }
}
