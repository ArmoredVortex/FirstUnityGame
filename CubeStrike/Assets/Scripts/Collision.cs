using UnityEngine;

public class Collision : MonoBehaviour
{
    public PlayerMovement playerMovement ;
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
