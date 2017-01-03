using UnityEngine;

[ExecuteInEditMode]
public class GUIController : MonoBehaviour {

    private Movel movel;
    private Modulos modulos;

    public GameObject zeroIndex;
    public GameObject otherIndex;

    public int maxIndex;
    public int index=0;

    public void Update () {
        if (movel == null) movel = FindObjectOfType<Movel>();
        if (modulos == null) modulos = movel.GetComponentInChildren<Modulos>();

        maxIndex = modulos.quantidade;

        if (index < 0) index = maxIndex;
        if (index > maxIndex) index = 0;

        zeroIndex.SetActive(index == 0);
        otherIndex.SetActive(index != 0);
    }

    public void IncremetIndex() { index++; }
    public void DecremetIndex() { index--; }
}
