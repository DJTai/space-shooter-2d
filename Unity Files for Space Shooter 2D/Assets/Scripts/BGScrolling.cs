using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScrolling : MonoBehaviour {

    public float moveSpeed;
    Vector3 startPOS;
    // Use this for initialization
    void Start()
    {

        startPOS = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate((new Vector3(1, 0, 0)) * moveSpeed * Time.deltaTime);

        if (transform.position.y < -35.62685)
        {
            transform.position = startPOS;
        }

    }
}
