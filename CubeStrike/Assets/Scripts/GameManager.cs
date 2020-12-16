using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameRunning = true ;
    public GameObject levelCompleteUI;
    public void LevelComplete()
    {
        levelCompleteUI.SetActive(true);

    }
    public void EndGame(){
        if(GameRunning)
        {
            // Debug.Log("Level Lost");
            GameRunning = false;
            Invoke("restart",2f);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
