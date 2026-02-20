using Controller;
using Core;
using UnityEngine;
namespace VFX
{
    public class FruitCollectVFXController : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private FruitRecollection fruitRecollection;
        [SerializeField] private Canvas canvas;
        [SerializeField] private RectTransform canvasRoot;
        [Header("Target (drag a Transform/RectTransform here)")]
        [SerializeField] private Transform inventoryTargetTransform;
        [Header("FX Prefabs per Fruit Type (must be RectTransform)")]
        [SerializeField] private FlyToInventoryFX appleFxPrefab;
        [SerializeField] private FlyToInventoryFX bananaFxPrefab;
        [SerializeField] private FlyToInventoryFX mangoFxPrefab;
        [Header("Spawn Tuning")]
        [SerializeField, Min(1)] private int maxIconsPerCollect = 6;
        [SerializeField, Min(0f)] private float spawnScatter = 16f;
        private Camera worldCam;
        private Camera uiCam;
        private void Awake()
        {
            if (canvas != null && canvasRoot == null)
                canvasRoot = canvas.GetComponent<RectTransform>();
            worldCam = Camera.main;
            uiCam = (canvas != null && canvas.renderMode != RenderMode.ScreenSpaceOverlay) ? canvas.worldCamera : null;
        }
        private void OnEnable()
        {
            if (fruitRecollection != null)
                fruitRecollection.FruitCollected += OnFruitCollected;
        }
        private void OnDisable()
        {
            if (fruitRecollection != null)
                fruitRecollection.FruitCollected -= OnFruitCollected;
        }
        private void OnFruitCollected(FruitType type, int amount, Vector3 worldPos)
        {
            if (amount <= 0) return;
            if (canvas == null || canvasRoot == null || inventoryTargetTransform == null) return;
            if (worldCam == null) worldCam = Camera.main;
            if (worldCam == null) return;
            FlyToInventoryFX prefab = GetPrefab(type);
            if (prefab == null) return;
            int iconsToSpawn = amount > maxIconsPerCollect ? maxIconsPerCollect : amount;
            Vector2 endAnchored = TransformToCanvasAnchored(inventoryTargetTransform);
            for (int i = 0; i < iconsToSpawn; i++)
            {
                Vector2 startAnchored = WorldToCanvasAnchored(worldPos);

                if (spawnScatter > 0f)
                    startAnchored += Random.insideUnitCircle * spawnScatter;

                FlyToInventoryFX fx = Instantiate(prefab, canvasRoot);
                fx.transform.SetAsLastSibling();
                fx.Play(startAnchored, endAnchored);
            }
        }
        private FlyToInventoryFX GetPrefab(FruitType type)
        {
            return type switch
            {
                FruitType.Manzana => appleFxPrefab,
                FruitType.Banano  => bananaFxPrefab,
                FruitType.Mango   => mangoFxPrefab
            };
        }
        private Vector2 WorldToCanvasAnchored(Vector3 worldPos)
        {
            Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(worldCam, worldPos);

            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvasRoot,
                screenPoint,
                uiCam,
                out Vector2 localPoint
            );
            return localPoint;
        }
        private Vector2 TransformToCanvasAnchored(Transform target)
        {
            Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(uiCam, target.position);
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvasRoot,
                screenPoint,
                uiCam,
                out Vector2 localPoint
            );
            return localPoint;
        }
    }
}