using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalls : MonoBehaviour
{
    //Class variables to be changed from the unity interface
    [SerailizeField] GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        //It calls the dropball fucntion after 0.5 seconds
        //and then it keeps calling it every 0.8 seconds
        InvokeRepeating("DropBall()",0.5f, 0.8f)
    }

    // Update is called once per frame
    void Update(){

    }

    void DropBall(){
        //Create a copy of the prefab
        Instantiate(ball);

    }    
}
