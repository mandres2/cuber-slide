using UnityEngine;

public class player_movement : MonoBehaviour
{
    // public RigidBody refers to a component which in this case is 'rb'.
    public Rigidbody rb;

    // Note: Since these values are float variables, you need to denote it with an 'f'. If you do not denote it with 'f' Unity will send an error via console. 
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private void Start()
    {
        Debug.Log("Game Start");
    }

    // This is marked as "Fixed"Update because I am using it to implement physic notation.
    void FixedUpdate ()
    {   // rb concatenated with the method AddForce needs arguments for the x, y, and z parameters.
        // Note: Implemented a forward force to the object.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            // Only executed if the conditions are met.
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            // Only executed if the conditions are met.
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
