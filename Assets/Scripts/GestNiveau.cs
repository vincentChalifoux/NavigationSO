using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*ici*/ //importe TextMeshPro

/// <summary>
/// Classe du gestionnaire de niveau.
/// Doit etre appliquee sur un gameObject vide qui contiendra les elements du jeu.
/// </summary>
public class GestNiveau : MonoBehaviour
{
    //DEBUT DES CHAMPS SERIALISES
    /*ici*/ //Entete de section pour les données et l'interface
    /*ici*/ //infos du joueur
    /*ici*/ //infos de la navigation
    /*ici*/ //champ texte TMP du niveau
    /*ici*/ //champ texte TMP du score
    /*ici*/ //champ texte TMP du niveau de vie

    /*ici*/ //Entete de section pour les caractéristiques du niveau
    [SerializeField] private int _nbTresorsIni = 3; //int, nombre de tresors a placer
    [SerializeField] private GameObject _prefabTresor; //prefab du tresor
    [SerializeField] private int _nbEnnemis = 2; //int, nombre d'ennemis a placer
    [SerializeField] private GameObject _prefabEnnemi; //prefab de l'ennemi
    /*ici*/ //v2, pos min pour placer objets+ennemis
    /*ici*/ //v2, pos max pour placer objets+ennemis
    //FIN DES CHAMPS SERIALISES

    /*ici*/ //int, nombre de tresors recuperes par le joueur (0 au début)

    /*ici*/ //propriete privee requise pour le Singleton
    /*ici*/ //accesseur pour le Singleton

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        //DEBUT DE LA SECTION SINGLETON
        /*ici*/ //condition habituelle du Singleton
        /*ici*/ //else
        //{
            /*ici*/ //detruire
            /*ici*/ //mettre fin a l'execution
        //}
        //FIN DE LA SECTION SINGLETON

        AfficherNiveau(); //afficher le niveau actuel dans le champ du niveau
        AfficherScore(); //afficher le score actuel dans le champ du score
        AfficherVie(); //afficher le nombre de vie actuel dans le champ de la vie

        /*ici*/ //ajouter les tresors requis
        /*ici*/ //ajouter les ennemis requis
    }

    /// <summary>
    /// Permet d'ajouter un type d'objet dans la scene, selon une quantite determinee
    /// </summary>
    /// <param name="nb">Le nombre</param>
    /// <param name="prefab">Le prefab de l'objet</param>
    private void Ajouter() //prevoir les 2 parametres requis
    {
        /*ici*/ //boucle for
        //{
            /*ici*/ //instanciation, comme enfant du niveau (garder ref de l'instance)
            /*ici*/ //etablir x aleatoire, selon proprietes min et max
            /*ici*/ //etablir y aleatoire, selon proprietes min et max
            /*ici*/ //appliquer la position en x et y
        //}
    }

    /// <summary>
    /// Affiche le texte requis dans le champ du niveau
    /// </summary>
    private void AfficherNiveau()
    {
        /*ici*/ //affichage de la concatenation du mot et de l'info
    }

    /// <summary>
    /// Affiche le texte requis dans le champ de la vie
    /// </summary>
    private void AfficherVie()
    {
        /*ici*/ //preparation d'une variable pour le pluriel
        /*ici*/ //affichage de la concatenation du mot, du pluriel et de l'info
    }

    /// <summary>
    /// Affiche le texte requis dans le champ du score
    /// </summary>
    private void AfficherScore()
    {
        /*ici*/ //affichage de la concatenation du mot et de l'info
    }

    /// <summary>
    /// Methode publique appelee par un tresor quand le joueur le recupere.
    /// Donne les points et passe au niveau suivant quand il n'y a plus de tresors.
    /// </summary>
    /// <param name="points">Les points associes a ce tresor</param>
    public void RecupererTresor(int points) //ne pas oublier d'ajouter le parametre
    {
        /*ici*/ //ajout des points dans les infos du joueur
        AfficherScore(); //mise a jour de l'affichage du score
        /*ici*/ //incrementation du nombre de tresors du actuels
        /*ici*/ //si tous les trésors ont ete ramasses
            /*ici*/ //changer de scene avec la methode des infos de navigation
    }

    /// <summary>
    /// Methode publique appelee par un ennemi quand le joueur perd une vie.
    /// Enleve une vie et passe a l'ecran de fin si la reserve est epuisee.
    /// </summary>
    public void PerdreVie()
    {
        /*ici*/ //decrementation de la vie dans les infos du joueur
        /*ici*/ //mise a jour de l'affichage de la vie
        /*ici*/ //si mort pour vrai, aller a la scene de fin
    }
}