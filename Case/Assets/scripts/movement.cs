using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{ 
     public int speed=4;
    public float swipespeed = 0.07f;
    public Vector3 firstpose,endpose;
    public GameObject player;
    public Animator anim;

    void Start()
    {
        
    }
    void Update()
    {
        player.transform.Translate(Vector3.forward*speed*Time.deltaTime);
                anim.SetBool("walk",true);        
        if (Input.GetMouseButtonDown(0)){
            firstpose=Input.mousePosition;

        }
        else if(Input.GetMouseButton(0)){
            endpose=Input.mousePosition;
            float farkX=endpose.x-firstpose.x;
            transform.Translate(farkX * swipespeed * Time.deltaTime, 0, 0);
          
        }
        if (Input.GetMouseButtonUp(0)){
            firstpose=Vector3.zero;
            endpose=Vector3.zero;
    }
    }
   

        

    
}
