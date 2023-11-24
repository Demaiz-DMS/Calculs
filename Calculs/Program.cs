/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 * version : DMS
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            string choix = "1"; // saisie du choix de l'utilsiateur en string comme ça on peux avoir des lettres sans érreurs | c'est un string donc initialisation entre guillements
            bool correct = false; // Booléen pour aider la correction d'érreur

            // boucle sur le menu
            while (choix != "0") // Ici on met des guillemets car la variable est maintenant en string et plus en int
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = Console.ReadLine();

                val1 = rand.Next(1, 10);
                val2 = rand.Next(1, 10);

                switch (choix) // Annonce switch choix puis enssuite des différents cas 
                { 
                    case "1":
                        // choix de l'addition
                        
                        // saisie de la réponse


                        correct = false; // Passage du booléen en faux avant de rentrer dans la boucle
                        
                        while (!correct) // Tant que correct est différent de vrai faire le code
                        {
                            try
                            {
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                // comparaison avec la bonne réponse
                                solution = val1 + val2;
                                if (reponse == solution)
                                {
                                    Console.WriteLine("Bravo !");
                                }
                                else
                                {
                                    Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                                }
                                correct = true; // On a réussi à faire le code sans érreur on passe le booléen en true pour sortir du tant que
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie");
                            }
                        }
                        break;
                    case "2":
                        // choix de la multiplication
                        
                        // saisie de la réponse


                        correct = false;

                        while (!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                // comparaison avec la bonne réponse
                                solution = val1 * val2;
                                if (reponse == solution)
                                {
                                    Console.WriteLine("Bravo !");
                                }
                                else
                                {
                                    Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                }
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("erreur de saisie");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Veuillez choisir l'option 1,2 ou 0");
                        break;


                }
               
            }
        }
    }
}
