using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker;
using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models;
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

namespace ChatBot
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QnAMakerRuntimeClient cliente;
        string Id;
        List<Mensaje> listaMensajes;

        public MainWindow()
        {
            InitializeComponent();
            string EndPoint = "https://botisma.azurewebsites.net";
            string Key = "38249f96-77a1-46e2-adf4-f29195b93211";
            Id = "e3c48047-80d3-4450-9231-ed4d0985840d";
            cliente = new QnAMakerRuntimeClient(new EndpointKeyServiceClientCredentials(Key)) { RuntimeEndpoint = EndPoint };
            listaMensajes = new List<Mensaje>();
            //MensajesItemsControl.DataContext = listaMensajes;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Settings ventana = new Settings();
            ventana.Owner = this;
            ventana.Show();
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private async void Send_MessageAsync(object sender, RoutedEventArgs e)
        {
            string pregunta = MessageTextBox.Text;

            Mensaje mensajeEnviado = new Mensaje(pregunta, false);
            listaMensajes.Add(mensajeEnviado);

            QnASearchResultList response = await cliente.Runtime.GenerateAnswerAsync(Id, new QueryDTO { Question = pregunta });
            string respuesta = response.Answers[0].Answer;

            Mensaje mensajeBot = new Mensaje(respuesta, true);
            listaMensajes.Add(mensajeBot);
        }

    }
}
