using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesMovement : MonoBehaviour
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
      
        // Saltar
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("jump");
        }

        // Correr Frente
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("run", true);
            front = true;
        } 
        else if(Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("run", false);
            front = false;
        }

        // Correr Trás
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("run", true);
            back = true;
            transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("run", false);
            back = false;
            transform.Rotate(0.0f, -180.0f, 0.0f, Space.Self);
        }

        // Correr Esquerda
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("run", true);
            left = true;
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("run", false);
            left = false;
            transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
        }

        // Correr Direita
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("run", true);
            right = true;
            transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
        }
        else if (Input.GetKeyUp(KeyCode.D))
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
