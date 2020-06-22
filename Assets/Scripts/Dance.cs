using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public AudioSource thriller;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        // Dançar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("dance");
            thriller.Play();
        }

        if (!thriller.isPlaying)
        {
            animator.ResetTrigger("dance");
        }

    }
}
