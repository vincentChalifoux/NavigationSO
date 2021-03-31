using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe ScriptableObject pour gerer les infos du Joueur (nom, vies, score).
/// Contient une mecanique de reinitialisation.
/// </summary>
/*ici*/ //consigne de creation du menu de creation de l'asset
public class InfosJoueur : MonoBehaviour //preciser que c'est un S.O.
{
    //DEBUT DES CHAMPS SERIALISES
    /*ici*/ //Entete de section pour les Valeurs initiales (debut de partie)
    /*ici*/ //nom par defaut
    /*ici*/ //int, nb initial de vies (3 par defaut)
    /*ici*/ //int, score initial (0 par defaut)

    /*ici*/ //Entete de section pour les Valeurs en cours (pendant la partie)
    /*ici*/ //nom durant la partie
    /*ici*/ //int, nb de vies du joueur durant la partie
    /*ici*/ //int, score du joueur durant la partie
    //FIN DES CHAMPS SERIALISES

    /*ici*/ //[cache ds l'inspecteur] nom intermediaire, correspond au nom inscrit dans le champ par le joueur (avant le jeu)

    /*ici*/ //public string nom { get => _nom; set => _nom = value; } //accesseur et mutateur du nom
    /*ici*/ //public int vie { get => _vie; set => _vie = value; } //accesseur et mutateur de la vie
    /*ici*/ //public int score { get => _score; set => _score = value; } //accesseur et mutateur du score
    /*ici*/ //public string nomIntermediaire { get => _nomIntermediaire; set => _nomIntermediaire = value; } //accesseur et mutateur du nom intermediaire


    /// <summary>
    /// Methode qui remplace les valeurs en cours par les valeurs initiales
    /// </summary>
    public void Initialiser()
    {
        /*ici*/ //si le nom inter n'est pas vide, changer le nom selon le nom inter
        /*ici*/  //sinon, changer le nom pour le nom par defaut

        /*ici*/  //vider le nom inter, pour la prochaine fois!
        /*ici*/  //initialiser la valeur du nombre de vie
        /*ici*/  //initialiser le score
    }
}