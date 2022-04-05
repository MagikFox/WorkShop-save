using UnityEngine;

public class MoveController : MonoBehaviour
{
    [Header("General:")]
    public float moveSpeed = 2.5f;
    public Transform toRotateWithX;
    [Header("Movement Restriction:")]
    public bool lockHorizontal = false;
    public bool lockVertical = false;
    [Header("PhysX specifics:")]
    public Collider2D myFeet;
    public Rigidbody2D body2D;
    public float jumpForce = 5.5f;
    Animator m_Animator;

    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!lockHorizontal)
        {
            MoveHorizontal(Input.GetAxis("Horizontal"));
        }
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
            m_Animator.SetBool("Walk", true);
        else
            m_Animator.SetBool("Walk", false);


        if (!lockVertical)
        {
            MoveVertical(Input.GetAxis("Vertical"));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public void SetJumpForce(float force){
        jumpForce = force;
    }

    public void MoveHorizontal(float direction)
    {
        if (body2D)
        {
            Vector2 newVelocity = body2D.velocity;
            newVelocity.x = direction * moveSpeed;
            body2D.velocity = newVelocity;
            Debug.Log("Horizontal if");
        } else
        {
            transform.position += Vector3.right * direction * moveSpeed * Time.deltaTime;
            Debug.Log("Horizontal");
        }
            

        Flip(direction);
    }

    public void MoveVertical(float direction)
    {
        if (body2D)
        {
            Vector2 newVelocity = body2D.velocity;
            newVelocity.y = direction * moveSpeed;
            body2D.velocity = newVelocity;
        } else
        {
            transform.position += Vector3.up * direction * moveSpeed * Time.deltaTime;
        }
            
    }

    public void Jump()
    {
        if (body2D && myFeet && myFeet.IsTouchingLayers())
            body2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    public void Flip(float direction)
    {
        if (!toRotateWithX)
            return;

        if (direction > 0)
            toRotateWithX.rotation = Quaternion.Euler(0, 0, 0);
        else if (direction < 0)
            toRotateWithX.rotation = Quaternion.Euler(0, -180, 0);
    }
}
