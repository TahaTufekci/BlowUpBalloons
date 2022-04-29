using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonCreater : MonoBehaviour
{
    public GameObject balloon;
    float balloonCreateTime = 0.7f;
    float timer = 0f;
    GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = this.gameObject.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        int multiplier = (int)(gameController.timer/10) - 6 ;
        multiplier *= -1;
        if(timer < 0 && gameController.timer > 0){
            GameObject go =  Instantiate(balloon,new Vector3(Random.Range(-2.25f,2.25f),-6f,0),Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(40f*multiplier,100f*multiplier),0));
            timer = balloonCreateTime;
        }
        
    }
}
