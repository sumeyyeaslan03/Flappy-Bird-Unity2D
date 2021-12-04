using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class flyBird : MonoBehaviour
{
    int score=0;
    public TextMeshProUGUI score_Text;
    public GameObject getStartedPanel, forScoreCanvas;
    public float velocity=2f;
    private Rigidbody2D birdRB;

    void Start()
    {
        birdRB =GetComponent<Rigidbody2D>();
        forScoreCanvas.SetActive(false);
        Time.timeScale =0;
    }

    // Update is called once per frame
    void Update()
    {
        score_Text.text = "" + score;
        OnMouseDown();
    }

    void OnMouseDown() {
            if(Input.GetMouseButton(0)){
            birdRB.velocity = Vector2.up *velocity;
        }
    }


    public void OnCollisionEnter2D(Collision2D collision){
       if(collision.gameObject.tag=="pipe"){
            SceneManager.LoadScene("Main");
            getStartedPanel.SetActive(true);
            forScoreCanvas.SetActive(false);
            Time.timeScale =0;
        }
        
    }


    //for topherebutton 
    public void topHereButton(){
        getStartedPanel.SetActive(false);
        forScoreCanvas.SetActive(true);
        Time.timeScale =1;

    }

    public void OnTriggerEnter2D(Collider2D collider){
        if(collider.tag=="block"){
            score++;
        }
    }
}

