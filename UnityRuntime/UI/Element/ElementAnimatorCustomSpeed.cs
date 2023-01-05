﻿
using UnityEngine;

namespace UnityTools.UnityRuntime.UI.Element
{
    public class ElementAnimatorCustomSpeed : MonoBehaviour
    {
        internal float AnimationSpeed => animationSpeed;

        [SerializeField] private float animationSpeed;
    }
}