using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassProject {
	class Program {
		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {
			//Student Class variables
			//string Name;
			//string EyeColor;
			//DateTime DateRegistered;
			//bool IsLikesMusic;
			//int YearsExperience;
			Student sa = new Student("Sue Ann", "Hazel");
			sa.SetYearsExperience(0);
			Student eb = new Student("Eric B");
			sa.SetEyeColor();
			sa.SetYearsExperience(2);
			Student be = new Student("Bob E", "Blue");
			//Because we made a constructor that is passed two strings, Name and EyeColor,
			//we can boil the two separate sa.SetName() and sa.SetEyeColor() methods into the
			//singular Student go = new Student("Greg O", "Blue")
			Student go = new Student("Greg O", "Blue");
			Student es = new Student("Eric S", "Blue");
			sa.SetYearsExperience(3);
		}
	}
}
