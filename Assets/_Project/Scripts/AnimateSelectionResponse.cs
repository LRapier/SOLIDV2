using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateSelectionResponse : MonoBehaviour, ISelectionResponse
{
    private Quaternion _rotation;

    public void OnDeselect(Transform selection)
    {
        var animator = selection.GetComponent<Animator>();
        if (animator != null)
        {
            animator.enabled = false;
            selection.GetComponent<Transform>().rotation = _rotation;
        }
    }

    public void OnSelect(Transform selection)
    {
        var animator = selection.GetComponent<Animator>();
        _rotation = selection.rotation;
        if (animator != null)
        {
            animator.enabled = true;
        }
    }
}
