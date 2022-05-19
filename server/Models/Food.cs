﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace server.Models
{
	[Table("FoodType")]
	
	public class Food
	{
		public Food(){}
		
		[Column("foodtype_id")]
		public string FoodId { get; set; }
		[Column("food_type")]
		public string FoodKind { get; set; }
	}
}

