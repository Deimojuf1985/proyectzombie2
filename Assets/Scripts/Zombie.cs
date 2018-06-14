using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
	public DatesZombie _zonbi; // instancia de la estructura zombie 

	int rnd; //entero que llame rnd para el random del caso

	Estado estado; // enum estado

	int moving; //idle es el estado en movimiento del zombie 

	// esta es una coorutina que cada 5 segundos me realizar un random en el estado y la direccion del zombie
	IEnumerator MovimientoZombie ()
	{
		yield return new WaitForSeconds(5); // estoy diciendo que me espere 5 segundos para llamar el ramdom de los estados
		estado = (Estado) Random.Range(0,2); // llamando los estados 
		rnd = Random.Range(0, 4);// realizado el ramdom de los estados se llama este que es el ramdom de los movimientos 
		StartCoroutine (MovimientoZombie ()); // iniciando la corrutina Movimiento zombie
	}
	void Start()
	{
		_zonbi.part = (Body)Random.Range (0, 5); // ramdon de de las partes del cuerpo
		StartCoroutine (MovimientoZombie ());// llamando e iniciando la corrutina Movimiento zombie
	}

     void Update () 
	{
		//switch que me controla los estados idle y moving del zombie 
		switch (estado) 
		{
		case Estado.idle: // zombie quieto
			break;
		case Estado.moving: // zombie en movimiento
			 Moving (); //llamando el metodo del movimiento
			break;
		}
	}
	//metodo que contiene un switch con los movimientos del zombie 
	public void Moving()
	{
		_zonbi.Speed = 1.7f; // defini la velocidad del zombie a 1.7float
		switch (rnd)
		{
		case 0:
			transform.position += transform.forward * _zonbi.Speed * Time.deltaTime; //avanzar hacia adelante 
			break;
		case 1:
			transform.position -= transform.forward * _zonbi.Speed * Time.deltaTime;	//avanzar hacia atras
			break;
		case 2:
			transform.position += transform.right * _zonbi.Speed * Time.deltaTime; // avanzar hacia la izquierda
			break;
		case 3:
			transform.position -= transform.right * _zonbi.Speed * Time.deltaTime; // avanzar hacia la derecha
			break;
		}
	}
}
