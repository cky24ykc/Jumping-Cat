using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static float time = 0;
    [SerializeField]
    public static float besttime=0;
    Vector3 initialPosition;

    public float walkForce = 30.0f;
    public float jumpForce = 700.0f;
    public float MaxWalkSpeed = 3.0f;
    int key = 0;

    Rigidbody2D rigid2D;

    GameObject groundPoint;
    public bool isGround=false;

    Animator animator;

    void Start()
    {
        rigid2D = gameObject.GetComponent<Rigidbody2D>();
        groundPoint = GameObject.Find("GroundPoint");
        animator = GetComponent<Animator>();
        initialPosition = transform.position;
    }

    
    void Update()
    {
        time += Time.deltaTime;

        //horizontal movement
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        float speedx = Mathf.Abs(rigid2D.velocity.x);
        if (speedx < MaxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        //direction
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        //vertical movement
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rigid2D.AddForce(transform.up * jumpForce);
            animator.SetTrigger("JumpTrigger");
        }

        //animaton speed
        if (isGround)
        {
            animator.speed = speedx / 2.0f;
        }
        else
        {
            animator.speed = 1.0f;
        }

        //retry
        if (transform.position.y < -5)
        {
            transform.position = initialPosition;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "flag")
        {
            if (besttime == 0 || besttime > time)
            {
                besttime = time;
                PlayerPrefs.SetFloat("BestTime", besttime);
            }
            SceneManager.LoadScene("GameOver");
        }
    }
}
