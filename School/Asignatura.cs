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

namespace Acta_Notas
{
    public partial class Asignatura : Form
    {
        private static int id = 0;
        public Asignatura()
        {
            InitializeComponent();
        }

        private async void GetAllAsignatura()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7262/api/Asignatura");
                if (response.IsSuccessStatusCode)
                {
                    var students = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<AsignaturaDto>>(students);
                    dgvAsignatura.DataSource = result.ToList();

                    AsignaturaUpdateDto calificacionDto = new AsignaturaUpdateDto();





                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de ssignaturas {response.StatusCode}");
                }
            }
        }

        private async void UpdateAsignatura()
        {

            AsignaturaUpdateDto studentDto = new AsignaturaUpdateDto();
            id = Convert.ToInt32(txtAsignaturaId.Text);
            studentDto.AsignaturaId = Convert.ToInt32(txtAsignaturaId.Text);
            studentDto.AsignaturaNombre = txtAsignaturaNombre.Text;
            studentDto.Semestre = cmbSemestre.Text;
            studentDto.Creditos = Convert.ToInt32(txtCreditos.Text);

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(studentDto);
                var content = new StringContent(serializedStudent, Encoding.UTF8,
                    "application/json");
                var responseMessage = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Asignatura", id),
                    content);
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Asignatura actualizada");
                else
                    MessageBox.Show($"Error al actualizar la asignatura {responseMessage.StatusCode}");

            }
            Clear();
            GetAllAsignatura();

        }

        private async void AddAsignatura()
        {

            AsignaturaCreateDto studentDto = new AsignaturaCreateDto();

            studentDto.AsignaturaNombre = txtAsignaturaNombre.Text;
            studentDto.Semestre = cmbSemestre.Text;
            studentDto.Creditos = Convert.ToInt32(txtCreditos.Text);

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(studentDto);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://localhost:7262/api/Asignatura", content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Asignatura agregada correctamente");
                }
                else
                {
                    MessageBox.Show($"Error al guardar la asignatura: {result.Content.ReadAsStringAsync().Result}");
                }
                Clear();
                GetAllAsignatura();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddAsignatura();
        }
        private void Clear()
        {
            txtAsignaturaId.Text = string.Empty;
            txtAsignaturaNombre.Text = string.Empty;
            cmbSemestre.Text = string.Empty;
            txtCreditos.Text = string.Empty;
            id = 0;
        }

        private async void GetAsignaturaById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Asignatura", id));
                if (response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadAsStringAsync();
                    AsignaturaDto studentDto = JsonConvert.DeserializeObject<AsignaturaDto>(student);
                    txtAsignaturaId.Text = studentDto.AsignaturaId.ToString();
                    txtAsignaturaNombre.Text = studentDto.AsignaturaId.ToString();
                    cmbSemestre.Text = studentDto.Semestre.ToString();
                    txtCreditos.Text = studentDto.Creditos.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la asignatura: {response.StatusCode}");
                }
            }
        }

        private async void DeleteAsignatura()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7262/api/Asignatura");
                var responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Asignatura", id));
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Asignatura eliminada con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar la asignatura {responseMessage.StatusCode}");
            }
            Clear();
            GetAllAsignatura();
        }

        private void Asignatura_Load(object sender, EventArgs e)
        {
            GetAllAsignatura();

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteAsignatura();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateAsignatura();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvAsignatura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsignatura.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetAsignaturaById(id);
                }
            }
        }

        
    }
}
