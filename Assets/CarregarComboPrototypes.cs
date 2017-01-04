using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarregarComboPrototypes : MonoBehaviour {

    private CopiaModulo cmodulo;
    private Dropdown dropdown;

    public void OnEnable(){

        if (cmodulo == null) cmodulo = FindObjectOfType<CopiaModulo>();
        if (dropdown == null) dropdown = GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<string> list = new List<string>();
        for (int i = 0; i < cmodulo.transform.childCount; i++)
            list.Add(cmodulo.transform.GetChild(i).name);

        dropdown.AddOptions(list);
    }
}
