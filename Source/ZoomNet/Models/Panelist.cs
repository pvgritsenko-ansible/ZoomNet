using Newtonsoft.Json;

namespace ZoomNet.Models
{
	/// <summary>
	/// Panelist.
	/// </summary>
	public class Panelist
	{
		/// <summary>
		/// Gets or sets the panelist id.
		/// </summary>
		/// <value>
		/// The id.
		/// </value>
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the panelist's email address.
		/// </summary>
		[JsonProperty(PropertyName = "email")]
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets the panelist's full name.
		/// </summary>
		[JsonProperty(PropertyName = "name")]
		public string FullName { get; set; }

		/// <summary>
		/// Gets or sets the panelist's join URL.
		/// </summary>
		[JsonProperty(PropertyName = "join_url")]
		public string JoinUrl { get; set; }
	}
}
