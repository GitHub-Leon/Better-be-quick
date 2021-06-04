using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float jumpForce = 5f;

    private Rigidbody2D myRB;
    private bool canJump;
    private float lastUpdate;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D> ();
    }

    //jump
    public void Jump() {
        if (canJump) {
            canJump = false;
            myRB.velocity = new Vector2(0, jumpForce);
        }
    }

    //updates
    public void Update() {
        if (Input.GetKey(KeyCode.Space)) {    //if key input == spacebar
            Jump();
        }

        if(Time.time - lastUpdate >= 1f){
            Player_Score.scoreValue += 1;
            lastUpdate = Time.time;

        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        canJump = true;
    }
}
