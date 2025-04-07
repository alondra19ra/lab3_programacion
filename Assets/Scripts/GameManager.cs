using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Static
    private static int scoreTotal = 0;
    public static int ScoreTotal => scoreTotal;

    public static void AumentarScore(int puntos)
    {
        scoreTotal += puntos;
        Debug.Log("Score aumentado en " + puntos + ". Score total actual: " + scoreTotal);
    }
    #endregion

    void Start()
    {
        Enemigo enemigo = new Enemigo("Orco", 100, 30);
        enemigo.RecibirDaño(50);  // No muere aún
        enemigo.RecibirDaño(60);  // Lo mata
    }
}

