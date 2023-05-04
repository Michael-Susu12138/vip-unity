using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrots : MonoBehaviour
{


    Rigidbody2D _rigidbody2D;
    GameManager _gameManager;
    public float speed;

    void Start(){
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(new Vector2(-speed,0));
        Vector3 newRotation = new Vector3(0,0,271);
        transform.eulerAngles = newRotation;
        _gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            _gameManager.AddScore(10);
            Destroy(gameObject);
        }
        if(other.CompareTag("killerZone")){
            Destroy(gameObject);
        }
    }

    
}
