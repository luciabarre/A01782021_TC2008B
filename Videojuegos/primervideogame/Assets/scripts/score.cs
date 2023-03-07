using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    [SerializeField] TMP_text tmpobj;
    int Score;
    // Start is called before the first frame update
    void Start()
    {
        Score=0;
        
    }

    // Update is called once per frame
    public void AddPoints(int amount){
        Score+=amount;
        tmpobj.text= "Score" + Score;
        Debug.Log("New score: "+ Score);
    }

}
