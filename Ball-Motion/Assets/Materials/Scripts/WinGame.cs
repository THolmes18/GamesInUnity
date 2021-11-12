using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") //game object tag not collider
        {
            Debug.Log("You Win!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
