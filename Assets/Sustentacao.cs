using UnityEngine;

[ExecuteInEditMode]
public class Sustentacao : MonoBehaviour {

    public int altura = 100;
    public int recuo = 20;

    public Tipo tipo = Tipo.Rodas;
    public enum Tipo { Rodas, Soculo };

    private Movel movel;

    public void Update(){
        if (movel == null) movel = FindObjectOfType<Movel>();

        transform.localScale = new Vector3(movel.largura - 2*recuo, altura, movel.profundidade - 2* recuo);
        transform.position = new Vector3(0, -movel.altura/2 + altura/2, 0);
    }
}