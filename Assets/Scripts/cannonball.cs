using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cannonball : MonoBehaviour
{
    private Vector3 pointScreen;
    private Vector3 offset;
    Cannon cannon;
    private void Start()
    {
        
        
    }

    

    private void OnMouseDown()
    {
        pointScreen = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScreen.z));
    }
    private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScreen.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;
        Debug.Log("sda");
    }

   
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        FindObjectOfType<Cannon>().AddBall(this);
    }

  

}
