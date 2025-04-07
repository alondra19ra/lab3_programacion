using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero : Personaje
{
    #region Private
    private int ira;
    #endregion

    #region Getters
    public int Ira => ira;
    #endregion

    #region Contructor
    public Guerrero(string _charName, string _description, int _wisdom, int _ira) : base(_charName, _description)
    {
        ira = _ira;
    }
    public void AtacarIra()
    {
        Debug.Log(CharName + "Ataca con ira!! " + "daño aumentado en ira " + ira);
    }
    #endregion

}
public class Example : MonoBehaviour
{
    void Start()
    {
        Guerrero guerrero = new Guerrero("Aragorn", "Noble Warrior", 10, 50);

        Debug.Log("Guerrero Nombre: " + guerrero.CharName);
        Debug.Log("Guerrero Descripcion: " + guerrero.Description);
        Debug.Log("Guerrero Ira: " + guerrero.Ira);
        guerrero.AtacarIra();
    }
}


