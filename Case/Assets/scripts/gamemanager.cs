using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject gameover,sahnecanvas,menucanvas,player;
    
    //public movement move_sc;
    void Start()
    {
        player.GetComponent<movement>().enabled=false;
        player.GetComponent<Animator>().enabled=false;
       
      
        sahnecanvas.SetActive(false);
        menucanvas.SetActive(true);
        gameover.SetActive(false);
    }

   public void call(){

    gameover.SetActive(true);



   }
   public void recall(){

    gameover.SetActive(false);
   // SceneManager.Load(2);


   }
   public void play(){
        
    player.GetComponent<movement>().enabled=false;
        player.GetComponent<Animator>().enabled=false;

    sahnecanvas.SetActive(true);
    menucanvas.SetActive(false);



   }
    
}
