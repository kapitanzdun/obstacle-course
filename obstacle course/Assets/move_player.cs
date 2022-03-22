using UnityEngine;

public class move_player : MonoBehaviour
{
    public Rigidbody Rb;

    public float forwardForse = 5f ; 

    // Update is called once per frame
    void FixedUpdate ()
    {
        Rb.AddForce(forwardForse , 0, 0 * Time.deltaTime);
    }
}

