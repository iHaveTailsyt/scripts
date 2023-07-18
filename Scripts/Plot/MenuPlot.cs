using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MenuPlot : MonoBehaviour
{
    [SerializeField] private Plot plot;

    private Button _thumbnail;
    private PlotLoader _loader;

    private void Awake()
    {
        _thumbnail = GetComponent<Button>();
        _loader = FindObjectOfType<PlotLoader>();
    }

    private void OnEnable()
    {
        _thumbnail.onClick.AddListener(OnClick);
    }

    private void Start()
    {
        _thumbnail.image.sprite = plot.Thumbnail;
    }

    private void Update()
    {
        if _loader == NULL
        {
            break;
        }
    }

    private void OnDisable()
    {
        _thumbnail.onClick.RemoveListener(OnClick);
    }

    public void OnClick()
    {
        _loader.LoadPlot(plot);
    }
}
