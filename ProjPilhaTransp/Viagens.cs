using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPilhaTransp
{
    class Viagens
    {
        //CLASSE OK
        #region ATRIBUTOS
        private Queue<Viagem> viagens;
        #endregion

        #region PROPRIEDADES
        public Queue<Viagem> Viagems
        {
            get { return this.viagens; }
        }
        #endregion

        #region CONSTRUTORES
        public Viagens()
        {
            this.viagens = new Queue<Viagem>();
        }

        public Viagens(Queue<Viagem> viagens)
        {
            this.viagens = viagens;
        }
        #endregion

        #region METODOS
        public void incluir(Viagem viagem)
        {
            Garagens grns = new Garagens();

            if (grns.JornadaAtiva == true)
                Viagems.Enqueue(viagem);
            else
                Console.WriteLine("A viagem não pode ser inicializada /n Inicialize a jornada e tente novamente...");
        }
        #endregion

        #region SUGESTAO
        /*
         public Queue<Viagem> viagens = new Queue<Viagem>();
        
        internal Queue<Viagem> _Viagens
        {
            get
            {
                return viagens;
            }

            set
            {
                viagens = value;
            }
        }
        
        public void incluir (Viagem viagem)
        {
            _Viagens.Enqueue(viagem);
        }
         */
        #endregion
    }//CLASS
}//NAMESPACE
