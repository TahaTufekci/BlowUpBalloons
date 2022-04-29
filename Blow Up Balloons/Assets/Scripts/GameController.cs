using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{ 
    public UnityEngine.UI.Text time,balloon;
    public GameObject popping;
    public float timer = 60;
    int poppedBalloon = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0){
             timer -= Time.deltaTime;
             time.text = "Time : " + (int)timer;
        
        }
        else{
            GameObject[] go = GameObject.FindGameObjectsWithTag("balloon");
            for(int i = 0 ; i < go.Length;i++){
                Instantiate(popping,go[i].transform.position,go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
       
    }
    public void addBalloon(){
      poppedBalloon += 1;
      balloon.text = "Balloon : " + poppedBalloon;

    }
}
