using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectDTO> ObetenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectDTO> ObetenerProyectos()
        {
            return new List<ProyectDTO>
            {
                new ProyectDTO
                {
                    Titulo = "Bear Watcher",
                    Descripcion = "Winner of Talent-Land Guadalajara 2024 with a prize of $6,000 dollars",
                    ImagenURL = "/imagenes/bear_watcher.jpg",
                    Technologies = "React, Node.js, Tailwind, Wireshakrk, Github",
                    Link = "https://hackathon.genius-arena.com/hackathon/deteccion-de-anomalias-por-analisis-de-trafico-en-la-navegacion-nomaly-sisa/"
                },
                new ProyectDTO
                {
                    Titulo = "Cube Breaker",
                    Descripcion = "Arcade-style video game developed for mobile devices using Unity.",
                    ImagenURL = "/imagenes/cube_breaker.png",
                    Technologies = "Unity, Figma,Unity Advertaisment, Github",
                    Link = "https://play.google.com/store/apps/details?id=com.chasigames.cubebreaker&pcampaignid=web_share"
                },
				new ProyectDTO
				{
					Titulo = "Mini Golf 3D",
					Descripcion = "Puzzle-style video game developed for mobile devices using Unity.",
					ImagenURL = "/imagenes/mini_golf_3D.jpeg",
                    Technologies = "Unity, Blender, Figma, Github",
                    Link = "https://www.instagram.com/chasigames/"
                },
				new ProyectDTO
				{
					Titulo = "Multiplayer Game",
					Descripcion = "Multiplayer videogame agari.io style developed using Unity and Unity web services.",
					ImagenURL = "/imagenes/tanks.png",
					Technologies = "Unity, Unity server services, Github",
					Link = "https://github.com/PabloGP88/Multiplayer-tanks-game.git"
                },
				new ProyectDTO
				{
					Titulo = "Evolutionary algorithm",
					Descripcion = "Evolutionary algorithm developed in python to provide a " +
					"scheduling solution for ITESM school",
					ImagenURL = "/imagenes/algoritmos-evolutivos.jpg",
					Technologies = "Python, genetic operators, selection methods",
					Link = "https://github.com/PabloGP88/algoritmo_evolutivo.git"
				},
				new ProyectDTO
				{
					Titulo = "Bit-Fishing",
					Descripcion = "Hypercasual video game developed for mobile devices using Unity.",
					ImagenURL = "/imagenes/bit-fishing.png",
					Technologies = "Unity, Figma, Unity Advertaisment, Github",
					Link = "https://play.google.com/store/apps/details?id=com.ChasiGames.BitFishing&pcampaignid=web_share"
				},
				new ProyectDTO
				{
					Titulo = "Omnifood",
					Descripcion = "Landing for fake food delivery service, content from Udemy course.",
					ImagenURL = "/imagenes/omnifood.png",
					Technologies = "HTML5, CSS3",
					Link = "https://inspiring-kataifi-a0b6b8.netlify.app/"
				},
				new ProyectDTO
				{
					Titulo = "pBay",
					Descripcion = "e-Commerce application to buy and sell individual products, create listings, and create auctions.",
					ImagenURL = "/imagenes/eCommerce.jpg",
					Technologies = "Django, Boostrap, Github",
					Link = "https://github.com/Rinzler014/pBay.git"
				},
                new ProyectDTO
                {
                    Titulo = "GPS App",
                    Descripcion = "Developed an Android app in Android Studio utilizing Google API for GPS services.",
                    ImagenURL = "/imagenes/gps.jpg",
                    Technologies = "Android Studio, Google API, GPS Services, Ja",
                    Link = "https://github.com/PabloGP88/GPS_LiveTelecom.git"
                }
            };
        }
    }
}
