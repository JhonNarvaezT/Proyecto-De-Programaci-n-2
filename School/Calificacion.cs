using ActaNotasAPI.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Acta_Notas
{
    public partial class Calificacion : Form
    {
        private static int id = 0;
        public Calificacion()
        {
            InitializeComponent();
        }

        private async void GetAllCalificacion()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7262/api/Calificacion");
                if (response.IsSuccessStatusCode)
                {
                    var students = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<CalificacionDto>>(students);
                    dgvCalificacion.DataSource = result.ToList();

                    CalificacionUpdateDto calificacionDto = new CalificacionUpdateDto();





                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de calificaciones{response.StatusCode}");
                }
            }
        }

        private async void UpdateCalificacion()
        {

            CalificacionUpdateDto studentDto = new CalificacionUpdateDto();
            id = Convert.ToInt32(txtStudentId.Text);
            studentDto.CalificacionId = Convert.ToInt32(txtStudentId.Text);
            studentDto.EstudianteId = Convert.ToInt32(cmbEstudiante.Text);
            studentDto.AsignaturaId = Convert.ToInt32(cmbAsignatura.Text);
          int nota = (Convert.ToInt32(txtNotaS.Text) + Convert.ToInt32(txtnotaIIP.Text) + Convert.ToInt32(txtnotaIIP.Text));
            studentDto.nota = nota;

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(studentDto);
                var content = new StringContent(serializedStudent, Encoding.UTF8,
                    "application/json");
                var responseMessage = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Calificacion", id),
                    content);
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Calificacion actualizada");
                else
                    MessageBox.Show($"Error al actualizar la calificacion {responseMessage.StatusCode}");

            }
            Clear();
            GetAllCalificacion();

        }

        private async void AddCalificacion()
        {

            CalificacionCreateDto studentDto = new CalificacionCreateDto();

            studentDto.EstudianteId = Convert.ToInt32(cmbEstudiante.Text);
            studentDto.AsignaturaId = Convert.ToInt32(cmbAsignatura.Text);
            studentDto.nota = (Convert.ToInt32(txtNotaS.Text)+ Convert.ToInt32(txtnotaIIP.Text)+ Convert.ToInt32(txtnotaIIP.Text));

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(studentDto);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://localhost:7262/api/Calificacion", content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Calificacion agregada correctamente");
                }
                else
                {
                    MessageBox.Show($"Error al guardar la calificacion: {result.Content.ReadAsStringAsync().Result}");
                }
                Clear();
                GetAllCalificacion();
            }
        }

        private void Clear()
        {
            txtStudentId.Text = string.Empty;
            cmbAsignatura.Text = string.Empty;
            cmbEstudiante.Text = string.Empty;
            txtNotaS.Text = string.Empty;
            id = 0;
        }

        private async void GetCalificacionById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Calificacion", id));
                if (response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadAsStringAsync();
                    CalificacionDto studentDto = JsonConvert.DeserializeObject<CalificacionDto>(student);
                    txtStudentId.Text = studentDto.CalificacionId.ToString();
                    cmbAsignatura.Text = studentDto.AsignaturaId.ToString();
                    cmbEstudiante.Text = studentDto.EstudianteId.ToString();
                    txtNF.Text = studentDto.nota.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la calificacion: {response.StatusCode}");
                }
            }
        }

        private async void DeleteCalificacion()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7262/api/Calificacion");
                var responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Calificacion", id));
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Calificacion eliminada con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar la calificacion {responseMessage.StatusCode}");
            }
            Clear();
            GetAllCalificacion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddCalificacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteCalificacion();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateCalificacion();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Calificacion_Load(object sender, EventArgs e)
        {
            GetAllCalificacion();
        }

        private void dgvCalificacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCalificacion.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetCalificacionById(id);
                }
            }
        }
    }
}
