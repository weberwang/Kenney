using UnityEngine;
using System.Collections;

public class ActionContorller : MonoBehaviour {

	// Use this for initialization
    private Animator anim;
    private Rigidbody2D body2d;

    private bool jump = false;
    private bool shouldJump = false;
	void Start () {
        anim = GetComponent<Animator>();
        body2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }
	}

    private void FixedUpdate()
    {
        if (jump && shouldJump)
        {
            anim.SetTrigger("jump");
            body2d.AddForce(Vector2.up * body2d.mass * 200);
            shouldJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "floor")
        {
            anim.SetTrigger("stand");
            shouldJump = true;
        }
    }
}
