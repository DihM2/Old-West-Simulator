using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject playerGo;

    private Vector3 lookPosition;
    // Start is called before the first frame update
    void Start()
    {
        playerGo = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        LookPlayer();
    }

    // Look to the player position
    void LookPlayer()
    {
        lookPosition = playerGo.transform.position - transform.position;

        transform.rotation = Quaternion.LookRotation(lookPosition);
    }
}
