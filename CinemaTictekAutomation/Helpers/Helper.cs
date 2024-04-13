using CinemaTictekAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTictekAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:\\Users\\berka\\source\\repos\\CinemaTictekAutomation\\CinemaTictekAutomation\\Pictures\\";
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName="Yildizlararasi",
                    category=Enums.Category.bilim_kurgu,
                    minute = "2 saat 49 dakika",
                    price =50,
                    picturePath = basePath+"yıldızlararası.jpg"
                },
                new Movie()
                {
                    movieName="Yildizlararasi",
                    category=Enums.Category.gerilim,
                    minute = "1 saat 28 dakika",
                    price =40,
                    picturePath = basePath+"nefesinitut.jpg"
                },
                new Movie()
                {
                    movieName="Üç Aptal",
                    category=Enums.Category.komedi,
                    minute = "2 saat 51 dakika",
                    price =60,
                    picturePath = basePath+"üç aptal.jpg"
                },
                new Movie()
                {
                    movieName="Geleceğe Dönüş ",
                    category=Enums.Category.bilim_kurgu,
                    minute = "1 saat 56 dakika",
                    price =50,
                    picturePath = basePath+"gelecegedonus.jpg"
                },
                new Movie()
                {
                    movieName="Jumanji",
                    category=Enums.Category.macera,
                    minute = "1 saat 44 dakika",
                    price =50,
                    picturePath = basePath+"jumanji.jpg"
                },
                new Movie()
                {
                    movieName="Warcraft",
                    category=Enums.Category.bilim_kurgu,
                    minute = "2 saat 3 dakika",
                    price =40,
                    picturePath = basePath+"warcraft.jpg"
                }
            };
        }
    }
}
