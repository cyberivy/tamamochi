namespace MundoSanrio{
    public class HelloKitty : personagemSanrio {
        public HelloKitty() : base("Hello Kitty", "Torta de Maçã") {
        }

        public override string fraseFofa() {
            return "Hello Kitty: Você nunca tem amigos demais!";
        }
    }

    public class Cinnamoroll : personagemSanrio {
        public Cinnamoroll() : base("Cinnamoroll", "Rolinho de Canela") {
        }

        public override string PassearNoParque() {
            if (Energia < 20)
                return "Cinnamoroll está cansado demais para voar.";

            Amizade += 25;
            Energia -= 15;
            Fome += 10;
            return "Cinnamoroll voou usando suas orelhas grandes e se divertiu muito!";
        }

        public override string fraseFofa() {
            return "Cinnamoroll: Vamos voar até as nuvens!";
        }
    }

        public class Kuromi : personagemSanrio {
        public Kuromi() : base("Kuromi", "Cebolinha em conserva") {
        }

        public override string fraseFofa() {
            return "Kuromi: Eu sou descolada, mas também sou fofa!";
        }
    }
}