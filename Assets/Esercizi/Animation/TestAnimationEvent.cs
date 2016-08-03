using UnityEngine;
using System.Collections;

public class TestAnimationEvent : MonoBehaviour {

    public AnimationCurve curve;
    public AnimationCurve curve1;

    private Animator animator;


    void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsWalkingRight", true);
    }


    public void DoStuff()
    {
        Debug.Log("CIAO");

    }

    float time;
    void Update()
    {
        time += Time.deltaTime;

        Vector3 tmpPos = this.transform.position;
        tmpPos.x = curve.Evaluate(time);
        tmpPos.y = curve1.Evaluate(time);
        this.transform.position = tmpPos;
    }

}
