using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true); 
        // Test Functionality: Debug.Log("LEVEL COMPLETED!");
    }
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
        gameHasEnded = true;
        Debug.Log("GAME OVER");
            // Since we want a delay when we restart the game we will use a function called: "invoke"
            Invoke("Restart", restartDelay);

        // Restart game
        // Restart();
        }
    }    

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
