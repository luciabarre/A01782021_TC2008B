/* */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalmotion : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float limit;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move.x=Input.GetAxis("Horizontal");
        //Debug.Log("X motion: "+ move.x);

        if(transform.position.x < -limit && move.x < 0){
            move.x=0;
        }
        else if(transform.position.x > limit && move.x > 0){
            move.x=0;
        }
        //Esta función permite deterimanr la velocidad para que lado en el tiempo transcurrido.
        transform.Translate(move * speed * Time.deltaTime);
    }
}
