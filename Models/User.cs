﻿using System.Text.Json.Serialization;

namespace AspNetCoreWebApi1.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public string Email { get; set; }
	}
}
