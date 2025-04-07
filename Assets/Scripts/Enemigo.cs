using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    #region Private
    private string nombre;
    private int salud;
    private int scoreAlMorir;
    #endregion

    #region Getters
    public string Nombre => nombre;
    public int Salud => salud;
    public int ScoreAlMorir => scoreAlMorir;
    #endregion

    #region Constructor
    public Enemigo(string _nombre, int _salud, int _scoreAlMorir)
    {
        nombre = _nombre;
        salud = _salud;
        scoreAlMorir = _scoreAlMorir;
        Debug.Log("Se ha creado el enemigo: " + nombre + " con " + salud + " de salud y " + scoreAlMorir + " de score al morir.");
    }
    #endregion

    #region Métodos
    public void RecibirDaño(int danio)
    {
        salud -= danio;
        Debug.Log(nombre + " ha recibido " + danio + " de daño. Salud restante: " + salud);
        if (salud <= 0)
        {
            Morir();
        }
    }
    public void Morir()
    {
        Debug.Log(nombre + " ha muerto.");
        GameManager.AumentarScore(scoreAlMorir);
    }

    ~Enemigo()
    {
        Debug.Log("Destructor llamado de " + nombre);
    }
    #endregion
}
