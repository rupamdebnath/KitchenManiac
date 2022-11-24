using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    float translation, rotation;
    // Update is called once per frame

    Rigidbody playerBody;

    private void Awake()
    {
        playerBody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {

        translation = Input.GetAxisRaw("Vertical") * speed;
        rotation = Input.GetAxisRaw("Horizontal") * rotationSpeed;


        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}
