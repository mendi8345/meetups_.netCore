namespace meetupProj.net
{
	public class Person
	{
		public Person(int id, string name, string email, string phon, string imgURL)
		{
			Id = id;
			Name = name;
			Email = email;
			Phon = phon;
			ImgURL = imgURL;
		}
		public Person() { }

		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phon { get; set; }
		public string ImgURL { get; set; }
	}
	
}