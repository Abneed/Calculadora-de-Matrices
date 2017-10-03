namespace Calculadora_de_Matrices
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtxtInput = new System.Windows.Forms.RichTextBox();
            this.btnDeterminante = new System.Windows.Forms.Button();
            this.grpCalcularA = new System.Windows.Forms.GroupBox();
            this.rtxtboxElevarA = new System.Windows.Forms.RichTextBox();
            this.btnElevar = new System.Windows.Forms.Button();
            this.rtxtboxMultiplicarA = new System.Windows.Forms.RichTextBox();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnTranspuesta = new System.Windows.Forms.Button();
            this.btnInversa = new System.Windows.Forms.Button();
            this.btnCofactores = new System.Windows.Forms.Button();
            this.lblMatrizA = new System.Windows.Forms.Label();
            this.grpOperacionesEntreMatrices = new System.Windows.Forms.GroupBox();
            this.btnMultiplicarAB = new System.Windows.Forms.Button();
            this.btnRestarAB = new System.Windows.Forms.Button();
            this.btnSumarAB = new System.Windows.Forms.Button();
            this.btnIntercambiar = new System.Windows.Forms.Button();
            this.lblMatrizB = new System.Windows.Forms.Label();
            this.grpCalcularB = new System.Windows.Forms.GroupBox();
            this.rtxtboxElevarB = new System.Windows.Forms.RichTextBox();
            this.btnElevarB = new System.Windows.Forms.Button();
            this.rtxtboxMultiplicarB = new System.Windows.Forms.RichTextBox();
            this.btnMultiplicarB = new System.Windows.Forms.Button();
            this.btnTranspuestaB = new System.Windows.Forms.Button();
            this.btnInversaB = new System.Windows.Forms.Button();
            this.btnCofactoresB = new System.Windows.Forms.Button();
            this.btnDeterminanteB = new System.Windows.Forms.Button();
            this.rtxtInputB = new System.Windows.Forms.RichTextBox();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.btnLimpiarOutput = new System.Windows.Forms.Button();
            this.btnLimpiarA = new System.Windows.Forms.Button();
            this.btnLimpiarB = new System.Windows.Forms.Button();
            this.grpCalcularA.SuspendLayout();
            this.grpOperacionesEntreMatrices.SuspendLayout();
            this.grpCalcularB.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtInput
            // 
            this.rtxtInput.Location = new System.Drawing.Point(6, 21);
            this.rtxtInput.Name = "rtxtInput";
            this.rtxtInput.Size = new System.Drawing.Size(283, 115);
            this.rtxtInput.TabIndex = 0;
            this.rtxtInput.Text = "1 2 3;\n5 6 4;\n7 8 1;";
            // 
            // btnDeterminante
            // 
            this.btnDeterminante.Location = new System.Drawing.Point(6, 19);
            this.btnDeterminante.Name = "btnDeterminante";
            this.btnDeterminante.Size = new System.Drawing.Size(128, 53);
            this.btnDeterminante.TabIndex = 1;
            this.btnDeterminante.Text = "Determinante";
            this.btnDeterminante.UseVisualStyleBackColor = true;
            this.btnDeterminante.Click += new System.EventHandler(this.btnDeterminante_Click_1);
            // 
            // grpCalcularA
            // 
            this.grpCalcularA.Controls.Add(this.rtxtboxElevarA);
            this.grpCalcularA.Controls.Add(this.btnElevar);
            this.grpCalcularA.Controls.Add(this.rtxtboxMultiplicarA);
            this.grpCalcularA.Controls.Add(this.btnMultiplicar);
            this.grpCalcularA.Controls.Add(this.btnTranspuesta);
            this.grpCalcularA.Controls.Add(this.btnInversa);
            this.grpCalcularA.Controls.Add(this.btnCofactores);
            this.grpCalcularA.Controls.Add(this.btnDeterminante);
            this.grpCalcularA.Location = new System.Drawing.Point(6, 178);
            this.grpCalcularA.Name = "grpCalcularA";
            this.grpCalcularA.Size = new System.Drawing.Size(283, 175);
            this.grpCalcularA.TabIndex = 2;
            this.grpCalcularA.TabStop = false;
            this.grpCalcularA.Text = "Calcular:";
            // 
            // rtxtboxElevarA
            // 
            this.rtxtboxElevarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtboxElevarA.Location = new System.Drawing.Point(235, 138);
            this.rtxtboxElevarA.Name = "rtxtboxElevarA";
            this.rtxtboxElevarA.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtboxElevarA.Size = new System.Drawing.Size(33, 27);
            this.rtxtboxElevarA.TabIndex = 8;
            this.rtxtboxElevarA.Text = "2";
            // 
            // btnElevar
            // 
            this.btnElevar.Location = new System.Drawing.Point(140, 137);
            this.btnElevar.Name = "btnElevar";
            this.btnElevar.Size = new System.Drawing.Size(96, 28);
            this.btnElevar.TabIndex = 7;
            this.btnElevar.Text = "Elevar por";
            this.btnElevar.UseVisualStyleBackColor = true;
            this.btnElevar.Click += new System.EventHandler(this.btnElevar_Click);
            // 
            // rtxtboxMultiplicarA
            // 
            this.rtxtboxMultiplicarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtboxMultiplicarA.Location = new System.Drawing.Point(101, 138);
            this.rtxtboxMultiplicarA.Name = "rtxtboxMultiplicarA";
            this.rtxtboxMultiplicarA.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtboxMultiplicarA.Size = new System.Drawing.Size(33, 27);
            this.rtxtboxMultiplicarA.TabIndex = 6;
            this.rtxtboxMultiplicarA.Text = "2";
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(6, 137);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(96, 28);
            this.btnMultiplicar.TabIndex = 5;
            this.btnMultiplicar.Text = "Multiplicar por";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnTranspuesta
            // 
            this.btnTranspuesta.Location = new System.Drawing.Point(140, 19);
            this.btnTranspuesta.Name = "btnTranspuesta";
            this.btnTranspuesta.Size = new System.Drawing.Size(128, 53);
            this.btnTranspuesta.TabIndex = 2;
            this.btnTranspuesta.Text = "Transpuesta";
            this.btnTranspuesta.UseVisualStyleBackColor = true;
            this.btnTranspuesta.Click += new System.EventHandler(this.btnTranspuesta_Click_1);
            // 
            // btnInversa
            // 
            this.btnInversa.Location = new System.Drawing.Point(6, 78);
            this.btnInversa.Name = "btnInversa";
            this.btnInversa.Size = new System.Drawing.Size(128, 53);
            this.btnInversa.TabIndex = 3;
            this.btnInversa.Text = "Inversa";
            this.btnInversa.UseVisualStyleBackColor = true;
            this.btnInversa.Click += new System.EventHandler(this.btnInversa_Click_1);
            // 
            // btnCofactores
            // 
            this.btnCofactores.Location = new System.Drawing.Point(140, 78);
            this.btnCofactores.Name = "btnCofactores";
            this.btnCofactores.Size = new System.Drawing.Size(128, 53);
            this.btnCofactores.TabIndex = 4;
            this.btnCofactores.Text = "Cofactores";
            this.btnCofactores.UseVisualStyleBackColor = true;
            this.btnCofactores.Click += new System.EventHandler(this.btnCofactores_Click_1);
            // 
            // lblMatrizA
            // 
            this.lblMatrizA.AutoSize = true;
            this.lblMatrizA.Location = new System.Drawing.Point(6, 5);
            this.lblMatrizA.Name = "lblMatrizA";
            this.lblMatrizA.Size = new System.Drawing.Size(48, 13);
            this.lblMatrizA.TabIndex = 6;
            this.lblMatrizA.Text = "Matriz A:";
            // 
            // grpOperacionesEntreMatrices
            // 
            this.grpOperacionesEntreMatrices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpOperacionesEntreMatrices.Controls.Add(this.btnMultiplicarAB);
            this.grpOperacionesEntreMatrices.Controls.Add(this.btnRestarAB);
            this.grpOperacionesEntreMatrices.Controls.Add(this.btnSumarAB);
            this.grpOperacionesEntreMatrices.Controls.Add(this.btnIntercambiar);
            this.grpOperacionesEntreMatrices.Location = new System.Drawing.Point(295, 20);
            this.grpOperacionesEntreMatrices.Name = "grpOperacionesEntreMatrices";
            this.grpOperacionesEntreMatrices.Size = new System.Drawing.Size(200, 333);
            this.grpOperacionesEntreMatrices.TabIndex = 3;
            this.grpOperacionesEntreMatrices.TabStop = false;
            this.grpOperacionesEntreMatrices.Text = "Operaciones entre Matrices:";
            // 
            // btnMultiplicarAB
            // 
            this.btnMultiplicarAB.Location = new System.Drawing.Point(53, 191);
            this.btnMultiplicarAB.Name = "btnMultiplicarAB";
            this.btnMultiplicarAB.Size = new System.Drawing.Size(94, 44);
            this.btnMultiplicarAB.TabIndex = 3;
            this.btnMultiplicarAB.Text = " A * B";
            this.btnMultiplicarAB.UseVisualStyleBackColor = true;
            this.btnMultiplicarAB.Click += new System.EventHandler(this.btnMultiplicarAB_Click);
            // 
            // btnRestarAB
            // 
            this.btnRestarAB.Location = new System.Drawing.Point(53, 141);
            this.btnRestarAB.Name = "btnRestarAB";
            this.btnRestarAB.Size = new System.Drawing.Size(94, 44);
            this.btnRestarAB.TabIndex = 2;
            this.btnRestarAB.Text = "A - B";
            this.btnRestarAB.UseVisualStyleBackColor = true;
            this.btnRestarAB.Click += new System.EventHandler(this.btnRestarAB_Click);
            // 
            // btnSumarAB
            // 
            this.btnSumarAB.Location = new System.Drawing.Point(53, 91);
            this.btnSumarAB.Name = "btnSumarAB";
            this.btnSumarAB.Size = new System.Drawing.Size(94, 44);
            this.btnSumarAB.TabIndex = 1;
            this.btnSumarAB.Text = "A + B";
            this.btnSumarAB.UseVisualStyleBackColor = true;
            this.btnSumarAB.Click += new System.EventHandler(this.btnSumarAB_Click);
            // 
            // btnIntercambiar
            // 
            this.btnIntercambiar.Location = new System.Drawing.Point(53, 41);
            this.btnIntercambiar.Name = "btnIntercambiar";
            this.btnIntercambiar.Size = new System.Drawing.Size(94, 44);
            this.btnIntercambiar.TabIndex = 0;
            this.btnIntercambiar.Text = "Intercambiar";
            this.btnIntercambiar.UseVisualStyleBackColor = true;
            this.btnIntercambiar.Click += new System.EventHandler(this.btnIntercambiar_Click);
            // 
            // lblMatrizB
            // 
            this.lblMatrizB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatrizB.AutoSize = true;
            this.lblMatrizB.Location = new System.Drawing.Point(501, 5);
            this.lblMatrizB.Name = "lblMatrizB";
            this.lblMatrizB.Size = new System.Drawing.Size(48, 13);
            this.lblMatrizB.TabIndex = 11;
            this.lblMatrizB.Text = "Matriz B:";
            // 
            // grpCalcularB
            // 
            this.grpCalcularB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCalcularB.Controls.Add(this.rtxtboxElevarB);
            this.grpCalcularB.Controls.Add(this.btnElevarB);
            this.grpCalcularB.Controls.Add(this.rtxtboxMultiplicarB);
            this.grpCalcularB.Controls.Add(this.btnMultiplicarB);
            this.grpCalcularB.Controls.Add(this.btnTranspuestaB);
            this.grpCalcularB.Controls.Add(this.btnInversaB);
            this.grpCalcularB.Controls.Add(this.btnCofactoresB);
            this.grpCalcularB.Controls.Add(this.btnDeterminanteB);
            this.grpCalcularB.Location = new System.Drawing.Point(501, 178);
            this.grpCalcularB.Name = "grpCalcularB";
            this.grpCalcularB.Size = new System.Drawing.Size(283, 175);
            this.grpCalcularB.TabIndex = 6;
            this.grpCalcularB.TabStop = false;
            this.grpCalcularB.Text = "Calcular:";
            // 
            // rtxtboxElevarB
            // 
            this.rtxtboxElevarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtboxElevarB.Location = new System.Drawing.Point(235, 138);
            this.rtxtboxElevarB.Name = "rtxtboxElevarB";
            this.rtxtboxElevarB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtboxElevarB.Size = new System.Drawing.Size(33, 27);
            this.rtxtboxElevarB.TabIndex = 8;
            this.rtxtboxElevarB.Text = "2";
            // 
            // btnElevarB
            // 
            this.btnElevarB.Location = new System.Drawing.Point(140, 137);
            this.btnElevarB.Name = "btnElevarB";
            this.btnElevarB.Size = new System.Drawing.Size(96, 28);
            this.btnElevarB.TabIndex = 7;
            this.btnElevarB.Text = "Elevar por";
            this.btnElevarB.UseVisualStyleBackColor = true;
            this.btnElevarB.Click += new System.EventHandler(this.btnElevarB_Click);
            // 
            // rtxtboxMultiplicarB
            // 
            this.rtxtboxMultiplicarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtboxMultiplicarB.Location = new System.Drawing.Point(101, 138);
            this.rtxtboxMultiplicarB.Name = "rtxtboxMultiplicarB";
            this.rtxtboxMultiplicarB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtboxMultiplicarB.Size = new System.Drawing.Size(33, 27);
            this.rtxtboxMultiplicarB.TabIndex = 6;
            this.rtxtboxMultiplicarB.Text = "2";
            // 
            // btnMultiplicarB
            // 
            this.btnMultiplicarB.Location = new System.Drawing.Point(6, 137);
            this.btnMultiplicarB.Name = "btnMultiplicarB";
            this.btnMultiplicarB.Size = new System.Drawing.Size(96, 28);
            this.btnMultiplicarB.TabIndex = 5;
            this.btnMultiplicarB.Text = "Multiplicar por";
            this.btnMultiplicarB.UseVisualStyleBackColor = true;
            this.btnMultiplicarB.Click += new System.EventHandler(this.btnMultiplicarB_Click);
            // 
            // btnTranspuestaB
            // 
            this.btnTranspuestaB.Location = new System.Drawing.Point(140, 19);
            this.btnTranspuestaB.Name = "btnTranspuestaB";
            this.btnTranspuestaB.Size = new System.Drawing.Size(128, 53);
            this.btnTranspuestaB.TabIndex = 2;
            this.btnTranspuestaB.Text = "Transpuesta";
            this.btnTranspuestaB.UseVisualStyleBackColor = true;
            this.btnTranspuestaB.Click += new System.EventHandler(this.btnTranspuestaB_Click);
            // 
            // btnInversaB
            // 
            this.btnInversaB.Location = new System.Drawing.Point(6, 78);
            this.btnInversaB.Name = "btnInversaB";
            this.btnInversaB.Size = new System.Drawing.Size(128, 53);
            this.btnInversaB.TabIndex = 3;
            this.btnInversaB.Text = "Inversa";
            this.btnInversaB.UseVisualStyleBackColor = true;
            this.btnInversaB.Click += new System.EventHandler(this.btnInversaB_Click);
            // 
            // btnCofactoresB
            // 
            this.btnCofactoresB.Location = new System.Drawing.Point(140, 78);
            this.btnCofactoresB.Name = "btnCofactoresB";
            this.btnCofactoresB.Size = new System.Drawing.Size(128, 53);
            this.btnCofactoresB.TabIndex = 4;
            this.btnCofactoresB.Text = "Cofactores";
            this.btnCofactoresB.UseVisualStyleBackColor = true;
            this.btnCofactoresB.Click += new System.EventHandler(this.btnCofactoresB_Click);
            // 
            // btnDeterminanteB
            // 
            this.btnDeterminanteB.Location = new System.Drawing.Point(6, 19);
            this.btnDeterminanteB.Name = "btnDeterminanteB";
            this.btnDeterminanteB.Size = new System.Drawing.Size(128, 53);
            this.btnDeterminanteB.TabIndex = 1;
            this.btnDeterminanteB.Text = "Determinante";
            this.btnDeterminanteB.UseVisualStyleBackColor = true;
            this.btnDeterminanteB.Click += new System.EventHandler(this.btnDeterminanteB_Click);
            // 
            // rtxtInputB
            // 
            this.rtxtInputB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtInputB.Location = new System.Drawing.Point(501, 21);
            this.rtxtInputB.Name = "rtxtInputB";
            this.rtxtInputB.Size = new System.Drawing.Size(283, 115);
            this.rtxtInputB.TabIndex = 4;
            this.rtxtInputB.Text = "-2 2 -3;\n-1 1 3;\n2 0 -1;";
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtOutput.Location = new System.Drawing.Point(0, 394);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.Size = new System.Drawing.Size(793, 234);
            this.rtxtOutput.TabIndex = 8;
            this.rtxtOutput.Text = "";
            // 
            // btnLimpiarOutput
            // 
            this.btnLimpiarOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiarOutput.Location = new System.Drawing.Point(6, 358);
            this.btnLimpiarOutput.Name = "btnLimpiarOutput";
            this.btnLimpiarOutput.Size = new System.Drawing.Size(96, 30);
            this.btnLimpiarOutput.TabIndex = 7;
            this.btnLimpiarOutput.Text = "Limpiar";
            this.btnLimpiarOutput.UseVisualStyleBackColor = true;
            this.btnLimpiarOutput.Click += new System.EventHandler(this.btnLimpiarOutput_Click);
            // 
            // btnLimpiarA
            // 
            this.btnLimpiarA.Location = new System.Drawing.Point(6, 142);
            this.btnLimpiarA.Name = "btnLimpiarA";
            this.btnLimpiarA.Size = new System.Drawing.Size(96, 30);
            this.btnLimpiarA.TabIndex = 1;
            this.btnLimpiarA.Text = "Limpiar";
            this.btnLimpiarA.UseVisualStyleBackColor = true;
            this.btnLimpiarA.Click += new System.EventHandler(this.btnLimpiarA_Click);
            // 
            // btnLimpiarB
            // 
            this.btnLimpiarB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarB.Location = new System.Drawing.Point(501, 142);
            this.btnLimpiarB.Name = "btnLimpiarB";
            this.btnLimpiarB.Size = new System.Drawing.Size(96, 30);
            this.btnLimpiarB.TabIndex = 5;
            this.btnLimpiarB.Text = "Limpiar";
            this.btnLimpiarB.UseVisualStyleBackColor = true;
            this.btnLimpiarB.Click += new System.EventHandler(this.btnLimpiarB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 628);
            this.Controls.Add(this.btnLimpiarB);
            this.Controls.Add(this.btnLimpiarA);
            this.Controls.Add(this.btnLimpiarOutput);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.lblMatrizB);
            this.Controls.Add(this.grpCalcularB);
            this.Controls.Add(this.rtxtInputB);
            this.Controls.Add(this.grpOperacionesEntreMatrices);
            this.Controls.Add(this.lblMatrizA);
            this.Controls.Add(this.grpCalcularA);
            this.Controls.Add(this.rtxtInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de Matrices";
            this.grpCalcularA.ResumeLayout(false);
            this.grpOperacionesEntreMatrices.ResumeLayout(false);
            this.grpCalcularB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtInput;
        private System.Windows.Forms.Button btnDeterminante;
        private System.Windows.Forms.GroupBox grpCalcularA;
        private System.Windows.Forms.Label lblMatrizA;
        private System.Windows.Forms.Button btnTranspuesta;
        private System.Windows.Forms.Button btnInversa;
        private System.Windows.Forms.Button btnCofactores;
        private System.Windows.Forms.GroupBox grpOperacionesEntreMatrices;
        private System.Windows.Forms.Label lblMatrizB;
        private System.Windows.Forms.GroupBox grpCalcularB;
        private System.Windows.Forms.Button btnTranspuestaB;
        private System.Windows.Forms.Button btnInversaB;
        private System.Windows.Forms.Button btnCofactoresB;
        private System.Windows.Forms.Button btnDeterminanteB;
        private System.Windows.Forms.RichTextBox rtxtInputB;
        private System.Windows.Forms.RichTextBox rtxtOutput;
        private System.Windows.Forms.RichTextBox rtxtboxMultiplicarB;
        private System.Windows.Forms.Button btnMultiplicarB;
        private System.Windows.Forms.RichTextBox rtxtboxElevarA;
        private System.Windows.Forms.Button btnElevar;
        private System.Windows.Forms.RichTextBox rtxtboxMultiplicarA;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.RichTextBox rtxtboxElevarB;
        private System.Windows.Forms.Button btnElevarB;
        private System.Windows.Forms.Button btnMultiplicarAB;
        private System.Windows.Forms.Button btnRestarAB;
        private System.Windows.Forms.Button btnSumarAB;
        private System.Windows.Forms.Button btnIntercambiar;
        private System.Windows.Forms.Button btnLimpiarOutput;
        private System.Windows.Forms.Button btnLimpiarA;
        private System.Windows.Forms.Button btnLimpiarB;
    }
}

