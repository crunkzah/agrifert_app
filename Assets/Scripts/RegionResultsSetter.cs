using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RegionResultsSetter : MonoBehaviour
{
    static RegionResultsSetter _instance;
    public static RegionResultsSetter singleton
    {
        get
        {
            if(_instance == null)
                _instance = FindObjectOfType<RegionResultsSetter>();

            return _instance;
        }
    }

    public RegionResults region_results_current;
    public TextMeshProUGUI label_tmp;

    public GameObject button_url_result_prefab;

    public void Check()
    {
        // Debug.Log("<color=green>Working!</color>");
        
    }

    public void SetRegionResults(RegionResults regions_results_new)
    {
        this.region_results_current = regions_results_new;

        label_tmp.SetText(regions_results_new.region_name);
        
        // if(this.region_results_current != null)
        //     Debug.Log("Region results <color=green>set.</color>");
        // else
        //     Debug.Log("Region results <color=red>not set.</color>");
    }

    public RectTransform results_buttons_holder;


    public void InstantiateButtons()
    {
        if(results_buttons_holder != null)
        {
            for(int i = 0; i < results_buttons_holder.childCount; i++)
            {
                GameObject obj_to_delete = results_buttons_holder.GetChild(i).gameObject;
                Destroy(obj_to_delete);
            }

            foreach(TestItem test_item_current in this.region_results_current.tests)
            {
                GameObject result_button = Instantiate(button_url_result_prefab, Vector3.zero, Quaternion.identity);
                result_button.GetComponent<RectTransform>().pivot = Vector2.zero;
                

                result_button.transform.SetParent(results_buttons_holder);
                result_button.transform.SetAsFirstSibling();

                result_button.GetComponent<RectTransform>().localScale = Vector3.one;

                Test_button test_button_component = result_button.GetComponent<Test_button>();

                test_button_component.test_item = test_item_current;
                test_button_component.SetButtonText();
            }

            results_buttons_holder.GetComponent<VerticalSizeFitter_fromGrid>().Resize(this.region_results_current.tests.Count);
        }
    }


}
