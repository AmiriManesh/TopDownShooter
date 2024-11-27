using UnityEngine;

namespace Player.Movement
{
    public class Walk : MonoBehaviour
    {
        [SerializeField] private float speed = 0.5f;
        [SerializeField] private Rigidbody2D rigidBody;
        private Vector2 input;

        private Animator animator;
        private bool facingLeft = true;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }

        // Start is called before the first frame update
        private void Update()
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            input.Normalize();
        
        }

        // Update is called once per frame
        private void FixedUpdate()
        {
            rigidBody.velocity = input * speed * Time.deltaTime;
        }


    }
}
