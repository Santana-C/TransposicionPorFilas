using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransposicionPorFilas {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void cambiarAlgoritmo(object sender, EventArgs e) {
            if(((RadioButton) sender).Text.Contains("Clave")) {
                txtClave.Clear();
                txtClave.Enabled = true;
                numRenglones.Enabled = false;
            }
            else {
                numRenglones.Value = 1;
                txtClave.Enabled = false;
                numRenglones.Enabled = true;
            }
        }

        private void cambiarAccion(object sender, EventArgs e) {
            if(radCifrar.Checked)
                btnAccionar.Text = "Cifrar";
            else
                btnAccionar.Text = "Descifrar";
        }

        private void btnAccionar_Click(object sender, EventArgs e) {
            txtMensajeClaro.Text = txtMensajeClaro.Text.Trim();
            int CantidadRenglones;
            if(radSimpleClave.Checked || radDobleClave.Checked) {
                //Validar que la clave cumpla con los requisitos.
                if(txtClave.Text == null || txtClave.Text.Trim().Length == 0) {
                    MessageBox.Show("Ingrese una clave válida. No puede dejar la clave vacia", "Clave no válida");
                    return;
                }
                for(int i = 0; i < txtClave.Text.Length; i++) {
                    if(txtClave.Text.IndexOf(txtClave.Text[i]) != txtClave.Text.LastIndexOf(txtClave.Text[i])) {
                        MessageBox.Show("Ingrese una clave válida. No puede tener caracteres repetidos en la clave", "Clave no válida");
                        return;
                    }
                }
                CantidadRenglones = txtClave.Text.Length;
            } else {
                CantidadRenglones = (int)numRenglones.Value;

            }
            string mensaje;
            string Resultado;
            bool contieneClave = radSimpleClave.Checked;

            if(radCifrar.Checked) {
                if(radSimpleClave.Checked)
                    mensaje = txtClave.Text.Trim() + txtMensajeClaro.Text;
                else
                    mensaje = txtMensajeClaro.Text;
                Resultado = Cifrar(mensaje, CantidadRenglones, contieneClave);
                if(radDoble.Checked || radDobleClave.Checked) {
                    Resultado = txtClave.Text.Trim() + Resultado;
                    Resultado = Cifrar(Resultado, CantidadRenglones, contieneClave || radDobleClave.Checked);
                }
            } else {
                mensaje = txtMensajeClaro.Text;
                Resultado = Descifrar(mensaje, CantidadRenglones, contieneClave || radDobleClave.Checked);
                if(radDoble.Checked || radDobleClave.Checked) {
                    Resultado = Descifrar(Resultado, CantidadRenglones, contieneClave);
                }
            }
            txtResultado.Text = Resultado;
        }

        private string Cifrar(string mensaje, int renglones, bool contieneClave) {
            int columnas = mensaje.Length % renglones == 0 ? (mensaje.Length / renglones) : (mensaje.Length / renglones) + 1;
            char[][] matriz = new char[renglones][];
            for(int i = 0; i < matriz.Length; i++) 
                matriz[i] = new char[columnas];
            int indice = 0;

            for(int i = 0; i < columnas; i++) {
                for(int j = 0; j < renglones; j++) {
                    try {
                        //Se llena la matriz de abajo hacia arriba y de izquierda a derecha
                        matriz[j][i] = mensaje[indice];
                    } catch { matriz[j][i] = 'X'; }
                    indice++;
                }
            }
            //Si se está usando clave ordenamos las filas de manera alfabetica.
            if(contieneClave)
                matriz = OrdenarMatriz(matriz, OrdenarClave(txtClave.Text.Trim()));
            string criptograma = "";
            //Construcción del criptograma, se mueve de izquierda a derecha y de arriba hacia abajo
            for(int i = 0; i < renglones; i++) {
                for(int j = contieneClave ? 1 : 0; j < columnas; j++) {
                    criptograma += matriz[i][j];
                }
            }
            return criptograma;
        }

        private string Descifrar(string criptograma, int renglones, bool contieneClave) {
            //Variables necesarias
            int columnas;
            if(contieneClave) {
                columnas = ((criptograma.Length + renglones) % renglones) == 0
                ? ((criptograma.Length + renglones) / renglones) : ((criptograma.Length + renglones) / renglones) + 1;
            } else {
                columnas = (criptograma.Length % renglones) == 0 ? (criptograma.Length / renglones) : (criptograma.Length / renglones) + 1;
            }
            char[][] matriz = new char[renglones][];
            for(int i = 0; i < matriz.Length; i++) 
                matriz[i] = new char[columnas];
            int indice = 0;
            //Llenado de la matriz
            string claveOrdenada = OrdenarClave(txtClave.Text.Trim());
            for(int i = 0; i < renglones; i++) {
                if(contieneClave)
                    matriz[i][0] = claveOrdenada[i];
                for(int j = contieneClave ? 1 : 0; j < columnas; j++) {
                    try {
                        matriz[i][j] = criptograma[indice];
                    } catch { matriz[i][j] = 'X'; }
                    indice++;
                }
            }
            //Si se está usando clave ordenamos las filas de manera alfabetica.
            if(contieneClave)
                matriz = OrdenarMatriz(matriz, txtClave.Text.Trim());
            string mensaje = "";
            for(int i = 0; i < columnas; i++) {
                for(int j = 0; j < renglones; j++) {
                    mensaje += matriz[j][i];
                }
            }
            //Si se maneja una llave se recorta la llave para retornar solo el mensaje
            if(contieneClave)
                mensaje = mensaje.Substring(renglones);
            return mensaje;
        }
        private string OrdenarClave(string clave) {
            return String.Concat(clave.OrderBy(c => c));
        }
        private char[][] OrdenarMatriz(char[][] matriz, string clave) {
            char[][] nuevaMatriz = new char[matriz.Length][];
            int indice = 0;
            foreach(var caracter in clave) {
                for(int i = 0; i < matriz.Length; i++) {
                    if(matriz[i][0] == caracter) {
                        nuevaMatriz[indice] = matriz[i];
                        nuevaMatriz[indice][0] = caracter;
                        indice++;
                    }
                }
            }
            return nuevaMatriz;
        }
    }
}
