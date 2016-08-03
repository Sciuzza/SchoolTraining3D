using UnityEngine;
using System.Collections;

public class MoveGuybrush : MonoBehaviour {

    public Animator animator;

    bool facingRight = true;

    void Update () {

        int currentSpeed = 0;

        if (Input.GetKey(KeyCode.D))
        {
            currentSpeed = 5;
            facingRight = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            currentSpeed = -5;
            facingRight = false;
        }

        transform.Translate(transform.right * currentSpeed * Time.deltaTime);

        animator.SetInteger("XSpeed", currentSpeed);
        animator.SetBool("FacingRight", facingRight);
    }
}
