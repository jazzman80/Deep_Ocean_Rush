using UnityEngine;
using UnityEngine.UI;

public class StartLevelButton : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;
    [SerializeField] private Button button;

    private void Start()
    {
        if (appVariables.Life == 0) Deactivate();
    }

    private void Activate()
    {
        button.interactable = true;
    }

    private void Deactivate()
    {
        button.interactable = false;
    }
}
