using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TuProyecto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private List<string> listaExperienciaLaboral = new List<string>();

        private void AgregarExperiencia(object sender, EventArgs e)
        {
            string nuevaExperiencia = experienciaEntry.Text;
            if (!string.IsNullOrWhiteSpace(nuevaExperiencia))
            {
                listaExperienciaLaboral.Add(nuevaExperiencia);

                experienciaEntry.Text = string.Empty;
                DisplayAlert("Éxito", "Experiencia laboral agregada correctamente.", "OK");
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese información válida.", "OK");
            }
        }



        private List<string> listaFormacion = new List<string>();

        private void AgregarFormacion(object sender, EventArgs e)
        {
            string nuevaFormacion = formacionEntry.Text;
            if (!string.IsNullOrWhiteSpace(nuevaFormacion))
            {
                listaFormacion.Add(nuevaFormacion);
                
                formacionEntry.Text = string.Empty;
                DisplayAlert("Éxito", "Formación agregada correctamente.", "OK");
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese información válida.", "OK");
            }
        }


        private List<string> listaIdiomas = new List<string>();

        private void AgregarIdioma(object sender, EventArgs e)
        {
            string nuevoIdioma = idiomasEntry.Text;
            if (!string.IsNullOrWhiteSpace(nuevoIdioma))
            {
                listaIdiomas.Add(nuevoIdioma);
                
                idiomasEntry.Text = string.Empty;
                DisplayAlert("Éxito", "Idioma agregado correctamente.", "OK");
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese información válida.", "OK");
            }
        }


        private async void GuardarDatos(object sender, EventArgs e)
        {
            string nombre = nombreEntry.Text;
            string apellido = apellidoEntry.Text;
            string fechaNacimiento = fechaNacimientoDatePicker.Date.ToString("yyyy-MM-dd");
            string correo = correoEntry.Text;
            string telefono = telefonoEntry.Text;
            string dni = dniEntry.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(fechaNacimiento) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(dni))
            {
                await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }

            bool inglesBasico = inglesBasicoSwitch.IsToggled;
            bool inglesIntermedio = inglesIntermedioSwitch.IsToggled;
            bool inglesAvanzado = inglesAvanzadoSwitch.IsToggled;
            bool python = pythonSwitch.IsToggled;
            bool javascript = javascriptSwitch.IsToggled;
            bool csharp = csharpSwitch.IsToggled;
            bool organizacion = organizacionSwitch.IsToggled;
            bool resolucion = resolucionSwitch.IsToggled;
            bool trabajoEquipo = trabajoEquipoSwitch.IsToggled;
            bool creatividad = creatividadSwitch.IsToggled;
            string nacionalidad = nacionalidadPicker.SelectedItem?.ToString() ?? "No seleccionado";
            string aptitudes = aptitudesEntry.Text;
            string experienciaLaboral = experienciaEntry.Text;
            string formacion = formacionEntry.Text;
            string idiomas = idiomasEntry.Text;

            
            string mensaje = $"Nombre: {nombre}\nApellido: {apellido}\nFecha de Nacimiento: {fechaNacimiento}\nCorreo: {correo}\nTeléfono: {telefono}\nDNI: {dni}\n" +
                             $"Inglés Básico: {inglesBasico}\nInglés Intermedio: {inglesIntermedio}\nInglés Avanzado: {inglesAvanzado}\n" +
                             $"Python: {python}\nJavaScript: {javascript}\nC#: {csharp}\n" +
                             $"Organización: {organizacion}\nResolución de Problemas: {resolucion}\nTrabajo en Equipo: {trabajoEquipo}\nCreatividad: {creatividad}\n" +
                             $"Nacionalidad: {nacionalidad}\nAptitudes: {aptitudes}\nExperiencia Laboral: {experienciaLaboral}\nFormación: {formacion}\nIdiomas: {idiomas}\n";

            await DisplayAlert("Datos Recopilados", mensaje, "OK");

            // Almacenar 
            listaExperienciaLaboral.Add(experienciaLaboral);
            listaFormacion.Add(formacion);
            listaIdiomas.Add(idiomas);

            
            await Navigation.PushAsync(new CvPage(
                nombre,
                apellido,
                DateTime.Parse(fechaNacimiento),
                correo,
                telefono,
                dni,
                inglesBasico,
                inglesIntermedio,
                inglesAvanzado,
                python,
                javascript,
                csharp,
                organizacion,
                resolucion,
                trabajoEquipo,
                creatividad,
                nacionalidad,
                aptitudes,
                listaExperienciaLaboral,
                listaFormacion,
                listaIdiomas));
        }

   


    }
}
