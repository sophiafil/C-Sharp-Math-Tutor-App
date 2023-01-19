using System;
using static System.Console;

namespace MathTutorApp
{
	internal class MathTutor
	{
		static void Main(string[] args)
		{

			Student newUser = new Student();
			Random rand = new Random();
			char cont = 'm';
			int testOpt = 0;
			int i = rand.Next() % 3;

			WriteLine("Welcome to the Math Tutor App!\n");
			Write("This app with ask you questions on basic mathematics");
			WriteLine(" skills that an elementary student should master.\n");
			WriteLine("We would like to get some basic information about you.\n");

			Write("To get started, please provide your fullname: ");
			newUser.Name = ReadLine();

			Write("Enter your grade level [1 to 5]: ");
			newUser.Grade = Convert.ToInt32(ReadLine());

			Write(newUser.Name + ", we appreciate you using the Math Tutor App. ");
			Write("When you are ready to be tested on Math skills, press ");
			Write("any key to continue.");
			ReadLine();

			do
			{
				Clear();
				Write("Specify the math skill that you would like to be tested.");
				WriteLine("The following are your options:");
				WriteLine("Addition - Enter 1");
				WriteLine("Subtraction - Enter 2");
				WriteLine("Multiplication - Enter 3");
				WriteLine("Surprise Me - Enter 4\n");

				Write("Enter your testing option: ");
				testOpt = Convert.ToInt32(ReadLine());

				do
				{
					testSelect(testOpt, newUser);
					Write("To display the next question, press c. ");
					Write("To display menu options, press m. ");
					Write("To stop testing, press any other key: ");
					cont = Convert.ToChar(ReadLine());

				} while (cont == 'c');

			} while (cont == 'm');

			Clear();
			WriteLine("Name: " + newUser.Name);
			WriteLine("Grade: " + newUser.Grade + "\n");

			WriteLine("Number of addition questions asked: " + newUser.AddAsk);
			WriteLine("Number of addition questions answered correctly: " + newUser.AddCorr + "\n");

			WriteLine("Number of subtraction questions asked: " + newUser.SubAsk);
			WriteLine("Number of subtraction questions answered correctly: " + newUser.SubCorr + "\n");

			WriteLine("Number of multiplication questions asked: " + newUser.MultAsk);
			WriteLine("Number of multiplication questions answered correctly: " + newUser.MultCorr + "\n");

			Write("\nThank you for using the Math Tutor App! ");
			WriteLine("We hope to see you back for practicing your math skills.");

		}

		static void testSelect(int ans, Student newUser)
		{
			Random rand = new Random();
			int alt = rand.Next() % 3 + 1;
			switch (ans)
			{
				case 1:
					AddTest(newUser);
					break;
				case 2:
					SubTest(newUser);
					break;
				case 3:
					MultTest(newUser);
					break;
				default:
					testSelect(alt, newUser);
					break;
			}
		}

		static void AddTest(Student newUser)
		{
			Random rand = new Random();

			newUser.AddAsk++;

			int a = rand.Next() % 100;
			int b = rand.Next() % 100;
			int ans = 0;
			int corr = a + b;

			Clear();
			Write("How much is " + a + " plus " + b + "?: ");
			ans = Convert.ToInt32(ReadLine());

			if (ans == corr)
			{
				WriteLine("Very Good!");
				newUser.AddCorr++;
			}
			else
			{
				Write("Sorry, that is incorrect.");
				WriteLine("The correct answer is " + corr + ".");
			}

		}

		static void SubTest(Student newUser)
		{
			Random rand = new Random();
			newUser.SubAsk++;

			int a = rand.Next() % 100;
			int b = rand.Next() % a;

			int ans = 0;
			int corr = a - b;

			Clear();
			Write("How much is " + a + " minus " + b + "?: ");
			ans = Convert.ToInt32(ReadLine());

			if (ans == corr)
			{
				WriteLine("Excellent!");
				newUser.SubCorr++;
			}
			else
			{
				Write("Come on " + newUser.Name + ", you need to work on your subtraction skills. ");
				WriteLine("The correct answer is " + corr + ".");
			}

		}

		static void MultTest(Student newUser)
		{
			Random rand = new Random();
			newUser.MultAsk++;

			int a = rand.Next() % 100;
			int b = rand.Next() % 100;
			int ans = 0;
			int corr = a * b;

			Clear();
			Write("How much is " + a + " times " + b + "?: ");
			ans = Convert.ToInt32(ReadLine());

			if (ans == corr)
			{
				WriteLine("Nice work, " + newUser.Name + ". Let's go one more round.");
				newUser.MultCorr++;
			}
			else
			{
				Write("Wrong. ");
				WriteLine("The correct answer is " + corr + ".");
			}
		}
	}
}
