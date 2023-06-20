using ActaNotasAPI.Models.Dto;
using Newtonsoft.Json;

using SchoolAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class frmStudents : Form
    {
        private static int id = 0;

        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            GetAllStudents();

        }


        private async void GetAllStudents()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7262/api/Estudiante");
                if (response.IsSuccessStatusCode)
                {
                    var students = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<EstudianteDto>>(students);
                    dgvEStudiante.DataSource = result.ToList();

                    EstudianteUpdateDto studentDto = new EstudianteUpdateDto();





                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de estudiantes {response.StatusCode}");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateStudent();
        }

        private async void UpdateStudent()
        {

            EstudianteUpdateDto studentDto = new EstudianteUpdateDto();
            id = Convert.ToInt32(txtStudentId.Text);
            studentDto.EstudianteId = Convert.ToInt32(txtStudentId.Text);
            studentDto.Nombre = txtStudentName.Text;
            studentDto.GrupoId = Convert.ToInt32(comboBox1.Text);
            studentDto.Carnet = txtCarnett.Text;

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(studentDto);
                var content = new StringContent(serializedStudent, Encoding.UTF8,
                    "application/json");
                var responseMessage = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Estudiante", id),
                    content);
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Estudiante actualizado");
                else
                    MessageBox.Show($"Error al actualizar el estudiante {responseMessage.StatusCode}");

            }
            Clear();
            GetAllStudents();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private async void AddStudent()
        {
            EstudianteCreateDto studentDto = new EstudianteCreateDto();
            studentDto.Nombre = txtStudentName.Text;
            studentDto.GrupoId = Convert.ToInt32(comboBox1.Text);
            studentDto.Carnet = txtCarnett.Text;
            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(studentDto);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://localhost:7262/api/Estudiante", content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Estudiante agregado correctamente");
                }
                else
                {
                    MessageBox.Show($"Error al guardar el estudiante: {result.Content.ReadAsStringAsync().Result}");
                }
                Clear();
                GetAllStudents();
            }
        }

        private void Clear()
        {
            txtStudentId.Text = string.Empty;
            txtStudentName.Text = string.Empty;
            id = 0;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvEStudiante.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetStudentById(id);
                }
            }
        }

        private async void GetStudentById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Estudiante", id));
                if (response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadAsStringAsync();
                    EstudianteDto studentDto = JsonConvert.DeserializeObject<EstudianteDto>(student);
                    txtStudentId.Text = studentDto.EstudianteId.ToString();
                    txtStudentName.Text = studentDto.Nombre;
                    comboBox1.Text = studentDto.GrupoId.ToString();
                    txtCarnett.Text = studentDto.Carnet.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el estudiante: {response.StatusCode}");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteStudent();
        }

        private async void DeleteStudent()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7262/api/Estudiante");
                var responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Estudiante", id));
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Estudiante eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el estudiante {responseMessage.StatusCode}");
            }
            Clear();
            GetAllStudents();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
