using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace MusterAfricaChallenge
{
    class StarWarsActor
    {
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("height")]
		public string Height { get; set; }

		[JsonPropertyName("mass")]
		public string Mass { get; set; }

		[JsonPropertyName("hair_color")]
		public string HairColor { get; set; }

		[JsonPropertyName("skin_color")]
		public string SkinColor { get; set; }

		[JsonPropertyName("eye_color")]
		public string EyeColor { get; set; }

		[JsonPropertyName("birth_year")]
		public string BirthYear { get; set; }

		[JsonPropertyName("gender")]
		public string Gender { get; set; }

		[JsonPropertyName("homeworld")]
		public string HomeWorld { get; set; }

		[JsonPropertyName("films")]
		public IList<string> Films { get; set; }

		[JsonPropertyName("species")]
		public IList<string> Species { get; set; }

		[JsonPropertyName("vehicles")]
		public IList<string> Vehicles { get; set; }

		[JsonPropertyName("starships")]
		public IList<string> StartShips { get; set; }

		[JsonPropertyName("created")]
		public string Created { get; set; }

		[JsonPropertyName("edited")]
		public string Edited { get; set; }

		[JsonPropertyName("url")]
		public string Url { get; set; }

		public override string ToString()
		{
			return $"[name: {this.Name}] \n [height: {this.Height}] \n [mass: {this.Mass}] \n [birth_year: {this.BirthYear}]" +
				$" \n [created: {this.Created}] \n [edited: {this.Edited}] \n [gender: {this.Gender}] \n [homeworld: {this.HomeWorld}]" +
				$" \n [skin_color: {this.SkinColor}] \n [hair_color: {this.HairColor}] \n [eye_color: {this.EyeColor}] \n [url: {this.Url}] " +
				$" \n [films: {ListToString(this.Films)}] \n [vehicles: {ListToString(this.Vehicles)}] \n [starships: {ListToString(this.StartShips)}] " +
				$" \n [species: {ListToString(this.Species)}]";
		}

		private string ListToString(IList<string> items)
		{
			string result = "";

			foreach (var item in items)
			{
				result = result + item + "\n";
			}

			return result;
		}
	}
}
