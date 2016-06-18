/*
Arduino Mail par Esteban Cadic le 18/06/2016
Partie : Apllication Windows : C#
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using S22.Imap; 

namespace ArduinoMail
{
    public partial class ArduinoMail : Form
    {
        ImapClient mailbox;
        SerialPort arduino; 

        public ArduinoMail()
        {
            InitializeComponent();
        }

        private void ArduinoMail_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); // On récupère tous les ports séries
            foreach (string port in ports)
            {
                portArduinoComboBox.Items.Add(port); // Et on les affiche dans la combobox 
            }
        }

        private void okButton_Click(object sender, EventArgs e) // Quand on appuie sur le bouton "Valider"
        {
            arduino = new SerialPort(portArduinoComboBox.SelectedItem.ToString(), 9600); // On se connecte à l'Arduino
            arduino.Open();

            mailbox = new ImapClient(srvImapTextBox.Text, Convert.ToInt32(portImapTextBox.Text), emailTextBox.Text, passTextBox.Text, AuthMethod.Login, sllCheckBox.Checked); // On se connecte à la boîte mail
            mailbox.NewMessage += NewMail; // On crée un nouvel événement qui se déclenche quand on reçois un mail (via le protocole IMAP IDLE) 

            okButton.Enabled = false;
        }

        private void NewMail(object sender, IdleMessageEventArgs e)
        {
            arduino.Write("##1"); // On envoie "##1" à l'Ardunio
        }

        private void sourcesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Estylos/Arduino-Mail"); // Sources
        }

        private void ArduinoMail_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (arduino != null)
            {
                if (arduino.IsOpen)
                {
                    arduino.Close(); // Si on est connecté à l'Arduino, on ferme la connexion  
                }
            }
        }
    }
}
