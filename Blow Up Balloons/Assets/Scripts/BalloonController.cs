using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public GameObject popping;
    GameController gameController;

    void Start() {
        gameController = GameObject.Find("_Scripts").GetComponent<GameController>();
    }
    
    void OnMouseDown(){
        Destroy(this.gameObject);
        GameObject go = Instantiate(popping,transform.position,transform.rotation) as GameObject;
        Destroy(go,0.267f);
        gameController.addBalloon();
    }
}
