using Microsoft.AspNetCore.Mvc;
using AppGuiada1.Modelos;

namespace AppGuiada1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        /*
        [HttpPost]
        public string mensaje([FromBody] Mensaje mensaje)
        {
            Mensaje algo = new Mensaje(mensaje.Nombre, mensaje.Edad);
            return String.Format($"Hola este es tu mensaje: {mensaje.Nombre} y mi edad {mensaje.Edad}");
        }
        */
        [HttpPost]
        public string crearUsuario([FromBody] Usuario usuario)
        {
            Usuario nuevoUsuario = new Usuario()
            {
                Nombre = "Karla",
                ApellidoP = "Rios",
                ApellidoM = "Díaz",
                EstadoCivil = "Soltera",
                Curp = "RIDK980201MGTSZ09",
                Email= "riosdiazkm@gmail.com",
                Password = "Admin",
                Activo = true
            };
            return String.Format($"Datos del usuario: \n Nombre: {nuevoUsuario.Nombre} {nuevoUsuario.ApellidoP} {nuevoUsuario.ApellidoP} " +
                $"\n Estado Civil: {nuevoUsuario.EstadoCivil} \n CURP: {nuevoUsuario.Curp} \n Email: {nuevoUsuario.Email} " +
                $"\n Activo: {nuevoUsuario.Activo} \n Password: {nuevoUsuario.Password}");

        }

    }
}