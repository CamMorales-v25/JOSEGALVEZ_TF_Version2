
namespace Presentacion
{
    partial class FormAsignarClase
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
            this.btnBuscarClasesHabiles = new System.Windows.Forms.Button();
            this.lblAforoDisponible = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNum_TotalDeRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscandoClasesHabiles = new System.Windows.Forms.TextBox();
            this.cmbFiltrarPorClasesHabiles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgClasesHabiles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDNIAlumno = new System.Windows.Forms.TextBox();
            this.cmbEstadoDePago = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtCodigoClase = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNum_TotalDeRegistrosAlumnosClasesAsignados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarClasesReservadas = new System.Windows.Forms.Button();
            this.txtBuscandoClasesReservadas = new System.Windows.Forms.TextBox();
            this.cmbFiltrarPorClasesReservadas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgClasesReservadas = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgClasesHabiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClasesReservadas)).BeginInit();
            this.ssFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(309, 209);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 39);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(165, 209);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 39);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Location = new System.Drawing.Point(21, 210);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(139, 37);
            this.btnRegistrar.TabIndex = 56;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnBuscarClasesHabiles);
            this.groupBox2.Controls.Add(this.lblAforoDisponible);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblNum_TotalDeRegistros);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBuscandoClasesHabiles);
            this.groupBox2.Controls.Add(this.cmbFiltrarPorClasesHabiles);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgClasesHabiles);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(469, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(627, 245);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clases hábiles";
            // 
            // btnBuscarClasesHabiles
            // 
            this.btnBuscarClasesHabiles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscarClasesHabiles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarClasesHabiles.Location = new System.Drawing.Point(488, 18);
            this.btnBuscarClasesHabiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarClasesHabiles.Name = "btnBuscarClasesHabiles";
            this.btnBuscarClasesHabiles.Size = new System.Drawing.Size(112, 39);
            this.btnBuscarClasesHabiles.TabIndex = 72;
            this.btnBuscarClasesHabiles.Text = "Buscar";
            this.btnBuscarClasesHabiles.UseVisualStyleBackColor = false;
            this.btnBuscarClasesHabiles.Click += new System.EventHandler(this.btnBuscarClasesHabiles_Click);
            // 
            // lblAforoDisponible
            // 
            this.lblAforoDisponible.AutoSize = true;
            this.lblAforoDisponible.ForeColor = System.Drawing.Color.Black;
            this.lblAforoDisponible.Location = new System.Drawing.Point(221, 210);
            this.lblAforoDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAforoDisponible.Name = "lblAforoDisponible";
            this.lblAforoDisponible.Size = new System.Drawing.Size(16, 17);
            this.lblAforoDisponible.TabIndex = 14;
            this.lblAforoDisponible.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aforo Disponible:";
            // 
            // lblNum_TotalDeRegistros
            // 
            this.lblNum_TotalDeRegistros.AutoSize = true;
            this.lblNum_TotalDeRegistros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNum_TotalDeRegistros.Location = new System.Drawing.Point(583, 210);
            this.lblNum_TotalDeRegistros.Name = "lblNum_TotalDeRegistros";
            this.lblNum_TotalDeRegistros.Size = new System.Drawing.Size(16, 17);
            this.lblNum_TotalDeRegistros.TabIndex = 12;
            this.lblNum_TotalDeRegistros.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(440, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total de registros:";
            // 
            // txtBuscandoClasesHabiles
            // 
            this.txtBuscandoClasesHabiles.Location = new System.Drawing.Point(311, 27);
            this.txtBuscandoClasesHabiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscandoClasesHabiles.Name = "txtBuscandoClasesHabiles";
            this.txtBuscandoClasesHabiles.Size = new System.Drawing.Size(156, 22);
            this.txtBuscandoClasesHabiles.TabIndex = 10;
            // 
            // cmbFiltrarPorClasesHabiles
            // 
            this.cmbFiltrarPorClasesHabiles.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbFiltrarPorClasesHabiles.FormattingEnabled = true;
            this.cmbFiltrarPorClasesHabiles.Items.AddRange(new object[] {
            "Tipo de Licencia",
            "Nombre de Profesor"});
            this.cmbFiltrarPorClasesHabiles.Location = new System.Drawing.Point(145, 27);
            this.cmbFiltrarPorClasesHabiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltrarPorClasesHabiles.Name = "cmbFiltrarPorClasesHabiles";
            this.cmbFiltrarPorClasesHabiles.Size = new System.Drawing.Size(143, 24);
            this.cmbFiltrarPorClasesHabiles.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(43, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtrar por:";
            // 
            // dgClasesHabiles
            // 
            this.dgClasesHabiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClasesHabiles.Location = new System.Drawing.Point(9, 66);
            this.dgClasesHabiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgClasesHabiles.Name = "dgClasesHabiles";
            this.dgClasesHabiles.RowHeadersWidth = 51;
            this.dgClasesHabiles.RowTemplate.Height = 24;
            this.dgClasesHabiles.Size = new System.Drawing.Size(597, 132);
            this.dgClasesHabiles.TabIndex = 7;
            this.dgClasesHabiles.SelectionChanged += new System.EventHandler(this.dgClasesHabiles_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtDNIAlumno);
            this.groupBox1.Controls.Add(this.cmbEstadoDePago);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtCodigoClase);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(21, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(429, 187);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtDNIAlumno
            // 
            this.txtDNIAlumno.Location = new System.Drawing.Point(128, 79);
            this.txtDNIAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNIAlumno.MaxLength = 8;
            this.txtDNIAlumno.Name = "txtDNIAlumno";
            this.txtDNIAlumno.Size = new System.Drawing.Size(145, 22);
            this.txtDNIAlumno.TabIndex = 28;
            // 
            // cmbEstadoDePago
            // 
            this.cmbEstadoDePago.FormattingEnabled = true;
            this.cmbEstadoDePago.Items.AddRange(new object[] {
            "Pendiente",
            "Pagado"});
            this.cmbEstadoDePago.Location = new System.Drawing.Point(128, 34);
            this.cmbEstadoDePago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstadoDePago.Name = "cmbEstadoDePago";
            this.cmbEstadoDePago.Size = new System.Drawing.Size(145, 24);
            this.cmbEstadoDePago.TabIndex = 20;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Location = new System.Drawing.Point(5, 82);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(86, 17);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.Text = "DNI Alumno:";
            // 
            // txtCodigoClase
            // 
            this.txtCodigoClase.Location = new System.Drawing.Point(128, 124);
            this.txtCodigoClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoClase.Name = "txtCodigoClase";
            this.txtCodigoClase.ReadOnly = true;
            this.txtCodigoClase.Size = new System.Drawing.Size(145, 22);
            this.txtCodigoClase.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Location = new System.Drawing.Point(7, 127);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(113, 17);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.Text = "Codigo de clase:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado de pago:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lblNum_TotalDeRegistrosAlumnosClasesAsignados);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnBuscarClasesReservadas);
            this.groupBox3.Controls.Add(this.txtBuscandoClasesReservadas);
            this.groupBox3.Controls.Add(this.cmbFiltrarPorClasesReservadas);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dgClasesReservadas);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox3.Location = new System.Drawing.Point(21, 270);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1076, 233);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Clases reservadas";
            // 
            // lblNum_TotalDeRegistrosAlumnosClasesAsignados
            // 
            this.lblNum_TotalDeRegistrosAlumnosClasesAsignados.AutoSize = true;
            this.lblNum_TotalDeRegistrosAlumnosClasesAsignados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNum_TotalDeRegistrosAlumnosClasesAsignados.Location = new System.Drawing.Point(1009, 204);
            this.lblNum_TotalDeRegistrosAlumnosClasesAsignados.Name = "lblNum_TotalDeRegistrosAlumnosClasesAsignados";
            this.lblNum_TotalDeRegistrosAlumnosClasesAsignados.Size = new System.Drawing.Size(16, 17);
            this.lblNum_TotalDeRegistrosAlumnosClasesAsignados.TabIndex = 73;
            this.lblNum_TotalDeRegistrosAlumnosClasesAsignados.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(679, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "Total de registros de Alumnos Asignados a Clases:";
            // 
            // btnBuscarClasesReservadas
            // 
            this.btnBuscarClasesReservadas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscarClasesReservadas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarClasesReservadas.Location = new System.Drawing.Point(936, 14);
            this.btnBuscarClasesReservadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarClasesReservadas.Name = "btnBuscarClasesReservadas";
            this.btnBuscarClasesReservadas.Size = new System.Drawing.Size(112, 39);
            this.btnBuscarClasesReservadas.TabIndex = 71;
            this.btnBuscarClasesReservadas.Text = "Buscar";
            this.btnBuscarClasesReservadas.UseVisualStyleBackColor = false;
            this.btnBuscarClasesReservadas.Click += new System.EventHandler(this.btnBuscarClasesReservadas_Click);
            // 
            // txtBuscandoClasesReservadas
            // 
            this.txtBuscandoClasesReservadas.Location = new System.Drawing.Point(725, 21);
            this.txtBuscandoClasesReservadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscandoClasesReservadas.Name = "txtBuscandoClasesReservadas";
            this.txtBuscandoClasesReservadas.Size = new System.Drawing.Size(193, 22);
            this.txtBuscandoClasesReservadas.TabIndex = 10;
            // 
            // cmbFiltrarPorClasesReservadas
            // 
            this.cmbFiltrarPorClasesReservadas.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbFiltrarPorClasesReservadas.FormattingEnabled = true;
            this.cmbFiltrarPorClasesReservadas.Items.AddRange(new object[] {
            "Estado de Pago",
            "DNI Alumno"});
            this.cmbFiltrarPorClasesReservadas.Location = new System.Drawing.Point(560, 21);
            this.cmbFiltrarPorClasesReservadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltrarPorClasesReservadas.Name = "cmbFiltrarPorClasesReservadas";
            this.cmbFiltrarPorClasesReservadas.Size = new System.Drawing.Size(143, 24);
            this.cmbFiltrarPorClasesReservadas.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(459, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Filtrar por:";
            // 
            // dgClasesReservadas
            // 
            this.dgClasesReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClasesReservadas.Location = new System.Drawing.Point(9, 63);
            this.dgClasesReservadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgClasesReservadas.Name = "dgClasesReservadas";
            this.dgClasesReservadas.RowHeadersWidth = 51;
            this.dgClasesReservadas.RowTemplate.Height = 24;
            this.dgClasesReservadas.Size = new System.Drawing.Size(1039, 130);
            this.dgClasesReservadas.TabIndex = 7;
            this.dgClasesReservadas.SelectionChanged += new System.EventHandler(this.dgClasesReservadas_SelectionChanged);
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
            this.ssFooter.Location = new System.Drawing.Point(0, 506);
            this.ssFooter.Name = "ssFooter";
            this.ssFooter.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.ssFooter.Size = new System.Drawing.Size(1121, 26);
            this.ssFooter.TabIndex = 60;
            this.ssFooter.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 20);
            this.toolStripStatusLabel1.Text = "Creado por:";
            // 
            // ssCreadoPor
            // 
            this.ssCreadoPor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssCreadoPor.Name = "ssCreadoPor";
            this.ssCreadoPor.Size = new System.Drawing.Size(78, 20);
            this.ssCreadoPor.Text = "CreadoPor";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(24, 20);
            this.toolStripStatusLabel2.Text = "el:";
            // 
            // ssCreadoEl
            // 
            this.ssCreadoEl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssCreadoEl.Name = "ssCreadoEl";
            this.ssCreadoEl.Size = new System.Drawing.Size(69, 20);
            this.ssCreadoEl.Text = "CreadoEl";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(116, 20);
            this.toolStripStatusLabel3.Text = "Modificado por:";
            // 
            // ssModificadoPor
            // 
            this.ssModificadoPor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssModificadoPor.Name = "ssModificadoPor";
            this.ssModificadoPor.Size = new System.Drawing.Size(107, 20);
            this.ssModificadoPor.Text = "ModificadoPor";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(24, 20);
            this.toolStripStatusLabel5.Text = "el:";
            // 
            // ssModificadoEl
            // 
            this.ssModificadoEl.BackColor = System.Drawing.SystemColors.Control;
            this.ssModificadoEl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssModificadoEl.Name = "ssModificadoEl";
            this.ssModificadoEl.Size = new System.Drawing.Size(98, 20);
            this.ssModificadoEl.Text = "ModificadoEl";
            // 
            // FormAsignarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 532);
            this.Controls.Add(this.ssFooter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAsignarClase";
            this.Text = "FormAsignarClase";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClasesHabiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClasesReservadas)).EndInit();
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
        private System.Windows.Forms.TextBox txtBuscandoClasesHabiles;
        private System.Windows.Forms.ComboBox cmbFiltrarPorClasesHabiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgClasesHabiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEstadoDePago;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.TextBox txtCodigoClase;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscandoClasesReservadas;
        private System.Windows.Forms.ComboBox cmbFiltrarPorClasesReservadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgClasesReservadas;
        private System.Windows.Forms.Button btnBuscarClasesReservadas;
        private System.Windows.Forms.StatusStrip ssFooter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ssCreadoPor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ssCreadoEl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ssModificadoPor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel ssModificadoEl;
        private System.Windows.Forms.TextBox txtDNIAlumno;
        private System.Windows.Forms.Label lblAforoDisponible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarClasesHabiles;
        private System.Windows.Forms.Label lblNum_TotalDeRegistrosAlumnosClasesAsignados;
        private System.Windows.Forms.Label label4;
    }
}