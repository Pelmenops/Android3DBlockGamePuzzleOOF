using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayer : MonoBehaviour
{
    bool ButtonLeftDown;
    bool ButtonRightDown;
    [SerializeField] Vector3 MoveVector;
   /* [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    

    private void FixedUpdate() {
        if(Input.GetKey(keyOne)){GetComponent<Rigidbody>().velocity += MoveDirection;}
        if(Input.GetKey(keyTwo)){GetComponent<Rigidbody>().velocity -= MoveDirection;}
        if(Input.GetKey(KeyCode.R)){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}
        if(Input.GetKey(KeyCode.N)){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}
        if(Input.GetKey(KeyCode.P) && SceneManager.GetActiveScene().buildIndex !=0){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);}

    }*/
   public void MoveLeftDown() { ButtonLeftDown = true; }
    public void MoveRightDown() { ButtonRightDown = true; }
    public void MoveLeftUp() { ButtonLeftDown = false; }
    public void MoveRightUp() { ButtonRightDown = false; }

    private void FixedUpdate()
    {
        if(ButtonLeftDown == true) { GetComponent<Rigidbody>().velocity -= MoveVector; }
        if(ButtonRightDown == true) { GetComponent<Rigidbody>().velocity += MoveVector; }
    }
   
    private void OnTriggerEnter(Collider other){
        if(this.CompareTag("Player") && other.CompareTag("Finish")){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}
    }
    
}
