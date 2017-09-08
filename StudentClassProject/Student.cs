using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassProject {
	class Student {
		string Name;
		string EyeColor;
		DateTime DateRegistered = DateTime.Now;
		bool IsLikesMusic = true;
		int YearsExperience = 1;

		public void SetDateRegistered(DateTime DR) {
			DateRegistered = DR;
		}
		public void SetEyeColor(string EC = "Brown") {
			EyeColor = EC;
		}
		public void SetIsLikesMusic(bool ILM = true) {
			IsLikesMusic = ILM;
		}
		public void SetName(string name) {
			Name = name;
		}
		public void SetYearsExperience(int YE) {
			YearsExperience = YE;
		}
		//Constructors
		public Student() {

		}
		public Student(string name) {

		}
		public Student(string name, string eyecolor) {

		}
		public Student(string name, string EC, DateTime DR) {

		}
		public Student(string name, string EC, DateTime DR, bool ILM) {

		}
		public Student(string name, string EC, DateTime DR, bool ILM, int YE) {

		}
	}
	}
