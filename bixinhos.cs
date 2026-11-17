namespace MundoSanrio {
    public abstract class personagemSanrio {
        private int fome;
        private int energia;
        private int amizade;

        public string Nome { get; private set; }
        public string comidaFavorita { get; protected set; }

        public int Fome {
            get { return fome; }
            protected set { fome = limitar(value); }
        }

        public int Energia {
            get { return energia; }
            protected set { energia = limitar(value); }
        }

        public int Amizade {
            get { return amizade; }
            protected set { amizade = limitar(value); }
        }

        protected personagemSanrio(string _nome, string _comidaFavorita) {
            Nome = _nome;
            comidaFavorita = _comidaFavorita;
            Fome = 30;
            Energia = 80;
            Amizade = 60;
        }

        public string Humor {
            get {
                if (Fome >= 80)
                    return "Com fominha";
                if (Energia <= 20)
                    return "Com soninho";
                if (Amizade >= 70)
                    return "Super fofo e feliz";
                return "Querendo atenção";
            }
        }

        public virtual string ComerDoce() {
            Fome -= 30;
            Amizade += 10;
            return $"{Nome} comeu {comidaFavorita} e tá de buchin chei!";
        }

        public virtual string PassearNoParque() {
            if (Energia < 20)
                return $"{Nome} está cansadinho demais para passear agora.";

            Amizade += 20;
            Energia -= 15;
            Fome += 10;
            return $"{Nome} passeou pelo parque Sanrio e fez novos amigos!";
        }

        public virtual string TirarSoneca() {
            Energia += 50;
            Fome += 10;
            return $"{Nome} a mimir.";
        }

        public void PassarTempo() {
            Fome += 10;
            Energia -= 5;
            Amizade -= 5;
        }

        public abstract string fraseFofa();

        private int limitar(int _valor) {
            if (_valor < 0)
                return 0;
            if (_valor > 100)
                return 100;
            return _valor;
        }
    }
}