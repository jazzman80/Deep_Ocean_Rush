using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePanel : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;
    [SerializeField] private LifeIndicator[] indicators = new LifeIndicator[3];

    private void Start()
    {
        SetIndicators(appVariables.Life);
    }

    private void SetIndicators(int lives)
    {
        for (int i = 0; i < lives; i++)
        {
            indicators[i].SwitchOn();
        }
    }

    public void UpdateLife()
    {
        indicators[appVariables.Life].SwitchOn();
    }
}
