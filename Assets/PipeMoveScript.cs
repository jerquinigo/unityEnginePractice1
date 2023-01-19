using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 5;
    public float deadZone = -45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // vector three is needed because of the x,y,z space. Unity is still a 3d engine
        // Time.deltaTime will happen at its designated time, no matter the frame rate.
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone) {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
    }
}
