
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
using SchoolAPI.Models.Dto;
using ActaNotasAPI.Models.Dto;

namespace Acta_Notas
{
    public partial class Grupo : Form
    {

        private static int id = 0;
        public Grupo()
        {
            InitializeComponent();
        }
        private async void GetAllGrupo
          ()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7262/api/Grupo");
                if (response.IsSuccessStatusCode)
                {
                    var students = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<GrupoDto>>(students);
                    dgvGrupo.DataSource = result.ToList();

                    GrupoUpdateDto calificacionDto = new GrupoUpdateDto();





                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de grupo {response.StatusCode}");
                }
            }
        }

        private async void UpdateGrupo()
        {

            GrupoUpdateDto studentDto = new GrupoUpdateDto();
            id = Convert.ToInt32(txtGrupoId.Text);
            studentDto.GrupoId = Convert.ToInt32(txtGrupoId.Text);
            studentDto.Nombre = txtGrupoNombre.Text;
            studentDto.Año = Convert.ToString(txtAño.Text);

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(studentDto);
                var content = new StringContent(serializedStudent, Encoding.UTF8,
                    "application/json");
                var responseMessage = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Grupo", id),
                    content);
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Grupo actualizado");
                else
                    MessageBox.Show($"Error al actualizar  el grupo {responseMessage.StatusCode}");

            }
            Clear();
            GetAllGrupo();

        }

        private async void AddGrupo()
        {

            GrupoCreateDto studentDto = new GrupoCreateDto();

            studentDto.Nombre = txtGrupoNombre.Text;
            studentDto.Año = Convert.ToString(txtAño.Text);

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(studentDto);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://localhost:7262/api/Grupo", content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Grupo agregado correctamente");
                }
                else
                {
                    MessageBox.Show($"Error al guardar el grupo: {result.Content.ReadAsStringAsync().Result}");
                }
                Clear();
                GetAllGrupo();
            }
        }

        private void Clear()
        {
            txtGrupoId.Text = string.Empty;
            txtGrupoNombre.Text = string.Empty;

            txtAño.Text = string.Empty;
            id = 0;
        }

        private async void GetGrupoById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Grupo", id));
                if (response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadAsStringAsync();
                    GrupoDto studentDto = JsonConvert.DeserializeObject<GrupoDto>(student);
                    txtGrupoId.Text = studentDto.GrupoId.ToString();
                    txtGrupoNombre.Text = studentDto.Nombre.ToString();

                    txtAño.Text = studentDto.Año.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el grupo: {response.StatusCode}");
                }
            }
        }

        private async void DeleteGrupo()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7262/api/Grupo");
                var responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7262/api/Grupo", id));
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Grupo eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el grupo {responseMessage.StatusCode}");
            }
            Clear();
            GetAllGrupo();
        }


        private void dgvAsignatura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGrupo.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetGrupoById(id);
                }
            }
        }

        private void Grupo_Load(object sender, EventArgs e)
        {
            GetAllGrupo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddGrupo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteGrupo();
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateGrupo();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
