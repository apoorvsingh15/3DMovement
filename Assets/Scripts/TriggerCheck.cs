using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
     public Animator doorAnim;
    private void OnTriggerEnter(Collider other)
    {
        doorAnim.enabled = true;

        doorAnim.SetBool("isOpen_Obj_1", true);
        
    }

    private void OnTriggerExit(Collider other)
    {
        doorAnim.SetBool("isOpen_Obj_1", false);
    }
}
