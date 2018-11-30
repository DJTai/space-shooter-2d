using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBarSound : MonoBehaviour
{

    public AudioSource playerShoot;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerShoot.Play();
        }

    }

}
