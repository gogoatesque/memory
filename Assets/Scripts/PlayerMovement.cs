using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpspeed;
    [SerializeField] private float walkspeed;
    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;

    private void Awake ()
    {
        // Prend la référence des différentes fonctionss sur l'objet
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    } 

    private void Update ()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * walkspeed, body.velocity.y);

        // Retourne le personnage
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        if (Input.GetKey(KeyCode.UpArrow) && grounded)
            Jump();

        // Met en place le paramètre d'animation
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpspeed);
        anim.SetTrigger("jump");
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        grounded = true;
    }
}
