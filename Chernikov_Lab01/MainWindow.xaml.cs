using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chernikov_Lab01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       private void AgeButton_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var month = DatePicker1.SelectedDate.Value.Month;
            var day = DatePicker1.SelectedDate.Value.Day;
            var year = DatePicker1.SelectedDate.Value.Year;
            var age = today.Year - year;
            var ch_zodiacNum = (year - 1888) % 12;

            if (DatePicker1.SelectedDate.Value.Date > today.AddYears(-age)) age--; // in case of leap year

            if (age <= 0 || age >= 135) // Checking if user's age is between 0 and 135
            {
                MessageBox.Show("Your age is incorrect, pleasy try again");
                ageTextBlock.Text = "";
                westZodiacSignTextBlock.Text = "";
                chZodiacSignTextBlock.Text = "";
            }
            else if (day == today.Day && month == today.Month) // checking if today is user's date of birth
            {
                ageTextBlock.Text = "Happy Birthday!!! You are now : " + age.ToString();
                ageTextBlock.Text = "Happy Birthday!!! You are now : " + age.ToString();

                //West zodiac system

                if ((month == 12 && day >= 22) || (month == 01 && day <= 19))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Capricorn!";
                }

                else if ((month == 01 && day >= 20) || (month == 02 && day <= 17))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Aquarius!";
                }

                else if ((month == 02 && day >= 18) || (month == 03 && day <= 19))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Pisces!";
                }

                else if ((month == 03 && day >= 20) || (month == 04 && day <= 19))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Aries!";
                }

                else if ((month == 04 && day >= 20) || (month == 05 && day <= 20))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Taurus!";
                }

                else if ((month == 05 && day >= 21) || (month == 06 && day <= 20))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Gemini!";
                }

                else if ((month == 06 && day >= 21) || (month == 07 && day <= 22))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Cancer!";
                }

                else if ((month == 07 && day >= 23) || (month == 08 && day <= 22))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Leo!";
                }

                else if ((month == 08 && day >= 23) || (month == 09 && day <= 22))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Virgo!";
                }

                else if ((month == 09 && day >= 23) || (month == 10 && day <= 22))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Libra!";
                }

                else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Scorpio!";
                }

                else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Sagittarius!";
                }

                // Chinese zodiac system

                if (ch_zodiacNum == 0)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Rat!";
                }
                else if (ch_zodiacNum == 1)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Ox!";
                }
                else if (ch_zodiacNum == 2)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Tiger!";
                }
                else if (ch_zodiacNum == 3)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Rabbit!";
                }
                else if (ch_zodiacNum == 4)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Dragon!";
                }
                else if (ch_zodiacNum == 5)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Snake!";
                }
                else if (ch_zodiacNum == 6)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Horse!";
                }
                else if (ch_zodiacNum == 7)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Goat!";
                }
                else if (ch_zodiacNum == 8)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Monkey!";
                }
                else if (ch_zodiacNum == 9)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Rooster!";
                }
                else if (ch_zodiacNum == 10)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Dog!";
                }
                else if (ch_zodiacNum == 11)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Pig!";
                }

            }
             
            else
            {
                ageTextBlock.Text = "Your age is : " + age.ToString();

                //West zodiac system

                if((month == 12 && day >= 22) || (month == 01 && day <= 19))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Capricorn!";
                }

                else if ((month == 01 && day >= 20) || (month == 02 && day <= 17))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Aquarius!";
                }

                else if ((month == 02 && day >= 18) || (month == 03 && day <= 19))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Pisces!";
                }

                else if ((month == 03 && day >= 20) || (month == 04 && day <= 19))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Aries!";
                }

                else if ((month == 04 && day >= 20) || (month == 05 && day <= 20))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Taurus!";
                }

                else if ((month == 05 && day >= 21) || (month == 06 && day <= 20))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Gemini!";
                }

                else if ((month == 06 && day >= 21) || (month == 07 && day <= 22))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Cancer!";
                }

                else if ((month == 07 && day >= 23) || (month == 08 && day <= 22))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Leo!";
                }

                else if ((month == 08 && day >= 23) || (month == 09 && day <= 22))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Virgo!";
                }

                else if ((month == 09 && day >= 23) || (month == 10 && day <= 22))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Libra!";
                }

                else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Scorpio!";
                }

                else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                {
                    westZodiacSignTextBlock.Text = "Your zodiac sign is Sagittarius!";
                }

                // Chinese zodiac system

                if(ch_zodiacNum == 0)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Rat!";
                }
                else if (ch_zodiacNum == 1)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Ox!";
                }
                else if (ch_zodiacNum == 2)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Tiger!";
                }
                else if (ch_zodiacNum == 3)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Rabbit!";
                }
                else if (ch_zodiacNum == 4)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Dragon!";
                }
                else if (ch_zodiacNum == 5)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Snake!";
                }
                else if (ch_zodiacNum == 6)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Horse!";
                }
                else if (ch_zodiacNum == 7)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Goat!";
                }
                else if (ch_zodiacNum == 8)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Monkey!";
                }
                else if (ch_zodiacNum == 9)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Rooster!";
                }
                else if (ch_zodiacNum == 10)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Dog!";
                }
                else if (ch_zodiacNum == 11)
                {
                    chZodiacSignTextBlock.Text = "Your chinese zodiac sign is Pig!";
                }
            }
        }
    }
}
