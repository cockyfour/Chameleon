using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelLight : MonoBehaviour
{
    Light panelLight;
    public float wait = 0.5f;
    public Collider triggercol;


    void Start()
    {
        triggercol.GetComponent<BoxCollider>();
        panelLight = GetComponent<Light>();
        panelLight.color = Color.red;
        triggercol.GetComponent<BoxCollider>();
        panelLight = GetComponent<Light>();
        StartCoroutine(Flash());
        

    }

    IEnumerator Flash()
    {
        while (true)
        {
            yield return new WaitForSeconds(wait);
            panelLight.enabled = !panelLight.enabled;
        }
    }
    void Update()
    {
        if (triggercol.isTrigger == false)
        {
            panelLight.color = Color.green;
        }
    }
}
