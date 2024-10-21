using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator MushMom;
        
    // _animator 세팅 
    void Awake()
    {
        MushMom = GetComponent<Animator>();
    }
    
    void OnMouseDown()
    {
        // animationVariable을 수정
        MushMom.SetInteger("Idle", 0);
        MushMom.SetInteger("Jump", 1);
        MushMom.SetInteger("Attacked", 2);
    }
}
