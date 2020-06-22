using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MJacksonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    private bool front, back, left, right;

    void Start()
    {
        animator = GetComponent<Animator>();
        front = false;
        back = false;
        left = false;
        right = false;
    }
    // Update is called once per frame
    void Update()
    {
        // Moonwalk
        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetTrigger("moonwalk");
        }

        // Saltar
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("jump");
        }

        // Correr Frente
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("run", true);
            front = true;
        } 
        else if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("run", false);
            front = false;
        }

        // Correr Trás
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("run", true);
            back = true;
            transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("run", false);
            back = false;
            transform.Rotate(0.0f, -180.0f, 0.0f, Space.Self);
        }

        // Correr Esquerda
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetBool("run", true);
            left = true;
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("run", false);
            left = false;
            transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
        }

        // Correr Direita
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("run", true);
            right = true;
            transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("run", false);
            right = false;
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }

        Vector3 move = transform.position;

        if (front)
        {
            //Debug.Log("correndo");
            move.z = move.z - 0.01f; ;
            transform.position = move;
        } 
        else if(back)
        {
            //Debug.Log("correndo");
            move.z = move.z + 0.01f; ;
            transform.position = move;
        }
        else if (left)
        {
            //Debug.Log("correndo");
            move.x = move.x - 0.01f; ;
            transform.position = move;
        }
        else if (right)
        {
            //Debug.Log("correndo");
            move.x = move.x + 0.01f; ;
            transform.position = move;
        }
        else
        {
            //Debug.Log("parou");
        }

    }
}
