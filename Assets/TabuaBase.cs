using UnityEngine;

[RequireComponent(typeof(Tabua))]
public class TabuaBase : MonoBehaviour {

    public Tabua tabua;
    public Movel movel;
    public Sustentacao sustentacao;

    public void Update () {

        if (movel == null) movel = FindObjectOfType<Movel>();
        if (tabua == null) tabua = GetComponent<Tabua>();
        if (sustentacao == null) sustentacao = movel.GetComponentInChildren<Sustentacao>();

        tabua.x = movel.largura;
        tabua.y = movel.profundidade;
        tabua.z = movel.tabuaExterna;

        transform.position = new Vector3(0, -movel.altura/2 + sustentacao.altura + movel.tabuaExterna/2, 0);
    }
}
