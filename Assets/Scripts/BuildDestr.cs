using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildDestr : MonoBehaviour
{
    public GameObject[] blocks;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cannonBall")
        {


            foreach (GameObject gameObject in blocks)
            {
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
                
            }

        }
       
    }
}
