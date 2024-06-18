
namespace Presentacion
{
    partial class FormClaseMantenimiento
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNum_TotalDeRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscando = new System.Windows.Forms.TextBox();
            this.cmbFiltrarPor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgClases = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNombreProfesor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIntervaloDeHoras = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoDeLicencia = new System.Windows.Forms.ComboBox();
            this.cmbTipoClase = new System.Windows.Forms.ComboBox();
            this.cmbAforoDeClase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chActivo = new System.Windows.Forms.CheckBox();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.ssFooter = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssCreadoPor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssCreadoEl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssModificadoPor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssModificadoEl = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClases)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ssFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(568, 167);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 32);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(568, 124);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 32);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Location = new System.Drawing.Point(568, 37);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(104, 32);
            this.btnRegistrar.TabIndex = 46;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.lblNum_TotalDeRegistros);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBuscando);
            this.groupBox2.Controls.Add(this.cmbFiltrarPor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgClases);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(41, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(658, 197);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clases";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(569, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 32);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNum_TotalDeRegistros
            // 
            this.lblNum_TotalDeRegistros.AutoSize = true;
            this.lblNum_TotalDeRegistros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNum_TotalDeRegistros.Location = new System.Drawing.Point(597, 171);
            this.lblNum_TotalDeRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum_TotalDeRegistros.Name = "lblNum_TotalDeRegistros";
            this.lblNum_TotalDeRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblNum_TotalDeRegistros.TabIndex = 12;
            this.lblNum_TotalDeRegistros.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(490, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total de registros:";
            // 
            // txtBuscando
            // 
            this.txtBuscando.Location = new System.Drawing.Point(397, 21);
            this.txtBuscando.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscando.Name = "txtBuscando";
            this.txtBuscando.Size = new System.Drawing.Size(146, 19);
            this.txtBuscando.TabIndex = 10;
            // 
            // cmbFiltrarPor
            // 
            this.cmbFiltrarPor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbFiltrarPor.FormattingEnabled = true;
            this.cmbFiltrarPor.Items.AddRange(new object[] {
            "Tipo de Licencia",
            "Nombre de Profesor"});
            this.cmbFiltrarPor.Location = new System.Drawing.Point(273, 21);
            this.cmbFiltrarPor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltrarPor.Name = "cmbFiltrarPor";
            this.cmbFiltrarPor.Size = new System.Drawing.Size(108, 21);
            this.cmbFiltrarPor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(196, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtrar por:";
            // 
            // dgClases
            // 
            this.dgClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClases.Location = new System.Drawing.Point(7, 54);
            this.dgClases.Margin = new System.Windows.Forms.Padding(2);
            this.dgClases.Name = "dgClases";
            this.dgClases.RowHeadersWidth = 51;
            this.dgClases.RowTemplate.Height = 24;
            this.dgClases.Size = new System.Drawing.Size(646, 107);
            this.dgClases.TabIndex = 7;
            this.dgClases.SelectionChanged += new System.EventHandler(this.dgClases_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cmbNombreProfesor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbIntervaloDeHoras);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTipoDeLicencia);
            this.groupBox1.Controls.Add(this.cmbTipoClase);
            this.groupBox1.Controls.Add(this.cmbAforoDeClase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chActivo);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(41, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(489, 172);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cmbNombreProfesor
            // 
            this.cmbNombreProfesor.FormattingEnabled = true;
            this.cmbNombreProfesor.Location = new System.Drawing.Point(344, 67);
            this.cmbNombreProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNombreProfesor.Name = "cmbNombreProfesor";
            this.cmbNombreProfesor.Size = new System.Drawing.Size(123, 21);
            this.cmbNombreProfesor.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nombre del profesor:";
            // 
            // cmbIntervaloDeHoras
            // 
            this.cmbIntervaloDeHoras.FormattingEnabled = true;
            this.cmbIntervaloDeHoras.Items.AddRange(new object[] {
            "08:00 AM - 10:00 AM",
            "09:00 AM - 11:00 AM",
            "10:00 AM - 12:00 PM",
            "11:00 AM - 13:00 PM",
            "12:00 PM - 14:00 PM",
            "14:00 PM - 16:00 PM",
            "15:00 PM - 17:00 PM",
            "16:00 PM - 18:00 PM",
            "17:00 PM - 19:00 PM",
            "18:00 PM - 20:00 PM"});
            this.cmbIntervaloDeHoras.Location = new System.Drawing.Point(344, 28);
            this.cmbIntervaloDeHoras.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIntervaloDeHoras.Name = "cmbIntervaloDeHoras";
            this.cmbIntervaloDeHoras.Size = new System.Drawing.Size(123, 21);
            this.cmbIntervaloDeHoras.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Intervalo de horas:";
            // 
            // cmbTipoDeLicencia
            // 
            this.cmbTipoDeLicencia.FormattingEnabled = true;
            this.cmbTipoDeLicencia.Items.AddRange(new object[] {
            "Licencia A-I",
            "Licencia A-IIa",
            "Licencia A-IIb",
            "Licencia A-IIIa",
            "Licencia A-IIIb",
            "Licencia A-IIIc"});
            this.cmbTipoDeLicencia.Location = new System.Drawing.Point(96, 107);
            this.cmbTipoDeLicencia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoDeLicencia.Name = "cmbTipoDeLicencia";
            this.cmbTipoDeLicencia.Size = new System.Drawing.Size(110, 21);
            this.cmbTipoDeLicencia.TabIndex = 21;
            this.cmbTipoDeLicencia.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeLicencia_SelectedIndexChanged);
            // 
            // cmbTipoClase
            // 
            this.cmbTipoClase.FormattingEnabled = true;
            this.cmbTipoClase.Items.AddRange(new object[] {
            "Clase Teórica",
            "Clase Práctica"});
            this.cmbTipoClase.Location = new System.Drawing.Point(96, 28);
            this.cmbTipoClase.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoClase.Name = "cmbTipoClase";
            this.cmbTipoClase.Size = new System.Drawing.Size(110, 21);
            this.cmbTipoClase.TabIndex = 20;
            this.cmbTipoClase.SelectedIndexChanged += new System.EventHandler(this.cmbTipoClase_SelectedIndexChanged);
            // 
            // cmbAforoDeClase
            // 
            this.cmbAforoDeClase.FormattingEnabled = true;
            this.cmbAforoDeClase.Location = new System.Drawing.Point(96, 67);
            this.cmbAforoDeClase.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAforoDeClase.Name = "cmbAforoDeClase";
            this.cmbAforoDeClase.Size = new System.Drawing.Size(110, 21);
            this.cmbAforoDeClase.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tipo de Licencia:";
            // 
            // chActivo
            // 
            this.chActivo.AutoSize = true;
            this.chActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chActivo.Location = new System.Drawing.Point(410, 145);
            this.chActivo.Margin = new System.Windows.Forms.Padding(2);
            this.chActivo.Name = "chActivo";
            this.chActivo.Size = new System.Drawing.Size(63, 20);
            this.chActivo.TabIndex = 15;
            this.chActivo.Text = "Activo";
            this.chActivo.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Location = new System.Drawing.Point(4, 67);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(74, 13);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.Text = "Aforo Máximo:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(344, 107);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 19);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Location = new System.Drawing.Point(224, 107);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(40, 13);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de clase:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(20, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(690, 401);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(568, 80);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 33);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // ssFooter
            // 
            this.ssFooter.BackColor = System.Drawing.SystemColors.Control;
            this.ssFooter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssFooter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ssCreadoPor,
            this.toolStripStatusLabel2,
            this.ssCreadoEl,
            this.toolStripStatusLabel3,
            this.ssModificadoPor,
            this.toolStripStatusLabel5,
            this.ssModificadoEl});
            this.ssFooter.Location = new System.Drawing.Point(0, 440);
            this.ssFooter.Name = "ssFooter";
            this.ssFooter.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.ssFooter.Size = new System.Drawing.Size(728, 22);
            this.ssFooter.TabIndex = 50;
            this.ssFooter.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Creado por:";
            // 
            // ssCreadoPor
            // 
            this.ssCreadoPor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssCreadoPor.Name = "ssCreadoPor";
            this.ssCreadoPor.Size = new System.Drawing.Size(63, 17);
            this.ssCreadoPor.Text = "CreadoPor";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel2.Text = "el:";
            // 
            // ssCreadoEl
            // 
            this.ssCreadoEl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssCreadoEl.Name = "ssCreadoEl";
            this.ssCreadoEl.Size = new System.Drawing.Size(54, 17);
            this.ssCreadoEl.Text = "CreadoEl";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel3.Text = "Modificado por:";
            // 
            // ssModificadoPor
            // 
            this.ssModificadoPor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssModificadoPor.Name = "ssModificadoPor";
            this.ssModificadoPor.Size = new System.Drawing.Size(86, 17);
            this.ssModificadoPor.Text = "ModificadoPor";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel5.Text = "el:";
            // 
            // ssModificadoEl
            // 
            this.ssModificadoEl.BackColor = System.Drawing.SystemColors.Control;
            this.ssModificadoEl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssModificadoEl.Name = "ssModificadoEl";
            this.ssModificadoEl.Size = new System.Drawing.Size(77, 17);
            this.ssModificadoEl.Text = "ModificadoEl";
            // 
            // FormClaseMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(728, 462);
            this.Controls.Add(this.ssFooter);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormClaseMantenimiento";
            this.Text = "FormClaseMantenimiento";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClases)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ssFooter.ResumeLayout(false);
            this.ssFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNum_TotalDeRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscando;
        private System.Windows.Forms.ComboBox cmbFiltrarPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgClases;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chActivo;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbTipoClase;
        private System.Windows.Forms.ComboBox cmbAforoDeClase;
        private System.Windows.Forms.ComboBox cmbNombreProfesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIntervaloDeHoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoDeLicencia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.StatusStrip ssFooter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ssCreadoPor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ssCreadoEl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ssModificadoPor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel ssModificadoEl;
    }
}