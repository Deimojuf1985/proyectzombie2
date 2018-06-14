using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// enum que me contiene los nombres de los ciudadanos 
public enum Senso
{
    pepito, maria,socorro,apolonia,samantha,amira ,yesica, alucard,beliaf,isildur,
    tobias, tomas,elvira, michael, alejandro, tamara,merchan,maricarmen, jose, markus
}
//estuctura que me contiene un entero de edad y el enum para los nombres y edad de los ciudadanos  
public struct DateCitizen
{
    public int age; // edad del ciudadano
    public Senso name; // enum nombre del ciudadano que llame name
}

// estructura que me contiene los elementos del color y de las partes de cuerpo del zombie
public struct DatesZombie
{
    public Color[] col; // vector de los colores del zombie que llame coler 
    public Body part; // enum body de las partes del cuerpo que llame part 
    public float Speed; // velocidad flotante que se le da al zombie 

}
//enum que me tiene las partes del cuerpo del zombie
public enum Body
{
    Cabesa, piernas, brazos, torso, Cerebro
}
//enum que tiene idle que es cuando el zombie esta quieto y moving que esta en movimiento
public enum Estado
{
    idle, moving
}