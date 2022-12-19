﻿using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class BusinessDataLogic
	{
		private SamuraiContext _context;
		public BusinessDataLogic(SamuraiContext context)
		{
			_context = context;
		}
		public BusinessDataLogic()
		{
			_context = new SamuraiContext();
		}

		public int AddMultipleSamurais(string[] nameList)
		{
			var samuraiList = new List<Samurai>();
			foreach (var name in nameList) 
			{
				samuraiList.Add(new Samurai { Name= name });
			}
			_context.Samurais.AddRange(samuraiList);

			var dbResult = _context.SaveChanges();
			return dbResult;
		}
	}
}
