﻿using System;
using API_with_EF_2022.Models;
namespace API_with_EF_2022.DAL
{
	public class FishRepository
	{
		private GameContext _dbContext = new GameContext();

		public Fish AddFish(Fish fistToAdd)
		{
			_dbContext.Add(fistToAdd);
			_dbContext.SaveChanges();
			return GoFishingForLatest();
		}


		public Fish GoFishingForLatest()
		{
			return _dbContext.Fishes.OrderByDescending(fish => fish.Id).FirstOrDefault();
		}


	}
}

