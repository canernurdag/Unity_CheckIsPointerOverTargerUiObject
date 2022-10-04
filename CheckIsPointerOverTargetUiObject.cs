using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckIsPointerOverTargetUiObject : MonoBehaviour
{
    private const string _uiTargetTag = ""; //Declare and define here
    public string UiTargetTag => _uiTargetTag;

    public bool IsPointerOverTargetUiObject(string targetGameObjectTag)
    {
    #if UNITY_EDITOR
            if (EventSystem.current.IsPointerOverGameObject())
            {
                if (EventSystem.current.currentSelectedGameObject != null)
                {
                    if (EventSystem.current.currentSelectedGameObject.CompareTag(targetGameObjectTag))
                    {
                        return true;
                    }
                }
            }
    #endif
    #if UNITY_ANDROID || UNITY_IOS
            if (EventSystem.current.IsPointerOverGameObject())
            {
                if (EventSystem.current.currentSelectedGameObject != null)
                {
                    if (EventSystem.current.currentSelectedGameObject.CompareTag(targetGameObjectTag))
                    {
                        return true;
                    }
                }
            }
    #endif

        return false;
    }
}
