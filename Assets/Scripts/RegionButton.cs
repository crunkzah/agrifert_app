using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionButton : MonoBehaviour
{

    public RegionResults region_results;

    public void Click()
    {
        RegionResultsSetter.singleton.Check();
        RegionResultsSetter.singleton.SetRegionResults(region_results);
        RegionResultsSetter.singleton.InstantiateButtons();
    }
}
