using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    [SerializeField] TMP_Text tmpObj;
    [SerializeField] int maxScore;
    [SerializeField] CreateBalls creator;
    int Score;
    // Start is called before the first frame update
    void Start()
    {
        creator=GetComponent<CreateBalls>();
        Score=0;
        
    }

    // Update is called once per frame
    public void AddPoints(int amount){
        Score+=amount;
        tmpObj.text= "Score" + Score;
        Debug.Log("New score: "+ Score);

        if(Score==maxScore){
            Finish();
        }
    }

    void Finish()
    {
        creator.StopBalls();
        tmpObj.text+="\n\nYou Won! ";

    }

}
