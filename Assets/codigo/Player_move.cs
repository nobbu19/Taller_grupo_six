using UnityEngine;

public class Player_move : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inpux = Input.GetAxisRaw("Horizontal");

        float inpuY = Input.GetAxisRaw("Vertical");

        rb.linearVelocity = new Vector2(inpux,inpuY);
    }
}
