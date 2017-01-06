using UnityEngine;

[ExecuteInEditMode]
public class Divisao : MonoBehaviour {

	private Movel movel;
	private Modulos modulos;
	private DivisaoInterna interna;
	private Tabua tabua;

	public Modulo modulo;
	public float peso = 1;
	public float pesoTotal = 1;
	public float h;

	public void Update () {
		if (movel == null) movel = FindObjectOfType<Movel>();
		if (modulos == null) modulos = movel.GetComponentInChildren<Modulos> ();
		if (interna == null) interna = GetComponentInChildren<DivisaoInterna> ();
		if (tabua == null) tabua = GetComponentInChildren<Tabua> ();

		EncontraPesoTotal ();
		SetScale ();
		SetPofition ();
	}

	private void EncontraPesoTotal(){
		Divisao[] divisoes = transform.parent.GetComponentsInChildren<Divisao>();
		pesoTotal = 0;
		foreach (Divisao current in divisoes)
			pesoTotal = pesoTotal + current.peso;
	}

	private void SetScale(){
		Vector3 scale = modulo.transform.localScale;
		interna.transform.localScale = new Vector3 (scale.x, scale.y*peso/pesoTotal, scale.z);
	}

	private void SetPofition(){
		Vector3 pos = modulo.transform.position;

		h = 0;
		DivisaoInterna[] divisoes = transform.parent.GetComponentsInChildren<DivisaoInterna>();
		foreach (DivisaoInterna di in divisoes) {
			if (transform == di.transform.parent) break;
			h = h + di.transform.localScale.y;
		}

		Vector3 scale = modulo.transform.localScale;
		transform.position = new Vector3 (pos.x, pos.y -h -interna.transform.localScale.y/2 +scale.y/2, pos.z);
	}
}