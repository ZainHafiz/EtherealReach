using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrangeDoor : MonoBehaviour
{
    public Animator animator;

    public void OpenDoor()
    {
        animator.SetBool("IsOpen", true);
    }
    

}
