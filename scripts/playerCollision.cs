using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public player_movement movement;  // A reference to our PlayerMovement Script

    // This function runs when we hit another object
    // We get information about the collision and call it "collisionInfo."
    private void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        // Testing Script: We check to see if the object we collided with has a tag called "Obstacle."
        Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Blockade")
        {
            movement.enabled = false;
            // Debug.Log("Target Hit Blockade.");
            // GetComponent<player_movement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
