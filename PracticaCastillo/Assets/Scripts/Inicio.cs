using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    public GameObject prefab;
    public GameObject padre;
    private List<Color> listacolor;
    public GameObject prefab2;
    public GameObject puente;

    // Use this for initialization
    void Start() {

        listacolor = new List<Color>(4);
        listacolor.Add(Color.blue);
        listacolor.Add(Color.red);
        listacolor.Add(Color.green);
        listacolor.Add(Color.yellow);



       
            //Pilares principales
            for (int i = 0; i < 4; i++)
            {
                GameObject hijo = (GameObject)Instantiate(prefab, new Vector3(6.0f, (i * 2.0f), 0.0f), transform.rotation);
                hijo.transform.parent = padre.transform;
                Color color = listacolor[Random.Range(0, listacolor.Count)];
                hijo.GetComponent<Renderer>().material.color = color;

                GameObject hijo2 = (GameObject)Instantiate(prefab, new Vector3(-6.0f, (i * 2.0f), 0.0f), transform.rotation);
                hijo2.transform.parent = padre.transform;
                Color color2 = listacolor[Random.Range(0, listacolor.Count)];
                hijo2.GetComponent<Renderer>().material.color = color2;

                GameObject hijo3 = (GameObject)Instantiate(prefab, new Vector3(0.0f, (i * 2.0f), 0.0f), transform.rotation);
                hijo3.transform.parent = padre.transform;
                Color color3 = listacolor[Random.Range(0, listacolor.Count)];
                hijo3.GetComponent<Renderer>().material.color = color3;
            }

            //Central

            for (int j = 1; j <= 2; j++){
                
                GameObject hijo4 = (GameObject)Instantiate(prefab, new Vector3(j*2.0f, 4.0f, 0.0f), transform.rotation);
                hijo4.transform.parent = padre.transform;
                Color color4 = listacolor[Random.Range(0, listacolor.Count)];
                hijo4.GetComponent<Renderer>().material.color = color4;

                GameObject hijo5 = (GameObject)Instantiate(prefab, new Vector3(j*(-2.0f), 4.0f, 0.0f), transform.rotation);
                hijo5.transform.parent = padre.transform;
                Color color5 = listacolor[Random.Range(0, listacolor.Count)];
                hijo5.GetComponent<Renderer>().material.color = color5;
                
            }

            //pilares pequeños
            for (int k = 3; k <= 4; k++){

                GameObject hijo6 = (GameObject)Instantiate(prefab, new Vector3(3.0f, k*2.0f, 0.0f), transform.rotation);
                hijo6.transform.parent = padre.transform;
                Color color6 = listacolor[Random.Range(0, listacolor.Count)];
                hijo6.GetComponent<Renderer>().material.color = color6;

                GameObject hijo7 = (GameObject)Instantiate(prefab, new Vector3(-3.0f, k*2.0f, 0.0f), transform.rotation);
                hijo7.transform.parent = padre.transform;
                Color color7 = listacolor[Random.Range(0, listacolor.Count)];
                hijo7.GetComponent<Renderer>().material.color = color7;
            }

            //torre
            GameObject hijo8 = (GameObject)Instantiate(prefab2, new Vector3(-6.5f, 7.5f, 0.0f), transform.rotation);
            hijo8.transform.parent = padre.transform;
            Color color8 = listacolor[Random.Range(0, listacolor.Count)];
            hijo8.GetComponent<Renderer>().material.color = color8;

            GameObject hijo9 = (GameObject)Instantiate(prefab2, new Vector3(5.5f, 7.5f, 0.0f), transform.rotation);
            hijo9.transform.parent = padre.transform;
            Color color9 = listacolor[Random.Range(0, listacolor.Count)];
            hijo9.GetComponent<Renderer>().material.color = color9;

            //Central2


                GameObject hijo10 = (GameObject)Instantiate(prefab, new Vector3( 3.0f, 10.0f, 0.0f), transform.rotation);
                hijo10.transform.parent = padre.transform;
                Color color10 = listacolor[Random.Range(0, listacolor.Count)];
                hijo10.GetComponent<Renderer>().material.color = color10;

                GameObject hijo11 = (GameObject)Instantiate(prefab, new Vector3(-3.0f, 10.0f, 0.0f), transform.rotation);
                hijo11.transform.parent = padre.transform;
                Color color11 = listacolor[Random.Range(0, listacolor.Count)];
                hijo11.GetComponent<Renderer>().material.color = color11;

                 GameObject hijo12 = (GameObject)Instantiate(prefab, new Vector3(0.0f, 10.0f, 0.0f), transform.rotation);
                 hijo12.transform.parent = padre.transform;
                  Color color12 = listacolor[Random.Range(0, listacolor.Count)];
                hijo12.GetComponent<Renderer>().material.color = color12;
           
            //puente
            GameObject hijo13 = (GameObject)Instantiate(puente, new Vector3(0.0f, 12.0f, 0.0f), transform.rotation);
            hijo13.transform.parent = padre.transform;
            Color color13 = listacolor[Random.Range(0, listacolor.Count)];
            hijo13.GetComponent<Renderer>().material.color = color13;

                




    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
