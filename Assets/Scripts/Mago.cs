using System;
using System.Collections.Generic;
using UnityEngine;

public class Mago : Personaje
{
    #region Private
    private int wisdom;
    private int mana;
    #endregion
    #region Getters
    public int Wisdom => wisdom;
    public int Mana => mana;
    #endregion

    #region Contructor
    public Mago(string _charName, string _description, int _wisdom, int _mana) : base(_charName, _description)
    {
        wisdom = _wisdom;
        mana = _mana;
    }
    #endregion
    #region Copia
    public Mago(Mago copy) : base(copy.name, copy.Description)
    {
        wisdom = copy.wisdom;
        mana = copy.mana;
    }
    #endregion

}

