using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MayronDiarioClasse.Views
{
    public partial class DetalheView : ContentPage
    {
        public Disciplina Disciplina { get; set; }

        private const int VALOR_BIMESTRAL = 40;
        private const int VALOR_SEMESTRAL = 120;
        private const int VALOR_ANUAL = 240;

        public string TextoBimestral
        {
            get
            {
                return string.Format("Bimestral - Carga Horario {0}", VALOR_BIMESTRAL);
            }
        }

        public string TextoSemestral
        {
            get
            {
                return string.Format("Semestral - Carga Horaria {0}", VALOR_SEMESTRAL);
            }
        }

        public string TextoAnual
        {
            get
            {
                return string.Format("Anual - Carga Horaria {0}", VALOR_ANUAL);
            }
        }

        bool temBimestral;
        public bool TemBimestral
        {
            get
            {
                return temBimestral;
            }
            set
            {
                temBimestral = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CargaTotalFormatada));
            }
        }

        bool temSemestral;
        public bool TemSemestral
        {
            get
            {
                return temSemestral;
            }
            set
            {
                temSemestral = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CargaTotalFormatada));
            }
        }

        bool temAnual;
        public bool TemAnual
        {
            get
            {
                return temAnual;
            }
            set
            {
                temAnual = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CargaTotalFormatada));
            }
        }

        public decimal CargaTotal
        {
            get
            {
                return Disciplina.carga
                    + (TemBimestral ? VALOR_BIMESTRAL : 0)
                    + (TemSemestral ? VALOR_SEMESTRAL : 0)
                    + (TemAnual ? VALOR_ANUAL : 0);
            }
        }

        public string CargaTotalFormatada
        {
            get
            {
                return string.Format("Carga Horaria: {0} Horas ", CargaTotal);
            }
        }

        public DetalheView(Disciplina disciplina)
        {
            this.Disciplina = disciplina;
            InitializeComponent();
            this.BindingContext = this;
        }

        private void botaoProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DadoView(this.Disciplina));
        }
    }
}