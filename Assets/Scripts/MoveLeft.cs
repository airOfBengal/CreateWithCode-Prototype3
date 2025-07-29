using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody rb;
    private PlayerController playerController;
    public float leftBound = -15f;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.gameOver == false)
        {            
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
        
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
