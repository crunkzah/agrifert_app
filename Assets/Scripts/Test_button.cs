using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Test_button : MonoBehaviour
{
    public TestItem test_item;
    public TextMeshProUGUI main_text;
    
    public Image doc_icon;

    public void SetButtonText()
    {
        if(test_item != null)
        {
            if(!test_item.Equals(string.Empty))
            {
                main_text.SetText(test_item.test_name);

            }
            else
            {
                main_text.SetText("-");
            }
            // if(!test_item.test_name.Equals(string.Empty))
            //     transform.GetChild(0).GetComponent<TextMeshProUGUI>().SetText(test_item.test_name);
            // else
            //     transform.GetChild(0).GetComponent<TextMeshProUGUI>().SetText(test_item.name);
        }
    }

    public void SetDocIcon(DocumentType doc_type)
    {
        switch(doc_type)
        {
            case DocumentType.other:
                doc_icon.gameObject.SetActive(false);
                

                break;
            case DocumentType.doc:
                doc_icon.gameObject.SetActive(true);
                
                break;
            case DocumentType.pdf:
                doc_icon.gameObject.SetActive(true);
                break;
            case DocumentType.xlsx:
                doc_icon.gameObject.SetActive(true);
                break;
            case DocumentType.jpg:
                doc_icon.gameObject.SetActive(true);
                break;

        }
    }

    public void GoToUrl()
    {
        if(test_item != null)
        {
            WebManager.singleton.OpenURL(test_item.url);
        }
        else
            Debug.LogError("test_item <color=red>not set</color>");
    }
}
