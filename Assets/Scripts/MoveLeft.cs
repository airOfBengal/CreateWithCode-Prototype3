using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody rb;

    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    //     rb.AddForce(Vector3.left * speed, ForceMode.VelocityChange);
    // }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);
    }
}
