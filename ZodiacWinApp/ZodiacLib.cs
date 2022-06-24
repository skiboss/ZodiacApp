using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacWinApp
{
    class ZodiacLib
    {
        public int Day { get; set; }
        public string Month { get; set; }

        public string GetSign()
        {
            if (Month == "Jan" && Day <= 19)
            {
                return "Capricorn";
            }
            else if (Month == "Jan" && Day > 19)
            {
                return "Aquarius";
            }

            if (Month == "Feb" && Day <= 19)
            {
                return "Aquarius";
            }
            else if (Month == "Feb" && Day > 19)
            {
                return "Pieces";
            }

            if (Month == "Mar" && Day <= 20)
            {
                return "Pieces";
            }
            else if (Month == "Mar" && Day > 20)
            {
                return "Aries";
            }

            if (Month == "Apr" && Day <= 20)
            {
                return "Aries";
            }
            else if (Month == "Apr" && Day > 20)
            {
                return "Taurus";
            }

            if (Month == "May" && Day <= 20)
            {
                return "Taurus";
            }
            else if (Month == "May" && Day > 20)
            {
                return "Gemini";
            }

            if (Month == "Jun" && Day <= 20)
            {
                return "Gemini";
            }
            else if (Month == "Jun" && Day > 20)
            {
                return "Cancer";
            }

            if (Month == "Jul" && Day <= 22)
            {
                return "Cancer";
            }
            else if (Month == "Jul" && Day > 22)
            {
                return "Leo";
            }

            if (Month == "Aug" && Day <= 22)
            {
                return "Leo";
            }
            else if (Month == "Aug" && Day > 22)
            {
                return "Virgo";
            }

            if (Month == "Sep" && Day <= 22)
            {
                return "Virgo";
            }
            else if (Month == "Sep" && Day > 22)
            {
                return "Libra";
            }

            if (Month == "Oct" && Day <= 22)
            {
                return "Libra";
            }
            else if (Month == "Oct" && Day > 22)
            {
                return "Scorpio";
            }

            if (Month == "Nov" && Day <= 22)
            {
                return "Scorpio";
            }
            else if (Month == "Nov" && Day > 22)
            {
                return "Sagittarius";
            }

            if (Month == "Dec" && Day <= 21)
            {
                return "Sagittarius";
            }
            else if (Month == "Dec" && Day > 21)
            {
                return "Capricorn";
            }

            else
            {
                return "wrong due to invalid input!";
            }
        }
    }
}
