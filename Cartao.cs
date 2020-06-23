namespace Aula23_Sprint4_ListasDeObjetos
{
    public class Cartao
    {
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string CVV { get; set; }
        public string Bandeira { get; set; }

        public Cartao(){

        }
        public Cartao(string _titular, string _numero, string _cvv, string _bandeira){
            this.Titular  = _titular;
            this.Numero   = _numero;
            this.CVV      = _cvv;
            this.Bandeira = _bandeira;
        }
    }
}