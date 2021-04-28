using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool lockedByPassword;
    public DialogueTrigger trigger;
    public Animator anim;

    public void OpenClose()
    {
        if (lockedByPassword)
        {
            trigger.TriggerDialogue();

            Debug.Log("Nice");
            return;
        }

        anim.SetBool("OpenDoor", true);
    }

}
