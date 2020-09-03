﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros
{
    public partial class Form1 : Form
    {
        private static List<Libro> libros;
        public Form1()
        {
            libros = new List<Libro>();
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fechaField.CustomFormat = "dd/MM/yyyy";
            hidePanels();
            loginPanel.Visible = true;
            //listView1.Columns.Add("Nombre", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("Autor", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("Categoria", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("Cantidad", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("Precio", -2, HorizontalAlignment.Center);
            //listView1.Columns.Add("Fecha", -2, HorizontalAlignment.Left);
            fechaField.Format = DateTimePickerFormat.Custom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var libro = new Libro
            {
                Nombre = nombreField.Text,
                Autor = autorField.Text,
                Cantidad = Int32.Parse(cantidadField.Text),
                Date = fechaField.Value,
                Precio = Decimal.Parse(precioField.Text),
                Categoria = categoriaField.SelectedItem.ToString()
            };
            MessageBox.Show($"Ingreso exitoso {libro.Nombre}");
            libros.Add(libro);
            
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidePanels();
            librosPanel.Visible = true;
        }
        private void hidePanels()
        {
            consultarPanel.Visible = false;
            loginPanel.Visible = false;
            librosPanel.Visible = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidePanels();
            loginPanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nombreField.Text = "";
            autorField.Text = "";
            cantidadField.Text = "";
            fechaField.Text = DateTime.Now.ToString();
            precioField.Text = "";
            categoriaField.SelectedIndex = 0;
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            hidePanels();
            consultarPanel.Visible = true;            
            if (libros.Count > 0)
            {
                foreach (var item in libros)
                {
                    var a = new ListViewItem(item.Nombre);                       
                    a.SubItems.Add(item.Autor);
                    a.SubItems.Add(item.Categoria);
                    a.SubItems.Add(item.Cantidad.ToString());
                    a.SubItems.Add(item.Precio.ToString());
                    a.SubItems.Add(item.Date.ToLocalTime().ToString());
                    listView1.Items.Add(a);                    
                }
                label13.Text = $"Total de libros(Cantidad):{libros.Sum(libro => libro.Cantidad)}";
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void librosPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
