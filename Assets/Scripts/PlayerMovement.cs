using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private float moveSpeed;
    private float move;
    private float rotation;
    private float rotationSpeed;
    private Rigidbody2D tank;
    private SpriteRenderer sr;
    private bool pressedW = true;
    public Vector3 startRotation;


    void Start() {
        moveSpeed = 5f;
        rotationSpeed = 100f;
        tank = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update() {
        move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * -rotationSpeed * Time.deltaTime;
    }

    private void LateUpdate() {
        transform.Translate(move, 0f, 0f);
        transform.Rotate(0f, 0f, rotation);
    }



















// private void Awake() {
    
// }
//     void Start()
//     {
//         tank = GetComponent<Rigidbody2D>();
//         sr = GetComponent<SpriteRenderer>();
//         moveForce = 40f;
//         transform.eulerAngles = startRotation;
//     }

//     // Update is called once per frame
//     void FixedUpdate()
//     {

//         if(Input.GetKeyDown(KeyCode.W) && pressedW) tank.velocity = new Vector2(moveForce, 0f) * Time.deltaTime;
//         else if(Input.GetKeyUp(KeyCode.W)){
//             tank.velocity = new Vector2(0f, 0f);
//             pressedW = false;
//         }
//         if(Input.GetKey(KeyCode.A)) transform.Rotate(Vector3.forward, 100 * Time.deltaTime);
//         if(Input.GetKey(KeyCode.D)) transform.Rotate(Vector3.back, 100 * Time.deltaTime);

//     }

}
