using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rapor2 : MonoBehaviour
{   
    float speed = 5f;
    public float aralik = 0.5f;
    private float sonatis;
    public GameObject lazerPrefab;

    void Start()
    { 
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Time.time - sonatis > aralik){
            lazerat();
            sonatis = Time.time;
        yonlendirme();
    }
    void lazerat(){
        GameObject lazer = Instantiate(lazerPrefab, transform.position, Quaternion.identity);
   }
    void yonlendirme(){
            
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 yon = new Vector3(horizontal,vertical,0);
            transform.Translate(yon*speed*Time.deltaTime);
            if(transform.position.x > 7.6f){
                transform.position = new Vector3(-7.6f,transform.position.y,transform.position.z);
            }
            else if(transform.position.x < -7.6f){
                transform.position = new Vector3(7.6f,transform.position.y,transform.position.z);
            }

             if(transform.position.y > 5.2f){
                transform.position = new Vector3(transform.position.x,-5.2f,transform.position.z);
            }
            else if(transform.position.y < -5.2f){
                transform.position = new Vector3(transform.position.x,5.2f,transform.position.z);
            }
        }
    
  
    }

