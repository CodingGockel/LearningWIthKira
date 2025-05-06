using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float speed;

    void FixedUpdate()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        //transform.position = transform.position + movement * Time.deltaTime;
        //rb.velocity = new Vector2(movement.x, movement.y);
        rb.MovePosition(transform.position + (movement * speed * Time.deltaTime));

    }
}
