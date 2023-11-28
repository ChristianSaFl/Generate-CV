using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TuProyecto
{
    public partial class CvPage : ContentPage
    {
        public CvPage(
    string nombre,
    string apellido,
    DateTime fechaNacimiento,
    string correo,
    string telefono,
    string dni,
    bool inglesBasico,
    bool inglesIntermedio,
    bool inglesAvanzado,
    bool python,
    bool javascript,
    bool csharp,
    bool organizacion,
    bool resolucion,
    bool trabajoEquipo,
    bool creatividad,
    string nacionalidad,
    string aptitudes,
    List<string> listaExperienciaLaboral,
    List<string> listaFormacion,
    List<string> listaIdiomas)
        {
            InitializeComponent();

            nombreLabel.Text = $" {nombre}";
            apellidoLabel.Text = $" {apellido}";
            fechaNacimientoLabel.Text = $" {fechaNacimiento.ToString("dd/MM/yyyy")}";
            correoLabel.Text = $" {correo}";
            telefonoLabel.Text = $" {telefono}";
            dniLabel.Text = $"{dni}";

            nacionalidadLabel.Text = $"{nacionalidad}";
            aptitudesLabel.Text = $"{aptitudes}";

            experienciaLaboralLabel.Text = $"{string.Join(", ", listaExperienciaLaboral)}";
            formacionLabel.Text = $" {string.Join(", ", listaFormacion)}";
            idiomasLabel.Text = $" {string.Join(", ", listaIdiomas)}";
        }
    }
}
