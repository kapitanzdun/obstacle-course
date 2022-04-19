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
            Rb.AddForce(0,0,-sidewaysForse* Time.deltaTime, ForceMode.VelocityChange );
        }

        if(Input.GetKey("s"))
        {
            Rb.AddForce(0,0,sidewaysForse* Time.deltaTime ,ForceMode.VelocityChange);
        }
        
        if (Rb.position.y < -1f)
        {
           FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}

