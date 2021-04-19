using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehavior : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("x"))
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            if (Input.GetKey("z"))
                anim.SetBool("IsDying", true);
            else
                anim.SetBool("IsWalking", false);
        }
           


    }
}
