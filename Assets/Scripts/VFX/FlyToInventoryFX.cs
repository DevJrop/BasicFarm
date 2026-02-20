using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace VFX
{
    public class FlyToInventoryFX : MonoBehaviour
    {
        [Header("Optional: if you want to set sprite per fruit type")]
        [SerializeField] private Image icon;

        [Header("Motion")]
        [SerializeField] private float duration = 0.6f;
        [SerializeField] private float arcHeight = 80f;

        [Header("Scale Pop")]
        [SerializeField] private float startScale = 0.85f;
        [SerializeField] private float peakScale = 1.12f;

        private RectTransform rect;

        private void Awake()
        {
            rect = GetComponent<RectTransform>();
            if (icon == null) icon = GetComponent<Image>();
        }

        public void SetSprite(Sprite sprite)
        {
            if (icon != null && sprite != null)
                icon.sprite = sprite;
        }

        // CAMBIO: ahora recibimos endAnchoredPos calculado en el mismo canvasRoot
        public void Play(Vector2 startAnchoredPos, Vector2 endAnchoredPos)
        {
            rect.anchoredPosition = startAnchoredPos;
            rect.localScale = Vector3.one * startScale;

            StopAllCoroutines();
            StartCoroutine(FlyRoutine(endAnchoredPos));
        }

        private IEnumerator FlyRoutine(Vector2 end)
        {
            Vector2 start = rect.anchoredPosition;

            float t = 0f;

            while (t < 1f)
            {
                t += Time.deltaTime / Mathf.Max(0.0001f, duration);
                float eased = EaseOutCubic(t);

                Vector2 pos = Vector2.LerpUnclamped(start, end, eased);

                float arc = Mathf.Sin(eased * Mathf.PI) * arcHeight;
                pos.y += arc;

                rect.anchoredPosition = pos;

                float pop = Mathf.Sin(eased * Mathf.PI);
                float scale = Mathf.Lerp(startScale, peakScale, pop);
                rect.localScale = Vector3.one * scale;

                yield return null;
            }

            rect.anchoredPosition = end;
            Destroy(gameObject);
        }

        private float EaseOutCubic(float x)
        {
            x = Mathf.Clamp01(x);
            float inv = 1f - x;
            return 1f - inv * inv * inv;
        }
    }
}