using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollect : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Collectable"))
        {
            score++;
            UpdateScoreUI();
            Destroy(other.gameObject);
        }
    }
    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
