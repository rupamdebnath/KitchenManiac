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
    [SerializeField]
    private Animator playerAnimator;
    private void Start()
    {
        playerBody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
            playerAnimator.SetBool("Walk", true);
        else 
            playerAnimator.SetBool("Walk", false);
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
