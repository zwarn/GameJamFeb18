using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject
{
    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;
    public int playerNumber = 1;

    private InputController inputController;
    private KeyCode jump = KeyCode.JoystickButton0;

    private SpriteRenderer spriteRenderer;
   //  private Animator animator;
   
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        // animator = GetComponent<Animator>();
    }

    public override void Start()
    {
		base.Start ();
        inputController = InputController.getInstance();
    }

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Spike") {
			transform.position = new Vector3 (-29.03f, 3.32f, 0f);
		}
	}

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = inputController.getAxis(playerNumber, "Horizontal");
        
        if (inputController.getButtonDown(playerNumber, jump, "Jump") && grounded)
        {
            velocity.y = jumpTakeOffSpeed;
        }
        else if (inputController.getButtonUp(playerNumber, jump, "Jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }

        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        // animator.SetBool("grounded", grounded);
        // animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);

        targetVelocity = move * maxSpeed;
    }
}