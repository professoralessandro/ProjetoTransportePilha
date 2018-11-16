using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPilhaTransp
{
    class Veiculo
    {
        //CLASSE OK
        #region ATRIBUTOS
        private Int32 id;
        private String placa;
        private Int32 lotacao;
        #endregion

        #region PROPRIEDADES
        public Int32 Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Placa
        {
            get { return this.placa; }
            set { this.placa = value; }
        }

        public Int32 Lotacao
        {
            get { return this.lotacao; }
            set { this.lotacao = value; }
        }
        #endregion

        #region CONSTRUTORES
        public Veiculo(Int32 id)
        {
            this.id = id;
        }
        public Veiculo(Int32 id, String placa, Int32 lotacao)
        {
            this.id = id;
            this.placa = placa;
            this.lotacao = lotacao;
        }
        public Veiculo() : this( 0, "", 0)
        {
        }
        #endregion

        #region METODOS
        public override bool Equals(object obj)
        {

            return this.Id.Equals(((Veiculo)obj).Id);
        }
        #endregion

        #region EDU
        /*
        private int id;
        private string placa;
        private int lotacao;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
            }
        }

        public int Lotacao
        {
            get
            {
                return lotacao;
            }

            set
            {
                lotacao = value;
            }
        }
        public Veiculo() { }
        public Veiculo(int id)
        {
            this.Id = id;
        }
        public Veiculo(int _id, string _placa, int _lotacao)
        {
            this.Id = _id;
            this.Placa = _placa;
            this.Lotacao = _lotacao;
        }
        public override bool Equals(object obj)
        {

            return this.Id.Equals(((Veiculo)obj).Id);
        }*/
        #endregion  
    }//CLASS
}//NAMESPACE
