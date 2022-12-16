using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Fabricante emp;

        private void btnEmpresa_Click(object sender, RoutedEventArgs e)
        {
            emp = new Fabricante(txtEmpresa.Text);
            MessageBox.Show(emp.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Veiculos x = new Veiculos(txtCliente.Text, txtnomeveic.Text,
                double.Parse(txtLimite.Text));
            emp.Inserir(x);
            ms[s] = x;
            s++;
            // Insere um a um os objetos no ListBox
            // listCliente.Items.Add(x);
            // Insere um vetor num ListBox
            listCliente.ItemsSource = null;
            listCliente.ItemsSource = emp.Listar2();
        }
        private Veiculos[] ms = new Veiculos[10];
        private int s;
        private void maiscaro_Click(object sender, RoutedEventArgs e)
        {
            if (s == 0)
            {
                MessageBox.Show("Não há veículos inseridos no momento !!!");
                return;
            }
            Veiculos aux = ms[0];
            for (int i = 1; i < s; i++)
                if (ms[i].GetPreco() > aux.GetPreco())
                    aux = ms[i];
            MessageBox.Show(aux.ToString());

        }
    }
}