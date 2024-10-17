using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class enemysc : MonoBehaviour
{
    float speed = 3.0f;
    float randomX;
    int puan = 0;
    string yazdır;// Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down*speed*Time.deltaTime);
        if(transform.position.y<-3.5){
            randomX = Random.Range(-5.5f,5.5f);
            transform.position = new Vector3(randomX,3.5f,5);

        }
        
    }
    void OnTriggerEnter(Collider other){
        Debug.Log(other.transform.name + "nesnesi ile çarpıştı");
        if(other.transform.name == "Capsule(Clone)"){
            randomX = Random.Range(-5.5f,5.5f);
            transform.position = new Vector3(randomX,3.5f,5);
            puan++;
            yazdır = puan.ToString();
        }
    }
    void OnGUI()
    {
        
        GUI.Label(new Rect(100, 100, 1000, 50),yazdır);
        
    }
}

