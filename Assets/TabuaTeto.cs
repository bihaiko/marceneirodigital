using UnityEngine;

[RequireComponent(typeof(Tabua))]
public class TabuaTeto : MonoBehaviour {

    public Tabua tabua;
    public Movel movel;

    public void Update () {
        tabua.x = movel.largura;
        tabua.y = movel.profundidade;
        tabua.z = movel.tabuaExterna;

        transform.position = new Vector3(0, movel.altura/2 - movel.tabuaExterna/2, 0);
    }
}
