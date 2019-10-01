using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

     private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
       private void Update() {
         Rigidbody rb = GetComponent<Rigidbody>();
         if (Input.GetKey(KeyCode.A))
             rb.AddForce(Vector3.left);
         if (Input.GetKey(KeyCode.D))
             rb.AddForce(Vector3.right);
         if (Input.GetKey(KeyCode.W))
             rb.AddForce(Vector3.up);
         if (Input.GetKey(KeyCode.S))
             rb.AddForce(Vector3.down);
 
     }
     private void OnTriggerEnter(Collider other){
         if(other.name=="Sphere")
         { 
             SceneManager.LoadScene("szen2", LoadSceneMode.Single);
             }
         Debug.Log("log " +other.name);
     }
}
