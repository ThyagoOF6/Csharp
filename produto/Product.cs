using System.Globalization;

namespace Produto {
    class Product {

        private string _nome;
        public double Preco { get; private set; }
        private int Quantidade { get; private set; }
        public Produto() {
        }
        public Produto() {
            Quantidade = 0;
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set { 
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidade Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}