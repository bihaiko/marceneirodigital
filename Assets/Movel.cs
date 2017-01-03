using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Movel : MonoBehaviour {

    public int altura { get { return int.Parse(txtAltura.text); }}
    public int largura { get { return int.Parse(txtLargura.text); } }
    public int profundidade { get { return int.Parse(txtProfundidade.text); } }
    public int tabuaExterna { get { return int.Parse(txtTabuaExterna.text); } }
    public int tabuaInterna { get { return int.Parse(txtTabuaInterna.text); } }
    public bool comPorta { get { return chkPorta.isOn; } }
    public bool comFundo { get { return chkFundo.isOn; } }

    public enum TipoEspessura { Externa, Interna, Nenhuma };

    public InputField txtAltura;
    public InputField txtLargura;
    public InputField txtProfundidade;
    public InputField txtTabuaExterna;
    public InputField txtTabuaInterna;
    public Toggle chkPorta;
    public Toggle chkFundo;

    private TabuaFundo fundo;

    public void Update(){

        if (fundo == null)
            fundo = transform.GetComponentInChildren<TabuaFundo>();

        fundo.gameObject.SetActive(comFundo);
    }
}