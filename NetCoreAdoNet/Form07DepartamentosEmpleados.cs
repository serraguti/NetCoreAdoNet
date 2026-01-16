using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;

        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            List<string> nombres = await this.repo.GetNombreDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string name in nombres)
            {
                this.lstDepartamentos.Items.Add(name);
            }
        }

        private async void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstDepartamentos.SelectedIndex != -1)
            {
                string nombreDepartamento = this.lstDepartamentos.SelectedItem.ToString();
                await this.LoadEmpleados(nombreDepartamento);
            }
        }

        private async Task LoadEmpleados(string nombreDepartamento)
        {
            List<string> apellidos =
                await this.repo.GetApellidosEmpleadosAsync(nombreDepartamento);
            this.lstEmpleados.Items.Clear();
            foreach (string ape in apellidos)
            {
                this.lstEmpleados.Items.Add(ape);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstEmpleados.SelectedIndex != -1)
            {
                string apellido = this.lstEmpleados.SelectedItem.ToString();
                await this.repo.DeleteEmpleadoAsync(apellido);
                string nombreDepartamento = this.lstDepartamentos.SelectedItem.ToString();
                await this.LoadEmpleados(nombreDepartamento);
            }
        }
    }
}
