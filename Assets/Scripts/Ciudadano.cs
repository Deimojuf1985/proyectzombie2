using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour
{
	public DateCitizen _citi; // instancia de la estructura de los ciudadanos 

	void Start () 
	{
		_citi.name = (Senso)Random.Range(1, 20); //random para los nombres de los ciudadanos 
		_citi.age = Random.Range(15, 101);// ramdom para las edades de los cuudadanos 
	}
}

