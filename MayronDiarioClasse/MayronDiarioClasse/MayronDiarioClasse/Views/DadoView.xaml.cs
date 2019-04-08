﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MayronDiarioClasse.Views
{
    public partial class DadoView : ContentPage
    {
        public Disciplina Disciplina { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        public TimeSpan HoraMatricula { get; set; }

        DateTime dataMatricula = DateTime.Today;

        public DateTime DataMatricula
        {
            get
            {
                return dataMatricula;
            }
            set
            {
                dataMatricula = value;
            }
        }

        public DadoView(Disciplina disciplina)
        {
            this.Disciplina = disciplina;
            InitializeComponent();
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Matriculado", "Nome: " + Nome, "Ok");
        }
    }
}