using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPilhaTransp
{
    class Veiculos
    {
        //CLASSE OK
        #region ATRIBUTOS
        private List<Veiculo> veiculos;
        #endregion

        #region PROPRIEDADES
        public List<Veiculo> Veiculs
        {
            get { return this.veiculos; }
        }
        #endregion

        #region CONSTRUTORES
        public Veiculos()
        {
            this.veiculos = new List<Veiculo>();
        }
        #endregion

        #region METODOS
        public void incluir(Veiculo veiculo)
        {
            Veiculs.Add(veiculo);
        }
        #endregion

        #region EDU
        /*
         private List<Veiculo> veic;

        internal List<Veiculo> Veic
        {
            get
            {
                return veic;
            }

            set
            {
                veic = value;
            }
        }
        public Veiculos(List<Veiculo> _veic)
        {
            Veic = _veic;
        }

        public void incluir(Veiculo veiculo)
        {
            Veiculo v = new Veiculo();

           // Veic.Add(v);
            foreach(Veiculo lveiculo in Veic)
            {
                //Veic.Add(v);
                Veic.Add(veiculo);
                
            }
        }
         */
        #endregion
    }//CLASS 
}//NAMESPACE
