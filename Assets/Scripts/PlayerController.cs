using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forceMultiplier;
    private float moveHorizontal;
    private float moveVertical;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(x: 0, y: 5f, z: 0, ForceMode.Impulse);
        }
    }
    private void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal") * forceMultiplier;
        moveVertical = Input.GetAxis("Vertical") * forceMultiplier;
        rigidbody.AddForce(x: moveHorizontal, y: 0, z: moveVertical, ForceMode.Acceleration);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("coin"))
        {
            GameObject.Destroy(other.gameObject);
        }
    }
}
