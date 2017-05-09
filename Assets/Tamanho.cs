using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tamanho : MonoBehaviour {
	public GameObject esq, dir, cim, baix;
	float sizeRate = 0.1f;
	// Use this for initialization
	void Start () {
		
	}

	public void IncrementaTamanho(){
		AumentaEscala (esq);
		AumentaEscala (dir);
		AumentaEscala (cim);
		AumentaEscala (baix);
		esq.transform.Translate (-sizeRate, 0, 0);
		dir.transform.Translate (sizeRate, 0, 0);
		cim.transform.Translate (0, sizeRate, 0);
		baix.transform.Translate (0, -sizeRate, 0);
	}
	public void DecrementaTamanho(){
		AbaixaEscala (esq);
		AbaixaEscala (dir);
		AbaixaEscala (cim);
		AbaixaEscala (baix);
		esq.transform.Translate (sizeRate, 0, 0);
		dir.transform.Translate (-sizeRate, 0, 0);
		cim.transform.Translate (0, -sizeRate, 0);
		baix.transform.Translate (0, sizeRate, 0);

	}
	void AbaixaEscala(GameObject obj){
		obj.transform.localScale = new Vector3(obj.transform.localScale.x -sizeRate, obj.transform.localScale.y -sizeRate, obj.transform.localScale.z -sizeRate);
		//AjustaPosicao (obj);
	}
	void AumentaEscala(GameObject obj){
		obj.transform.localScale = new Vector3(obj.transform.localScale.x +sizeRate, obj.transform.localScale.y +sizeRate, obj.transform.localScale.z +sizeRate);
		//AjustaPosicao (obj);
	}

	void AjustaPosicao(GameObject obj){
		float delta = obj.transform.localScale.x;
		float magnetude = obj.transform.position.magnitude;
		obj.transform.position = new Vector3(delta * obj.transform.position.x/magnetude,delta * obj.transform.position.y/magnetude,obj.transform.position.z);
	}


	// Update is called once per frame
	void Update () {
		
	}
}
