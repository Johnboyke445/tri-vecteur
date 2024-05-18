using System;

namespace EX35{
	class Program{
		static void Main(string[] args){
				//Saisie de la taille duvecteur 
				Console.Write("Saisir le nombre de case du vecteur :");
				int nb = int.Parse(Console.ReadLine());

				//Déclaration du vecteur 
				int[] vec =  new int[nb];

				//Saisie du vecteur 
				for (int i = 0; i< nb; i++){
						Console.Write("Nombre n°"+i+" : ");
						vec[i] = int.Parse(Console.ReadLine())
				}
				//Premier affichage du vecteur non trié 
				for(int i = 0; i<nb;i++){
						Console.Write(vec[i] + " I " );
				}
				//Tri par bulle 
				bool echange; // sert à valider s'il y a eu un échange 

				do{
						//On part du principe qu'il n'y a pas d'échange
						echange = False;
						//Parcous du vecteur afin d'établir la comparaison du vecteur 2 à 2
						for (int k = 1; k <nb; k++){
								if(vec[k]< vec[k-1]){
										int sauv = vec[k];
										vec[k] = vec[k-1]
										vec[k-1] = sauv;
										echange = true;
								}
						}
						Console.WriteLine();
						for(int k=0; k< nb;k++){
								Console.Write
						}
						
				}
		}
	}
}