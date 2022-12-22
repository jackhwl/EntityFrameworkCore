﻿using Microsoft.EntityFrameworkCore;
using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Linq;

namespace SamuraiApp.UI
{
	class Program
	{
        private static SamuraiContext _context = new SamuraiContext();

        private static void Main(string[] args)
        {
            //_context.Database.EnsureCreated();
            //AddSamuraisByName("Shimada", "Okamoto", "Kikuchio", "Hayashida");
            AddVariousTypes();
            // GetSamurais();
            //         GetSamurais("Before Add:");
            //AddSamurai();
            //GetSamurais("After Add:");

            Console.Write("Press any key...");
            Console.ReadKey();
        }

        private static void AddSamurai()
        {
            var samurai = new Samurai { Name = "Julie" };
            _context.Samurais.Add(samurai);
            _context.SaveChanges();
        }
        private static void AddSamuraisByName(params string[] names)
        {
            foreach(string name in names)
			{
                _context.Samurais.Add(new Samurai { Name = name });
			}
            
            _context.SaveChanges();
        }
        private static void AddVariousTypes()
		{
			//_context.AddRange(new Samurai { Name = "Shimada"},
			//    new Samurai { Name = "Okamoto" },
			//    new Battle { Name = "Battle of Anegawa" },
			//    new Battle { Name = "Battle of Nagashino" }
			//);
			//_context.Samurais.AddRange(new Samurai { Name = "Shimada" },
			//    new Samurai { Name = "Okamoto" }
			//    );
			_context.Battles.AddRange(new Battle { Name = "Battle of Anegawa" },
				new Battle { Name = "Battle of Nagashino" }
				);
            _context.SaveChanges();
        }
        private static void GetSamurais()
        {
            var samurais = _context.Samurais
                .TagWith("ConsoleApp.Program.GetSamurais method")
                .ToList();
            Console.WriteLine($"Samurai count is {samurais.Count}");
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
