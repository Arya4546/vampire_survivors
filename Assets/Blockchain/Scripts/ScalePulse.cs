using UnityEngine;

namespace Vampire
{
    using UnityEngine;
    using DG.Tweening;

    public class ScalePulse : MonoBehaviour
    {
        [Header("Scale Settings")]
        public float minScale = 0.5f;
        public float maxScale = 1f;
        public float duration = 1.5f;

        void Start()
        {
            // Starting scale set to min
            transform.localScale = Vector3.one * minScale;

            // Tween
            transform.DOScale(maxScale, duration)
                     .SetEase(Ease.InOutSine)
                     .SetLoops(-1, LoopType.Yoyo);
        }
    }
}
