﻿//this empty line for UTF-8 BOM header
using UnityEngine;
using UnityEngine.UI;

namespace UnityTools.UnityRuntime.UI.Element.Animations
{
    public class AnimateSize : AnimationBase
    {
        [SerializeField] private Vector2 sizeVisible;
        [SerializeField] private Vector2 sizeHidden;
        [SerializeField] private bool canBeDisabledWhenInvisible = true;

        private RectTransform rectTransform;

        protected override void Init()
        {
            this.rectTransform = GetComponent<RectTransform>();
        }

        internal override bool CanBeDisabledWhenInvisible => canBeDisabledWhenInvisible;

        protected override void ApplyVisibility(float visibility)
        {
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.Lerp(sizeHidden.x, sizeVisible.x, visibility));
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.Lerp(sizeHidden.y, sizeVisible.y, visibility));
            LayoutRebuilder.MarkLayoutForRebuild(rectTransform);
        }
    }
}
