using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Form1 : Form
    {
        // Atributos
        public Queue<Persona> ColaGeneral = new Queue<Persona>();
        public Queue<Persona> ColaPreferencial = new Queue<Persona>();
        
        // Constructor
        public Form1()
        {
            InitializeComponent();
            LabelsFilasVacias();
            LabelsAtendidosVacias();
        }

        /* * * * * * * * * * * * * *
         *      B O T O N E S      *
         * * * * * * * * * * * * * */

        // Nombre: botonVentanillaGeneral_Click
        // Proposito: al presionarlo, remueve el elemento mas antiguo de la cola ColaGeneral y actualiza la interfaz grafica.
        private void botonVentanillaGeneral(object sender, EventArgs e)
        {
            // Si hay elementos en la cola ColaGeneral, realiza un Dequeue, de lo contrario, limpia el segmento de "siendo atendido"
            if (ColaGeneral.Count > 0)
            {
                LabelsFilasVacias();
                Persona temp = ColaGeneral.Dequeue();
                label5.Text = temp.Nombre;
                ImprimirNombresEnLabels();
                ImprimirColoresEnLabels();
                ImprimirEnCuadros();
            }
            else
            {
                label5.Text = "";
                pictureBox5.Visible = false;
                MessageBox.Show("No hay mas personas en la FILA GENERAL");
            }
        }

        // Nombre: botonVentanillaPreferencial_Click
        // Proposito: al presionarlo, remueve el elemento mas antiguo de la cola ColaPreferencial y actualiza la interfaz grafica
        private void botonVentanillaPreferencial(object sender, EventArgs e)
        {
            // Si hay elementos en la cola ColaPreferencial, realiza un Dequeue, de lo contrario, limpia el segmento de "siendo atendido"
            if (ColaPreferencial.Count > 0)
            {
                LabelsFilasVacias();
                Persona temp = ColaPreferencial.Dequeue();
                label10.Text = temp.Nombre;
                ImprimirNombresEnLabels();
                ImprimirColoresEnLabels();
                ImprimirEnCuadros();
            }
            else
            {
                label10.Text = "";
                pictureBox10.Visible = false;
                MessageBox.Show("No hay mas personas en la FILA PREFERENCIAL");
            }
        }

        // Nombre: botonAgregarPersona_Click
        // Proposito: al presionarlo, agrega un objeto persona a la cola correspondiente y actualiza la interfaz grafica.
        private void botonAgregarPersona_Click(object sender, EventArgs e)
        {
            // Asegurarse que los campos de escritura esten completos
            if (VerificarCampos())
            {
                Guardar();
                ImprimirEnCuadros();
                ImprimirNombresEnLabels();
                ImprimirColoresEnLabels();
                LimpiarAyudasEnCampos();
                LimpiarCampos();
            }
            else
            {
                LimpiarAyudasEnCampos();
                ImprimirAyudasEnCampos();
            }
            
        }

        // Nombre: botonFinalizar_Click
        // Proposito: al presionarlo, la aplicacion finaliza.
        private void botonFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Nombre: botonDemo_Click
        // Proposito: al presionarlo, llama al metodo LlenarColasDEMO. Al llamarlo, inserta objetos Persona en las colas. Posteriormente actualiza la interfaz grafica.
        private void botonDemo_Click(object sender, EventArgs e)
        {
            LlenarColasDEMO();
            ImprimirNombresEnLabels();
            ImprimirEnCuadros();
            ImprimirColoresEnLabels();
        }

        // Nombre: botonNueva persona_Click
        // Proposito: al presionarlo, limplia los campos del formulario para el ingreso de una nueva persona a su cola correspondiente.
        private void botonNuevaPersona_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LimpiarAyudasEnCampos();
        }

        /* * * * * * * * * * * * * *
         *      A C C I O N E S    *
         * * * * * * * * * * * * * */

        // Nombre: LabelsFilasVacias
        // Proposito: imprime texto vacio en los objetos label que pertenecen a las secciones "Fila general" y "Fila preferencial".
        private void LabelsFilasVacias()
        {
            Label[] arrLabel = { label1, label2, label3, label4, label6, label7, label8, label9 };
            PictureBox[] arrPics = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };

            foreach (Label lbl in arrLabel)
                lbl.Text = "";

            foreach (PictureBox pbox in arrPics)
                pbox.Visible = false;
        }

        // Nombre: LabelsAtendidosVacias
        // Proposito: imprime texto vacio en los objetos label que pertenecen a la seccion "Siendo atendido". 
        private void LabelsAtendidosVacias()
        {
            label5.Text = "";
            label10.Text = "";
        }

        // Nombre: LimpiarCampos
        // Proposito: remueve las ayudas de completacion de campos y limpia los cuadros de texto en la seccion "Formulario"
        public void LimpiarCampos()
        {
            nombreRequerido.Visible = false;
            ingresoNombre.Text = string.Empty;
            ingresoEdad.Text = string.Empty;
            discapacidadNo.Checked = false;
            discapacidadSi.Checked = false;
            ingresoNombre.Focus();
        }

        // Nombre: DiscapacitadoChecked
        // Proposito: retorna true si es que un radio button en la seccion "Formulario" fue presionado, false en caso contrario.
        public bool DiscapacitadoChecked()
        {
            if (discapacidadSi.Checked || discapacidadNo.Checked)
                return true;
            else
                return false;
        }

        // Nombre: EsDiscapacitado
        // Proposito: retorna true si es que el radio button "discapacidadSi" en la seccion "Formulario" fue presionado, false en caso contrario.
        public bool EsDiscapacitado()
        {
            if (discapacidadSi.Checked)
                return true;
            return false;
        }

        // Nombre: VerificarCampos
        // Proposito: retorna true si es que todos los campos en la seccion "Formulario" fueron completados.
        private bool VerificarCampos()
        {
            bool valido;
            if (ingresoNombre.Text == "" || ingresoEdad.Text == "" || DiscapacitadoChecked() == false)
                valido = false;
            else
                valido = true;
            return valido;
        }

        // Nombre: ImprimirAyudasEnCampos
        // Proposito: despliega indicadores graficos en los campos de la seccion "Formulario" que no han sido completados.
        private void ImprimirAyudasEnCampos()
        {
            if (ingresoNombre.Text == "")
            {
                nombreRequerido.Visible = true;
                ingresoNombre.BackColor = System.Drawing.Color.MistyRose;
            }
            if (ingresoEdad.Text == "")
            {
                edadRequerida.Visible = true;
                ingresoEdad.BackColor = System.Drawing.Color.MistyRose;
            }
            if (DiscapacitadoChecked() == false)
            {
                discapacidadRequerida.Visible = true;
            }
        }

        // Nombre: LimpiarAyudasEnCampos
        // Proposito: remueve todos los indicadores graficos en los campos de la seccion "Formulario".
        private void LimpiarAyudasEnCampos()
        {
            nombreRequerido.Visible = false;
            ingresoNombre.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8e8ea");

            edadRequerida.Visible = false;
            ingresoEdad.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8e8ea");

            discapacidadRequerida.Visible = false;
        }

        // Nombre: Guardar
        // Proposito: agrega un objeto tipo Persona a la cola correspondiente si es que los datos en la seccion "Formulario" fueron ingresados correctamente
        private void Guardar()
        {
            Persona usuario = new Persona();

            // Verificar que la edad sea un entero
            int edad;
            if(int.TryParse(ingresoEdad.Text, out edad))
            {
                usuario.Nombre = ingresoNombre.Text;
                usuario.Edad = edad;
                usuario.Discapacidad = EsDiscapacitado();

                // La person debe tener entre 10 y 115 años de edad
                if (usuario.Edad > 10 && usuario.Edad < 115)
                {
                    // Si la persona tiene alguna discapacidad o es de tercera edad se lo ingresa en la cola ColaPreferencial, de lo contrario, en la cola ColaGeneral.
                    if (EsDiscapacitado() || usuario.Edad >= 60)
                        ColaPreferencial.Enqueue(usuario);
                    else
                        ColaGeneral.Enqueue(usuario);
                }
                else
                    MessageBox.Show("Edad inválida");
            }
            else
                MessageBox.Show("Edad inválida");
        }

        // Nombre: Guardar (sobrecargado)
        // Proposito: agrega un objeto tipo Persona a la cola correspondiente.
        private void Guardar(Persona usuario)
        {
            if (usuario.Discapacidad || usuario.Edad > 60)
                ColaPreferencial.Enqueue(usuario);
            else
                ColaGeneral.Enqueue(usuario);
        }

        // Nombre: LlenarColasDEMO
        // Proposito: inserta objetos tipo Persona en las colas ColaGenera y ColaPreferencial
        public void LlenarColasDEMO()
        {
            // Instanciar personas para la cola ColaPreferencial
            Persona persona1 = new Persona("Pref_uno", 20, true);
            Persona persona2 = new Persona("Pref_dos", 80, true);
            Persona persona3 = new Persona("Pref_tres", 20, true);
            Persona persona4 = new Persona("Pref_cuatro", 20, true);
            Persona persona5 = new Persona("Pref_cinco", 20, true);
            Persona persona6 = new Persona("Pref_seis", 65, true);
            Persona persona7 = new Persona("Pref_siete", 20, true);
            Persona persona8 = new Persona("Pref_ocho", 20, true);
            Persona persona9 = new Persona("Pref_nueve", 27, true);
            Persona persona10 = new Persona("Pref_diez", 20, true);
            Persona persona11 = new Persona("Pref_once", 35, true);

            // Instanciar personas para la cola ColaGeneral
            Persona persona31 = new Persona("Gen_uno", 21, false);
            Persona persona32 = new Persona("Gen_dos", 26, false);
            Persona persona33 = new Persona("Gen_tres", 20, false);
            Persona persona34 = new Persona("Gen_cuatro", 20, false);
            Persona persona35 = new Persona("Gen_cinco", 45, false);
            Persona persona36 = new Persona("Gen_seis", 20, false);
            Persona persona37 = new Persona("Gen_siete", 26, false);
            Persona persona38 = new Persona("Gen_ocho", 20, false);
            Persona persona39 = new Persona("Gen_nueve", 52, false);
            Persona persona40 = new Persona("Gen_diez", 29, false);
            Persona persona41 = new Persona("Gen_once", 33, false);

            // Agregar las personas a una lista
            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(persona1);
            listaPersonas.Add(persona2);
            listaPersonas.Add(persona3);
            listaPersonas.Add(persona4);
            listaPersonas.Add(persona5);
            listaPersonas.Add(persona6);
            listaPersonas.Add(persona7);
            listaPersonas.Add(persona8);
            listaPersonas.Add(persona9);
            listaPersonas.Add(persona11);
            listaPersonas.Add(persona31);
            listaPersonas.Add(persona32);
            listaPersonas.Add(persona33);
            listaPersonas.Add(persona34);
            listaPersonas.Add(persona35);
            listaPersonas.Add(persona36);
            listaPersonas.Add(persona37);
            listaPersonas.Add(persona38);
            listaPersonas.Add(persona39);
            listaPersonas.Add(persona40);
            listaPersonas.Add(persona41);

            // Introducir a las personas en la cola que les corresponde
            foreach (Persona temp in listaPersonas)
                Guardar(temp);
        }

        // Nombre: ImprimirColoresEnLabels
        // Proposito: imprime un fondo de color en las filas si es que una persona ocupa un puesto en el label correspondiente.
        public void ImprimirColoresEnLabels()
        {
            Label[] arrLabel = { label1, label2, label3, label4, label6, label7, label8, label9 };

            // Los objetos tipo Label de la seccion "Fila general" y "Fila preferencial" son impresos con un tono celeste (LightBlue) de fondo.
            foreach (Label lbl in arrLabel)
                if (lbl.Text != "")
                    lbl.BackColor = System.Drawing.Color.LightBlue;

            // Los objetos tipo Label de la seccion "Fila general" y "Fila preferencial" son impresos con un tono rojo (LightCoral) de fondo.
            if (label5.Text != "")
                label5.BackColor = System.Drawing.Color.LightCoral;
            if (label10.Text != "")
                label10.BackColor = System.Drawing.Color.LightCoral;

            // Llamada al metodo ImprimirImagenes para su despliegue si es que el label correspondiente contiene un nombre.
            ImprimirImagenes();
        }

        // Nombre: ImprimirNombresEnLabels
        // Proposito: imprime los nombres en las filas correspondientes.
        private void ImprimirNombresEnLabels()
        {
            Label[] arrLabelGeneral = { label1, label2, label3, label4 };
            Label[] arrLabelPreferencial = { label6, label7, label8, label9 };
            Persona[] arrGeneral = ColaGeneral.ToArray();
            Persona[] arrPreferencial = ColaPreferencial.ToArray();

            // Impresion de los nombres en la seccion "Fila general".
            int i = 0;
            while (ColaGeneral.Count > 0 && i < 4 && i < arrGeneral.Length)
            {
                arrLabelGeneral[i].Text = arrGeneral[i].Nombre;
                i++;
            }

            // Impresion de los nombres en la seccion "Fila preferencial".
            i = 0;
            while (ColaPreferencial.Count > 0 && i < 4 && i < arrPreferencial.Length)
            {
                arrLabelPreferencial[i].Text = arrPreferencial[i].Nombre;
                i++;
            }
        }

        // Nombre: ImprimirEnCuadros
        // Proposito: imprime los nombres de las persona en el TextBox cuadroFilaGeneral y cuadroFilaPreferencial.
        private void ImprimirEnCuadros()
        {
            Persona[] arrGeneral = ColaGeneral.ToArray();
            string cuadroGeneral = "";
            Persona[] arrPreferencial = ColaPreferencial.ToArray();
            string cuadroPreferencial = "";

            // Concatenacion de los nombres del arreglo cuadroGeneral si es que el arreglo tiene mas de 4 nombres
            if (arrGeneral.Length > 4)
                for (int i = 4; i < arrGeneral.Length; i++)
                    cuadroGeneral += arrGeneral[i].Nombre + "\r\n";

            // Concatenacion de los nombres del arreglo cuadroPreferencial si es que el arreglo tiene mas de 4 nombres
            if (arrPreferencial.Length > 4)
                for (int i = 4; i < arrPreferencial.Length; i++)
                    cuadroPreferencial += arrPreferencial[i].Nombre + "\r\n";

            // Impresion de las cadenas de caracteres (nombres concatenados) en los cuadros correspondientes
            cuadroFilaGeneral.Text = cuadroGeneral;
            cuadroFilaPreferencial.Text = cuadroPreferencial;
        }

        // Nombre: ImprimirImagenes
        // Proposito: imprime la imagen de una persona si es que el objeto Label a la que se relaciona contiene un nombre.
        private void ImprimirImagenes()
        {
            Label[] arrLabel = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            PictureBox[] arrPics = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };

            for(int i = 0; i < 10; i++)
            {
                if (arrLabel[i].Text == "")
                    arrPics[i].Visible = false;
                else
                    arrPics[i].Visible = true;
            }
        }        
    }
}
