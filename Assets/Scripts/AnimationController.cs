using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    public void PlayRun()
    {
        anim.Play("MaxFree-Run");
    }

    public void PlayJump()
    {
        anim.Play("MaxFree-JumpA");
    }
    public void PlayLeft()
    {
        anim.Play("MaxFree-Left");
    }
    public void PlayRight()
    {
        anim.Play("MaxFree-Right");
    }
    public void PlayFall()
    {
        anim.Play("MaxFall-Back");
    }
}
