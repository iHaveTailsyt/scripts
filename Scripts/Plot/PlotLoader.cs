using UnityEngine;
using UnityEngine.SceneManagement;

public class PlotLoader : MonoBehaviour
{
    [SerializeField] private PlotContainer container; 

    public void LoadPlot(Plot plot)
    {
        container.CurrentPlot = plot;
        SceneManager.LoadScene(1);
    }
}
