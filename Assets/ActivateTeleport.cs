using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleport : MonoBehaviour
{
    public GameObject LeftTeleportation;
    public GameObject RightTeleportation;

    public InputActionProperty leftActivate;
    public InputActionProperty RightActivate;

    public InputActionProperty Leftcancel;
    public InputActionProperty RightCancel;

    public XRRayInteractor leftRay;
    public XRRayInteractor RightRay;

    private void Update()
    {
        bool isleftrayhovering = leftRay.TryGetHitInfo(out Vector3 leftpos, out Vector3 leftnormal, out int leftnumber, out bool leftvalid);

        LeftTeleportation.SetActive(!isleftrayhovering && Leftcancel.action.ReadValue<float>()==0 && leftActivate.action.ReadValue<float>() > 0.1f);

        bool isRightrayhovering = leftRay.TryGetHitInfo(out Vector3 Rightpos, out Vector3 Rightnormal, out int Rightnumber, out bool Rightvalid);


        RightTeleportation.SetActive(!isRightrayhovering && RightCancel.action.ReadValue<float>() == 0 &&RightActivate.action.ReadValue<float>() > 0.1f);
    }
}
