using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cannon : MonoBehaviour
{

    public GameObject cannonBall;
    public Transform shotPosition;
    Rigidbody cannonBallRB;
    public float firePower;
    List<GameObject> cannonBalls = new List<GameObject>();

    public Text ballsInCannon;
    int countB;

    private void Start()
    {
        cannonBalls.Clear();
        Debug.Log(cannonBalls.Count);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && cannonBalls.Count != 0)
        {
            Debug.Log("DO");
            FireCannon();
            Debug.Log("POSLE");
        }
        countB = cannonBalls.Count;
        ballsInCannon.text = countB.ToString();

    }
    public void FireCannon()
    {
        shotPosition.rotation = transform.rotation;
        firePower = 4000;
        GameObject cannonBallCopy = Instantiate(cannonBall, shotPosition.position, shotPosition.rotation) as GameObject;
        cannonBallRB = cannonBallCopy.GetComponent<Rigidbody>();
        cannonBallRB.AddForce(transform.forward * firePower);
        //RemoveBall(cannonBall ball);
        cannonBalls.RemoveAt(0);
        Debug.Log(cannonBalls.Count);
        Debug.Log("Deleted");
    }
    public void AddBall(cannonball ball)
    {
        cannonBalls.Add(ball.gameObject);
        Debug.Log(cannonBalls.Count);

    }
    /* Переделать, мне не нравится, вылезают ошибки из-за списка. */
}
