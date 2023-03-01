/* Move a game object horizontally using the arrow keys or AD
Lucía Barrenechea
A01782021*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalmotion : MonoBehaviour
{
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move.x= Input.GetAxis("Horizontal");
        Debug.Log("X motion: " + move.x);
    }
}
