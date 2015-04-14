using UnityEngine;
using System.Collections;

public class PlayerContorller : MonoBehaviour {

	// Use this for initialization
    private Animator anim;
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float speed = Input.GetAxis("Horizontal");
        anim.SetFloat("speed", Mathf.Abs(speed));
	}
}
