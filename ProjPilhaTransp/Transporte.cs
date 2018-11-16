using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPilhaTransp
{
    class Transporte
    {
        //CLASSE OK
        #region ATRIBUTOS
        private Veiculo veiculo;
        private Int32 qtdeTransportada;
        #endregion

        #region PROPRIEDADES
        //VEICULO
        public Veiculo getVeiculo
        {
            get { return this.veiculo; }
        }
        public Veiculo setVeiculo
        {
            set { this.veiculo = value; }
        }
        //QTDTRANSPORTADA
        public Int32 getQtdeTransportada
        {
            get { return this.qtdeTransportada; }
        }
        public Int32 setQtdeTransportada
        {
            set { this.qtdeTransportada = value; }
        }
        #endregion

        #region CONSTRUTORES
        public Transporte(Veiculo veiculo, Int32 qtdeTransportada)
        {
            this.veiculo = veiculo;
            this.qtdeTransportada = veiculo.Lotacao;
        }
        public Transporte(Int32 qtdeTransportada)
        {
            this.veiculo = new Veiculo();
            this.qtdeTransportada = qtdeTransportada;
        }
        public Transporte(): this(new Veiculo(), 0)
        {

        }
        public Transporte(Veiculo veiculo)
        {
            this.veiculo = veiculo;
            this.qtdeTransportada = veiculo.Lotacao;
        }
        #endregion

        #region METODOS
        #endregion

        #region EDU
        /*
        private Veiculo veiculo;
        private int qtdTransportada;

        internal Veiculo Veiculo
        {
            get
            {
                return veiculo;
            }

            set
            {
                veiculo = value;
            }
        }

        public int QtdTransportada
        {
            get
            {
                return qtdTransportada;
            }

            set
            {
                qtdTransportada = value;
            }
        }

        public Transporte(Veiculo veiculo)
        {
            this.veiculo = veiculo;
            this.qtdTransportada = veiculo.Lotacao;
        }*/
        #endregion
    }//CLASS
}//NAMESPACE
