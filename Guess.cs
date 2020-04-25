using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Guess
{
 	public class Program
 	{
 		public static void Main(string[] args)
 		{
 			Random random = new Random();
 			
 			int[] levelLimit = new int [3];
 		
 			levelLimit[0] = 6;
 			levelLimit[1] = 4;
 			levelLimit[2] = 3;
 			
 			int systemGeneratedNum = 0; 
 			int guessesLeft = 0; 
 			int userGuess = 0; 
 			string difficulty = ""; 
 			 
 			
 			
 			Console.WriteLine("Welcome To The Guessing Game. There Are 3 Difficulty Modes:\n Easy, Medium and Hard\n");
 			
 			 while (true) 
 			 
 			 { 
 			 	Console.Write("Select Difficulty Mode: ");
 			 	difficulty = Console.ReadLine(); 
 			 	
 			 	if (difficulty == "Easy")
 			 	{ 
 			 		guessesLeft = levelLimit[1]; 
 			 		systemGeneratedNum = random.Next(1,10);
 			 		
 			 		while (guessesLeft != 0)
 			 		{
 			 			Console.Write("Take A Wild Guess: ");
 			 				userGuess = int.Parse(Console.ReadLine()); 
 			 			guessesLeft = guessesLeft - 1;
 			 			
 			 				if (userGuess == systemGeneratedNum)
 			 				{
 			 					Console.WriteLine("YOU GOT IT RIGHT!");
 			 				break;
 			 					
 			 					}else{
 			 						Console.WriteLine("\nThat Was Wrong!");
 			 						
 			 						if (guessesLeft > 1){
 			 							Console.WriteLine($"You Have {guessesLeft} Guesses Left.\n");
 			 							}
 			 							else if (guessesLeft == 1){
 			 								Console.WriteLine($"You Have {guessesLeft} Guess Left.\n"); } 
 			 	} 
 			 		} if (guessesLeft == 0){
 			 			
 			 			Console.WriteLine("GAME OVER!\n"); } 
 			 			break;
 			 			}
 			 				
 			 			else if (difficulty == "Medium"){
 			 				guessesLeft = levelLimit[2]; 
 			 				systemGeneratedNum = random.Next(1,21); 
 			 				while (guessesLeft != 0){ 
 			 					Console.Write("Take A Wild Guess: "); 
 			 					userGuess = int.Parse(Console.ReadLine());
 			 					guessesLeft = guessesLeft - 1; 
 			 					if (userGuess == systemGeneratedNum){
 			 						Console.WriteLine("YOU GOT IT RIGHT!");
 			 						break;
 			 						
 			 						}else{ 
 			 							Console.WriteLine("\nThat Was Wrong!");
 			 							if (guessesLeft > 1){
 			 								Console.WriteLine($"You Have {guessesLeft} Guesses Left.\n");
 			 								
 			 								}else if (guessesLeft == 1){
 			 									Console.WriteLine($"You have {guessesLeft} guess left\n");
 			 									} 
 			 									} 
 			 	}if (guessesLeft == 0){
 			 		
 			 		Console.WriteLine("GAME OVER!\n");
 			 		}break;
 			 		
 			 		}else if (difficulty == "Hard"){
 			 			guessesLeft = levelLimit[3]; 
 			 			systemGeneratedNum = random.Next(1,51);
 			 			while (guessesLeft != 0){
 			 				Console.Write("Take A Wild Guess: ");
 			 				userGuess = int.Parse(Console.ReadLine());
 			 				guessesLeft = guessesLeft - 1;
 			 				if (userGuess == systemGeneratedNum){
 			 					Console.WriteLine("YOU GOT IT RIGHT!"); break;
 			 					}
 			 					else{
 			 						Console.WriteLine("\nThat Was Wrong!");
 			 						if (guessesLeft > 1){
 			 							Console.WriteLine($"You Have {guessesLeft} Guesses Left.\n"); }

 			 							else if (guessesLeft == 1){
 			 								Console.WriteLine($"You Have {guessesLeft} Guess Left.\n");} 
 			 	} 
 			 		} if (guessesLeft == 0){
 			 			
 			 			Console.WriteLine("GAME OVER!\n"); }
 			 			break;
 			 			
 			 			}
 			
 			 		} 
 				} 
 			 		
 	}
}
