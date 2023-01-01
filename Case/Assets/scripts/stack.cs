using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class stack : MonoBehaviour
{
    public GameObject clone,enemy;    
    movement move_sc;
    public gamemanager gamemanager_sc;
    public Transform parent,enemyparent;
    
    public int clonesay,clone_num,enemy_num,newcount;
    TMP_Text clonetext;
         void Start(){

            parent=transform;
            
            enemyspawn();
            
        }
    
    public void  OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag=="dokun"){


          clonetext =  other.gameObject.GetComponentInChildren<TMP_Text>(); 
           int.TryParse(clonetext.text, out clonesay);
                  
             for (int i = 0; i < 2; i++)
        {
            Instantiate(clone, transform.position, Quaternion.identity, transform);
        }

        clone_num = transform.childCount;
       


        }
        if(other.gameObject.tag=="enemy"){

            var anim=other.gameObject.GetComponent<Animator>();
            anim.SetBool("enemywalk",true);
            other.gameObject.transform.position=clone.transform.position;       
            StartCoroutine(battle());
            if(newcount<0){

                Time.timeScale=0f;


            }
            else{
                Time.timeScale=1f;

            }
       
        }
        if(other.gameObject.tag=="engel"){


            newcount-=1;
            gamemanager_sc.call();

        }


    }
    
   /* public void fonksiyon(){


        for (int i = 0; i < clonesay; i++)
        {
           clonecount= Random.Range(20,clonecount);
       //    spawnedclone.GetComponent<CapsuleCollider>().enabled=false;
                Vector3 position = new Vector3(Random.Range(0,newposition), 0, Random.Range(0,newposition));
          GameObject spawnedclone=Instantiate(clone,position,Quaternion.identity);
          
        }
    } 
    */
 public void enemyspawn(){
            

           
           Vector3 enemy_spawned_pos=new Vector3(Random.Range(25,30),0,Random.Range(-3,3));
          
          for (int i = 0; i < 3; i++)
          {
          Instantiate(enemy,enemy_spawned_pos,Quaternion.identity);
            
          }



 }
 public IEnumerator battle(){



            newcount=clone_num-enemy_num;
           yield return new WaitForSeconds(0.1f);
           Debug.Log(newcount);
        


 }

  
}
