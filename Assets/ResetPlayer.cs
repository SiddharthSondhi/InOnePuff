using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public CharacterController2D controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            Debug.Log(other);
            controller.alive = false;
        }
    }
}
