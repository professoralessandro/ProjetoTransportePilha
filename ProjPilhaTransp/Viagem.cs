using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPilhaTransp
{
    class Viagem
    {
        //CLASSE OK
        #region ATRIBUTOS
        private Int32 id;
        private Garagem origem;
        private Garagem destino;
        private Veiculo veiculo;
        #endregion

        #region PROPRIEDADES

        public Int32 Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public Garagem Origem
        {
            get { return this.origem; }
            set { this.origem = value; }
        }

        public Garagem Destino
        {
            get { return this.destino; }
            set { this.destino = value; }
        }

        public Veiculo Veiculo
        {
            get { return this.veiculo; }
            set { this.veiculo = value; }
        }
        #endregion

        #region CONSTRURES
        public Viagem()
        {
            this.id = 0;
            this.origem = new Garagem();
            this.destino = new Garagem();
            this.veiculo = new Veiculo();
        }

        public Viagem(Int32 id)
        {
            this.id = id;
            this.origem = new Garagem();
            this.destino = new Garagem();
            this.veiculo = new Veiculo();
        }

        public Viagem(Int32 id, Garagem origem)
        {
            this.id = id;
            this.origem = origem;
            this.destino = new Garagem();
            this.veiculo = new Veiculo();
        }

        public Viagem(Int32 id, Garagem origem, Garagem destino)
        {
            this.id = id;
            this.origem = origem;
            this.destino = destino;
            this.veiculo = new Veiculo();
        }

        public Viagem(Int32 id, Garagem origem, Garagem destino, Veiculo veiculo)
        {
            this.id = id;
            this.origem = origem;
            this.destino = destino;
            this.veiculo = veiculo;
        }
        #endregion

        #region SUGESTAO
        /*
         COD
        private int ID;
        private Garagem origem;
        private Garagem destino;
        private Veiculo veiculo;

        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        internal Garagem Origem
        {
            get
            {
                return origem;
            }

            set
            {
                origem = value;
            }
        }

        internal Garagem Destino
        {
            get
            {
                return destino;
            }

            set
            {
                destino = value;
            }
        }

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
        public Viagem(int id, Garagem origem, Garagem destino, Veiculo veiculo)
        {
            this.ID1 = id;
            this.Origem = origem;
            this.Destino = destino;
            this.Veiculo = veiculo;
        }
         */
        #endregion
    }//CLASS
}//NAMESPACE
