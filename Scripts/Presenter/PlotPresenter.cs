using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

public class PlotPresenter : MonoBehaviour
{
    public UnityEvent EndPresent;

    [SerializeField] private PlotContainer container;
    [SerializeField] private Image presentImage;

    private Plot CurrentPlot => container.CurrentPlot;
    private int _currentIndex;

    private void Start()
    {
        Apply();
    }

    public void OnNext(CallbackContext context)
    {
        if (context.performed)
        {
            _currentIndex++;
            Apply();
        }
    }

    private void Apply()
    {
        if (_currentIndex < CurrentPlot.Script.Count)
        {
            presentImage.sprite = CurrentPlot.Script[_currentIndex].Background;
        }
        else
        {
            EndPresent?.Invoke();
        }
    }
}
