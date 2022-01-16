using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public Text ScoreText;
    public GameObject targets;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {

        ScoreText.text =  "Soult Collected : " + score.ToString();
    } 

   
    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnTriggerEnter(Collider targets){
        if(targets.tag == "Enemy"){
            SceneManager.LoadScene("SampleScene");
        }
        else if (targets.tag == "point"){
            score ++;
            ScoreText.text = " Soul Collected :" +score;
            Destroy(targets.gameObject);
        }
        else if(targets.tag == "End"){
            SceneManager.LoadScene("End");
        }
        
    }

}
