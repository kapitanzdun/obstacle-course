using UnityEngine;

public class move_player : MonoBehaviour
{
    public Rigidbody Rb;

    public float forwardForse = 2000f ;
    public float sidewaysForse = 500f;

    // Update is called once per frame
    void FixedUpdate ()
    {
        Rb.AddForce(forwardForse , 0, 0 * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            Rb.AddForce(0,0,-sidewaysForse* Time.deltaTime);
        }

        if(Input.GetKey("a"))
        {
            Rb.AddForce(0,0,sidewaysForse* Time.deltaTime);
        }

        if(Input.GetKey("w"))
        {
            Rb.AddForce(0,100+sidewaysForse* Time.deltaTime,0);
        }
    }
}

