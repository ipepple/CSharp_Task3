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
 			int guess = random.Next(1,11);
