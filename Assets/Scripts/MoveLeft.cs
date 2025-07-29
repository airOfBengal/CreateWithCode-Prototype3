using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);
    }
}
