using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
private Rigidbody2D body;
[SerializeField] public float speed;
private void Awake()
{
    body = GetComponent<Rigidbody2D>();
}
public void Update()
{
    float horizontalInput = Input.GetAxis("Horizontal");
    body.velocity = new Vector2(horizontalInput * speed ,body.velocity.y);
// Flip player when clicked on left or right
    if(horizontalInput > 0.01f)
    transform.localScale = Vector3.one;
    else if(horizontalInput < -0.01f)
    transform.localScale = new Vector3(-1,1,1);

    if(Input.GetKey(KeyCode.W))
        body.velocity = new Vector2(body.velocity.x,speed);
}

}
