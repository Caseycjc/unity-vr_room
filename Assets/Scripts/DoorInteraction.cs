using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorInteraction : XRBaseInteractable
{
    public Animator doorAnimator;

    protected override void OnSelectEntered(SelectEnterEventArgs interactor)
    {
        base.OnSelectEntered(interactor);
        OpenDoor();
    }

    private void OpenDoor()
    {
        if (doorAnimator != null) // debug log if animator isnt working properly
        {
            doorAnimator.SetTrigger("OpenDoor");
        }
        else
        {
            Debug.LogWarning("Door Animator is not assigned");
        }
    }
}
