using UnityEngine;

public class Personaje : MonoBehaviour
{
    #region Private
    private string charName;
    private string description;
    #endregion
    #region Getters
    public string CharName => charName;
    public string Description => description;
    #endregion
    #region Constructors
    public Personaje()
    {
        charName = "null";
        description = "null";
    }
    public Personaje(string _charName, string _description)
    {
        charName = _charName;
        charName = _description;
    }
    public void OnDestroy()
    {
        print("Me han destruido zhasbot!");
    }
    #endregion
    #region Methods
    #endregion
    /*~Personaje()
   {
       print("Me han destruido zhasbot!");
   }*/
}


