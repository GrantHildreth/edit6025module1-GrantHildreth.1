using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the space key is pressed, then change the scale of the player.

        if (Input.GetKeyDown(KeyCode.G))
        {
            player.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            player.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up *500);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float depthInput = Input.GetAxis("Depth");
        //create a local variable for depth - Input.GetAxis("Depth")

        transform.Translate(new Vector3(horizontalInput, verticalInput, depthInput) * Time.deltaTime);
    }
}
