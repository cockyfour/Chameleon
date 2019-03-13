using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRot : MonoBehaviour {
    public GameObject Cam;
    public GameObject Player;
    Vector3 Pos;
    public float Xrot;
    public float Yrot;
    public float Zrot;
    public float Xpos;
    public float Ypos;
    public float Zpos;
    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Cam.transform.rotation = Quaternion.Euler(Xrot, Yrot, Zrot);
            Vector3 Pos = new Vector3(Xpos, Ypos, Zpos);
            Cam.transform.position = Pos;

        }







    }
}
