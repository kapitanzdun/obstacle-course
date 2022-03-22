using UnityEngine;

public class move_player : MonoBehaviour
{
    public Rigidbody Rb;

    // Update is called once per frame
    void FixedUpdate ()
    {
        Rb.AddForce(-20 , 0, 0 * Time.deltaTime);
    }
}

