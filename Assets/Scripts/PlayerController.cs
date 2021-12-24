using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    [SerializeField] float speed = 5.0f;

    Build houseService;

    GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        
        if(houseService != null && Input.GetKeyDown(KeyCode.Space))
        {
            houseService.UseService();
        }

    }

    void PlayerMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        houseService = other.GetComponent<Build>();
    }

    private void OnTriggerExit(Collider other)
    {
        houseService = null;
    }
}
