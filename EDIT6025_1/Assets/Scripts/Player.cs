using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score = 5;
    public float speed = 5.5f;
    public string myName;
    public bool hasKey;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        Debug.Log(" this is my Name:" + myName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
