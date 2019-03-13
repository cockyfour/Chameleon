using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour {
    public GameObject player;
    public float Xrot;
    public float Yrot;
    public float Zrot;
    // Use this for initialization
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            player.transform.rotation = Quaternion.Euler(Xrot, Yrot, Zrot);
            
        }







    }
}
