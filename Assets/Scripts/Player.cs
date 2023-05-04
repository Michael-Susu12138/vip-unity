using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float ySpeed;
    public Transform ears, feet;
    Rigidbody2D _rigidbody2D;
    RequestServer _server;
    GameManager _gameManager;
    bool stop;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _server = GetComponent<RequestServer>();
        _gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(feet.position.y > -5.5f && ears.position.y < 5.4f){
        
            int signal = Int32.Parse(_server.status);
            // int signal = UnityEngine.Random.Range(1,20);
            Debug.Log(signal);
            if (signal == 1){
                ySpeed = 1 * speed;
                _gameManager.setGesture(true);
            } else {
                ySpeed = -1 * speed;
                _gameManager.setGesture(false);
            } 
            Debug.Log(ySpeed);

            _rigidbody2D.velocity = new Vector2(0,ySpeed);
            
        } else {
            _rigidbody2D.velocity = new Vector2(0,-ySpeed);
        }
        
        // // _rigidbody2D.AddForce(new Vector2(1,1));
        // _rigidbody2D.velocity = new Vector2(1, 1);

        
    }


    
}
