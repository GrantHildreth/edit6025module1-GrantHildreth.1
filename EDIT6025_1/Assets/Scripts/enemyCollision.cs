using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{
    public GameObject textToDisplay;
    // Start is called before the first frame update
    void Start()
    {
        textToDisplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        textToDisplay.SetActive(true);
    }
}
