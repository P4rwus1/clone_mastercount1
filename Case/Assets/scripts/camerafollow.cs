using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject hedef;
    public Vector3 mesafe;
    void Update()
    {
        this.transform.position=Vector3.Lerp( this.transform.position , hedef.transform.position + mesafe , Time.deltaTime*3);
    }
}
