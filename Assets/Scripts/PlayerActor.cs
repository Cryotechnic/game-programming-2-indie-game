using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : MonoBehaviour
{
    public static int jumpCount = 2;
    int jumps = jumpCount;
    public float jumpForce = 40f;
    Rigidbody m_Rigidbody;
    CapsuleCollider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Collider = GetComponent<CapsuleCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * 10);
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10, 0, 0);
        // Double-jump code
        if (Input.GetKeyDown(KeyCode.Space) && jumps > 0)
        {
            m_Rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumps--;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        jumps = jumpCount;
        Debug.Log(jumps);
    }
}
