using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora {
    public class Calculos {
        private List<string> listaHistorico;
        public Calculos(){
            listaHistorico = new List<string>();
        }
        public int somar(int n1, int n2) {
            int res = n1 + n2;
            listaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public int subtrair(int n1, int n2) {
            int res = n1 - n2;
            listaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public int multiplicar(int n1, int n2) {
            int res = n1 * n2;
            listaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public int dividir(int n1, int n2) {
            int res = n1 / n2;
            listaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public List<string> historico () {
            List<string> res;
            listaHistorico.RemoveRange(3, listaHistorico.Count -3);
            return listaHistorico;
        }
    }
}
