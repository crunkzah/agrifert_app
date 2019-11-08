using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum DocumentType { other, pdf, doc, xlsx, jpg}


[System.Serializable]
public class TestItem
{
    public string test_name = "";
    public string url;
}

[CreateAssetMenu(fileName="RegionResults")]
public class RegionResults : ScriptableObject
{
    public string region_name = "Название региона";
    public DocumentType documentType;
    public List<TestItem> tests;
}
