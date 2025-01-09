using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandData : MonoBehaviour
{
    public enum HandModeType { left,Right}

    public HandModeType handType;
    public Transform root;
    public Animator animator;
    public Transform[] FingerBones;
}
