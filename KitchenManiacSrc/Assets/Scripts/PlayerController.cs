using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    float translation, rotation;
    // Update is called once per frame
    void Update()
    {

        translation = Input.GetAxisRaw("Vertical") * speed;
        rotation = Input.GetAxisRaw("Horizontal") * rotationSpeed;


        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);
    }
}
