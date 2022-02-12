using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = .3f;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        float strafe = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");    

        transform.Translate(new Vector3(strafe, 0, forward) * speed * Time.deltaTime);

        float turn = Input.GetAxis("Mouse X");
        transform.rotation *= Quaternion.Slerp(Quaternion.identity, Quaternion.LookRotation(turn < 0 ? Vector3.left : Vector3.right), Mathf.Abs(turn) * turnSpeed * Time.deltaTime);

        anim.SetFloat("Forward", forward);
        anim.SetFloat("Right", strafe);
    }
}
