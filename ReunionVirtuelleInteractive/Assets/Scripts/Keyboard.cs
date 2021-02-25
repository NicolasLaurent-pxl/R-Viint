using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    public Text Affichage;

    public void AddLetterA()
    {
        Affichage.text = Affichage.text + "a";
    }
    public void AddLetterZ()
    {
        Affichage.text = Affichage.text + "z";
    }
    public void AddLetterE()
    {
        Affichage.text = Affichage.text + "e";
    }
    public void AddLetterR()
    {
        Affichage.text = Affichage.text + "r";
    }
    public void AddLetterT()
    {
        Affichage.text = Affichage.text + "t";
    }
    public void AddLetterY()
    {
        Affichage.text = Affichage.text + "y";
    }
    public void AddLetterU()
    {
        Affichage.text = Affichage.text + "u";
    }
    public void AddLetterI()
    {
        Affichage.text = Affichage.text + "i";
    }
    public void AddLetterO()
    {
        Affichage.text = Affichage.text + "o";
    }
    public void AddLetterP()
    {
        Affichage.text = Affichage.text + "p";
    }
    public void AddLetterQ()
    {
        Affichage.text = Affichage.text + "q";
    }
    public void AddLetterS()
    {
        Affichage.text = Affichage.text + "s";
    }
    public void AddLetterD()
    {
        Affichage.text = Affichage.text + "d";
    }
    public void AddLetterF()
    {
        Affichage.text = Affichage.text + "f";
    }
    public void AddLetterG()
    {
        Affichage.text = Affichage.text + "g";
    }
    public void AddLetterH()
    {
        Affichage.text = Affichage.text + "h";
    }
    public void AddLetterJ()
    {
        Affichage.text = Affichage.text + "j";
    }
    public void AddLetterK()
    {
        Affichage.text = Affichage.text + "k";
    }
    public void AddLetterL()
    {
        Affichage.text = Affichage.text + "l";
    }
    public void AddLetterM()
    {
        Affichage.text = Affichage.text + "m";
    }
    public void AddLetterW()
    {
        Affichage.text = Affichage.text + "w";
    }
    public void AddLetterX()
    {
        Affichage.text = Affichage.text + "x";
    }
    public void AddLetterC()
    {
        Affichage.text = Affichage.text + "c";
    }
    public void AddLetterV()
    {
        Affichage.text = Affichage.text + "v";
    }
    public void AddLetterB()
    {
        Affichage.text = Affichage.text + "b";
    }
    public void AddLetterN()
    {
        Affichage.text = Affichage.text + "n";
    }
    public void AddLetterComa()
    {
        Affichage.text = Affichage.text + ",";
    }
    public void AddLetterPoint()
    {
        Affichage.text = Affichage.text + ".";
    }
    public void AddLetterTwoPoints()
    {
        Affichage.text = Affichage.text + ":";
    }
    public void AddLetterExcl()
    {
        Affichage.text = Affichage.text + "!";
    }
    public void AddLetterEspace()
    {
        Affichage.text = Affichage.text + " ";
    }
    public void RetourLigne()
    {
        Affichage.text = Affichage.text + '\n';
    }
    public void Back()
    {
        string s = Affichage.text;
        s = s.Remove(s.Length - 1);
        Affichage.text = s;
    }
}
