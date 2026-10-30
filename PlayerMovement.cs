using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] Animator animator;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0f, z);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        animator.SetFloat("H", x);
        animator.SetFloat("V", z);
    }

}