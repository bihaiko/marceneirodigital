using UnityEngine;

[ExecuteInEditMode]
public class Externo : MonoBehaviour {

    private Movel movel;
    private Sustentacao sustentacao;

    public void Update(){

        if (movel == null) movel = FindObjectOfType<Movel>();
        if (sustentacao == null) sustentacao = movel.GetComponentInChildren<Sustentacao>();

        transform.localScale = new Vector3(movel.largura, movel.altura - sustentacao.altura, movel.profundidade);
        transform.position = new Vector3(0, sustentacao.altura/2, 0);
    }
}