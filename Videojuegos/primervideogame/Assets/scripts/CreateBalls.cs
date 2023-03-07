using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalls : MonoBehaviour
{
    //Class variables to be changed from the unity interface
    [SerializeField] GameObject ball;
    [SerializeField] float delay;
    // Start is called before the first frame update
    void Start()
    {
        //It calls the dropball fucntion after 0.5 seconds
        //and then it keeps calling it every 0.8 seconds
        InvokeRepeating("DropBall",0.5f, delay);
    }

    // Update is called once per frame
    void Update(){

    }

    void DropBall(){
        //Generate a new random position
        Vector3 pos = new Vector3(Random.Range(-10.0f, 10.0f),6,0);
        //Create a copy of the prefab
        GameObject obj=Instantiate(ball, pos, Quaternion.identity);
        //doom the object to die in 5 seconds
        Destroy(obj,5);

    }    

    public void StopBalls(){
        CancelInvoke("DropBall");
    }
}
