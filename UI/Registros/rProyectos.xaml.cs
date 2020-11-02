using David_P2_AP1.BLL;
using David_P2_AP1.DAL;
using David_P2_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace David_P2_AP1.UI.Registros
{
    /// <summary>
    /// Interaction logic for Registro.xaml
    /// </summary>
    public partial class rProyectos: Window
    {
        Proyectos proyecto = new Proyectos();
        public rProyectos()
        {
            InitializeComponent();
            TipoTareaComboBox.ItemsSource = TipoTareasBLL.GetList();
            TipoTareaComboBox.SelectedValuePath = "TipoId";
            TipoTareaComboBox.DisplayMemberPath = "Descripcion";  
        }
        private void Limpiar()
        {
            this.proyecto = new Proyectos();
            this.proyecto.Fecha = DateTime.Now;
            this.DataContext = proyecto;
        }
        private void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
            Proyectos encontrado = ProyectosBLL.Buscar(Convert.ToInt32(ProyectoIdTextBox.Text));

            if (encontrado != null)
            {
                this.proyecto = encontrado;
                this.DataContext = null;
                this.DataContext = proyecto;
            }
            else
            {
                Limpiar();
                MessageBox.Show("Proyecto no encontrado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarBoton_Click(object sender, RoutedEventArgs e)
        {
            Proyectos existe = ProyectosBLL.Buscar(this.proyecto.ProyectoId);

            if (existe == null)
            {
                MessageBox.Show("Proyecto no encontrado", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                ProyectosBLL.Eliminar(this.proyecto.ProyectoId);
                MessageBox.Show("Eliminado", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
        }
        private void GuardarBoton_Click(object sender, RoutedEventArgs e)
        {
            bool paso = false;

            if (Validar())
                paso = ProyectosBLL.Guardar(proyecto);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Error al guardar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private bool Existe()
        {
            Proyectos esValido = ProyectosBLL.Buscar(proyecto.ProyectoId);

            return (esValido != null);
        }
        private void AgregarBoton_Click(object sender, RoutedEventArgs e)
        {
            Contexto context = new Contexto();
            proyecto.Tiempo += Convert.ToInt32(TiempoTextBox.Text);
            proyecto.Detalle.RemoveAt(TareasDataGrid.SelectedIndex);
            this.DataContext = null;
            this.DataContext = proyecto;
        }

        private void RemoverBoton_Click(object sender, RoutedEventArgs e)
        {
            if (TareasDataGrid.Items.Count >= 1 && TareasDataGrid.SelectedIndex <= TareasDataGrid.Items.Count - 1)
            {
                ProyectosDetalle project = (ProyectosDetalle)TareasDataGrid.SelectedValue;
                proyecto.Tiempo -=  project.Tiempo;
                proyecto.Detalle.RemoveAt(TareasDataGrid.SelectedIndex);
                this.DataContext = null;
                this.DataContext = proyecto;
            }
        }

    }
}
