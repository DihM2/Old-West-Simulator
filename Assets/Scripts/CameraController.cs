using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject playerGo;

    private Vector3 lookPosition;
    private Vector3 offSet = new Vector3(0, 6, -10);

    // Start is called before the first frame update
    void Start()
    {
        playerGo = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //LookPlayer();

        FollowPlayer();
    }

    // Look to the player position
    void LookPlayer()
    {
        lookPosition = playerGo.transform.position - transform.position;

        transform.rotation = Quaternion.LookRotation(lookPosition);
    }

    void FollowPlayer()
    {
        transform.position = playerGo.transform.position + offSet;
    }
}
